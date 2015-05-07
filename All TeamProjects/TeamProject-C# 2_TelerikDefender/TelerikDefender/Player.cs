using System;
using System.Linq;
using System.Timers;
using System.Collections.Generic;
namespace TelerikDefender
{
    /// <summary>
    /// A child class of GameObject - inherits all properties and methods of GameObject and 
    /// adds a functionality to control the movement of the object with the arrow keys.
    /// </summary>
    public class Player : GameObject
    {
        
        private string[] graphic2 = System.IO.File.ReadAllLines(Environment.CurrentDirectory + "\\" + "Assets" + "\\" + "Graphics" + "\\" + "ninjaSwipe.txt");
        public bool isSwiping = false;
        private GameObject shuriken;
        private const int animSpeed = 70;
        private Timer shurAnimTimer;
        public  List<GameObject> flyingShurs = new List<GameObject>(); // a list to store all the flying shurikesns at the moment;
        
        public Player(string fileName, int posX = 1, int posY = 1)
            : base(fileName, posX, posY)
        {
            shurAnimTimer = new Timer(animSpeed);
            shurAnimTimer.Elapsed += new ElapsedEventHandler(shurAnimTimer_Elapsed);
            shurAnimTimer.Start();
            this.Color = ConsoleColor.Cyan;
        }
        
        /// <summary>
        /// A method used to control the movement of the object using the arrow keys
        /// </summary>
        /// <param name="speed">The amount of offset of the object from its original position. Default is 5 </param>
        public void Control(int speed = 5)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    this.Move(Directions.Right, speed);

                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    this.Move(Directions.Left, speed);
                }
                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    this.Move(Directions.Up, speed);
                }
                if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    this.Move(Directions.Down, speed);
                }
                if (pressedKey.Key == ConsoleKey.Escape)
                {
                    //TODO exit game
                }
                if (pressedKey.Key == ConsoleKey.Spacebar)
                {
                    Sounds.SwordSwipe.Play();
                    this.Clear();
                    this.Draw(graphic2);
                    this.isSwiping = true;
                    System.Threading.Thread.Sleep(100);
                    this.Clear(graphic2);
                    this.Draw();
                    this.isSwiping = false;
                }
                if (pressedKey.Key == ConsoleKey.P)
                {
                    Pause.pause();
                }
                if (pressedKey.Key == ConsoleKey.F && Game.NinjaStars>0)
                {
                    this.ThrowShuriken();
                }

            }

        }

        private void ThrowShuriken()
        {
            shuriken = new GameObject("Shuriken.txt", this.col + this.objectWidth, this.row + 1);
            shuriken.Color = ConsoleColor.Cyan;
            this.flyingShurs.Add(shuriken);
            Game.NinjaStars--;
            Game.UpdateNinjaStars();
        }
        
        private void shurAnimTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (this.flyingShurs.Count > 0)
            {
                foreach (var shuriken in this.flyingShurs)
                {
                    // check if shuriken hits the enemy
                    if (shuriken.col + shuriken.objectWidth / 2 == Game.Enemy.col &&
                        (shuriken.row + 3 >= Game.Enemy.row && shuriken.row + 3 <= Game.Enemy.row + Game.Enemy.objectHight))
                    {
                        shuriken.Color = ConsoleColor.Black;
                        shuriken.Draw();
                        this.flyingShurs.Remove(shuriken);
                        Game.EnemyHealth--;
                        Game.UpdateEnemyHealth();
                        Game.Enemy.fireballThrowTimer.Interval -= 200;
                        if (Game.EnemyHealth<=0)
                        {
                            Game.Level++;
                        }
                    }
                    // else  if shuriken reaches the end of screen , remove it
                    else if (shuriken.col > 250)
                    {
                        shuriken.Color = ConsoleColor.Black;
                        shuriken.Draw();
                        this.flyingShurs.Remove(shuriken);
                    }

                    shuriken.Move(Directions.Right, 5);
                }


            }

        }
    }
}
