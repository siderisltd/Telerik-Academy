using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace TelerikDefender
{
    public enum Directions
    {
        Up,
        Down,
        Left,
        Right
    }

    ;
    public struct Point 
    {
        public int Column;
        public int Row;

        public Point(int col, int row)
        {
            this.Column = col;
            this.Row = row;
        }

        public override bool Equals(object other)
        {
            return other is Point && this == (Point)other;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Column == p2.Column && p1.Row == p2.Row;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }
    }

    /// <summary>
    /// Basic Game object class.
    /// </summary>
    public class GameObject
    {
        private ConsoleColor color = ConsoleColor.White;
        private string filePath = Environment.CurrentDirectory; // gets the path of the .exe file
        private string[] graphic;                               // builds an array of strings , each element containing a row line from the .txt file
        public int col;                                         // the column coordinate of the object
        public int row;                                         // the row coordinate of the object
        internal int objectHight;                               // the height of the object based on the lines of the .txt file
        internal int objectWidth;                               // the width of the object based on the length of the first line in the .txt file
        
        internal System.Timers.Timer animationSpeed;            // the frame rate of the animation
        internal System.Timers.Timer animationDuration;         // the duration of the animation
        private Directions currentDirection = Directions.Down;  // the current direction of the animation   
        private int objectSpeed;                                // the offset of the objects position each time it has been printed on the screen
        static readonly object locker = new object();           // used for thread locking thus removing animation glitches.
        public int TopConstraint = 0;                           // a margin for the possible top position of the object
        public int BottomConstraint = 0;
        public int LeftConstraint = 0;
        public int RightConstraint = 0;
            // a margin for the possible bottom position of the object
        public List<Point> Points;                              // a list containing the coordinates of all the characters used to print the graphic;
        

        /// <summary>
        /// Gets or sets the color of the object.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        /// <summary>
        /// Class Constructor
        /// </summary>
        /// <param name="fileName"> The name of the file that will be used 
        /// to graphically represent the object</param>
        /// <param name="posX">The column of the console to print to. Default  = 1</param>
        /// <param name="posY">The row of the console to print to. Default  = 1</param>
        public GameObject(string fileName, int posX=1, int posY=1)
        {
            this.graphic = System.IO.File.ReadAllLines(this.filePath + "\\" + "Assets" + "\\" + "Graphics" + "\\" + fileName);
            this.objectHight = this.graphic.Length;
            this.objectWidth = this.graphic[0].Length;
            this.col = posX;
            this.row = posY;
            Points = new List<Point>();
        }

        /// <summary>
        /// A method that prints the object to the console using the .txt file provided in the class constructor
        /// </summary>
        public void Draw()
        {
            lock (locker)
            {
                int rowCounter = 0;
                int tempCol = this.col;
                int tempRow = this.row;
                
                foreach (var line in this.graphic)
                {
                    Console.ForegroundColor = this.Color;
                    Console.SetCursorPosition(this.col, this.row + rowCounter);
                    Console.WriteLine(line);
                    rowCounter++;
                }
                Points.Clear();
                foreach (var strLine in this.graphic)
                {
                    foreach (var symbol in strLine)
                    {
                        if (symbol != ' ')
                        {
                            Points.Add(new Point(tempCol, tempRow));
                        }
                        tempCol++;
                    }
                    tempRow++;
                }
            }
        }

        public void Draw(string[] graphic)
        {
            lock (locker)
            {
                int rowCounter = 0;
                int tempCol = this.col;
                int tempRow = this.row;

                foreach (var line in graphic)
                {
                    Console.ForegroundColor = this.Color;
                    Console.SetCursorPosition(this.col, this.row + rowCounter);
                    Console.WriteLine(line);
                    rowCounter++;
                }
                Points.Clear();
                foreach (var strLine in graphic)
                {
                    foreach (var symbol in strLine)
                    {
                        if (symbol != ' ')
                        {
                            Points.Add(new Point(tempCol, tempRow));
                        }
                        tempCol++;
                    }
                    tempRow++;
                }
            }
        }

        /// <summary>
        /// Clears the object from the console by using a black color and printing over the object.
        /// </summary>
        public void Clear()
        {
            lock (locker)
            {
                ConsoleColor tmp = this.color;
                int rowCounter = 0;
                foreach (var line in this.graphic)
                {
                    this.color = ConsoleColor.Black;
                    Console.ForegroundColor = this.Color;
                    Console.SetCursorPosition(col, row + rowCounter);
                    Console.WriteLine(line);
                    rowCounter++;
                }
                this.color = tmp;
            }
        }

        public void Clear(string[] graphic)
        {
            lock (locker)
            {
                ConsoleColor tmp = this.color;
                int rowCounter = 0;
                foreach (var line in graphic)
                {
                    this.color = ConsoleColor.Black;
                    Console.ForegroundColor = this.Color;
                    Console.SetCursorPosition(col, row + rowCounter);
                    Console.WriteLine(line);
                    rowCounter++;
                }
                this.color = tmp;
            }
        }

        /// <summary>
        /// Moves the object in the specified direction, by a specified distance ( speed ).
        /// </summary>
        /// <param name="direction">The direction of movement. Use Directions.Up , Directions.Down
        /// Directions.Left, Directions.Right .</param>
        /// <param name="speed">The distance e.g the offset from the current position.</param>
        public void Move(Directions direction, int speed)
        {
            Clear();
            switch(direction)
            {
                case(Directions.Up):
                    if (this.row - speed > 0 + TopConstraint)
                    {
                        this.row -= speed;
                    }
                    else
                        this.row = TopConstraint;
                    
                    break;
                case(Directions.Down):
                    if (this.row + speed < Console.WindowHeight - objectHight - BottomConstraint)
                    {
                        this.row += speed;
                    }
                    else
                        this.row = Console.WindowHeight - objectHight - 1 - BottomConstraint;
                    
                    break;
                case (Directions.Left):
                    if (this.col - speed > LeftConstraint)
                    {
                        this.col -= speed;
                    }
                    else
                        this.col = LeftConstraint;
                    
                    break;
                case (Directions.Right):
                    if (this.col + speed < Console.WindowWidth - objectWidth - RightConstraint)
                    {
                        this.col += speed;
                    }
                    else
                        this.col = Console.WindowWidth - objectWidth - RightConstraint;
                    
                    break;
                default:
                    break;
            }
            Draw();
        }

        public void AnimateUpDown(int duration, int animSpeed, int objectSpeed)
        {
            animationSpeed = new System.Timers.Timer(animSpeed);
            animationSpeed.Elapsed += new ElapsedEventHandler(FrameElapsed);
            animationSpeed.Start();

            animationDuration = new System.Timers.Timer(duration);
            animationDuration.Elapsed += new ElapsedEventHandler(EdnOfDuration);
            animationDuration.Start();
                
            this.objectSpeed = objectSpeed;
        }

        public void Dispose()
        {
            this.animationSpeed.Stop();
            this.animationDuration.Stop();
            this.Clear();
        }

        private void EdnOfDuration(object sender, ElapsedEventArgs e)
        {
            if (this.currentDirection == Directions.Up)
            {
                this.currentDirection = Directions.Down;  
            }
            else
                this.currentDirection = Directions.Up;
        }

        private void FrameElapsed(object sender, ElapsedEventArgs e)
        {
            this.Move(this.currentDirection, this.objectSpeed);
        }

        //TODO
        public void PlaySound(string soundFile)
        {
            throw new NotImplementedException(" Not YeT Implemented");
        }
    }
}
