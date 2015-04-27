using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;


namespace TelerikDefender
{
    public class Enemy : GameObject
    {
        public int ThrowInterval = 3000;        // initial throwing interval
        public int fireballSpeed = 70;          // initial fireball speed
        internal Timer fireballSpeedTimer;
        internal Timer fireballThrowTimer;
        public List<GameObject> fireballs = new List<GameObject>();
        private GameObject fireball;
        
        public Enemy(string fileName,int posX=1, int posY=1):base(fileName,posX, posY)
        {
            fireballThrowTimer = new Timer(ThrowInterval);
            fireballThrowTimer.Elapsed += new ElapsedEventHandler(FireballThrowElapsed);
            fireballThrowTimer.Start();
            fireballSpeedTimer = new Timer(fireballSpeed);
            fireballSpeedTimer.Elapsed += new ElapsedEventHandler(FireballSpeedElapsed);
            fireballSpeedTimer.Start();
        }

        void FireballSpeedElapsed(object sender, ElapsedEventArgs e)
        {
            foreach (var ball in fireballs)
            {
                if (Game.gameOver)
                {
                    StopThrowing();
                    break;
                }
                 
                //check if ball is in range for collision and if player is swiping
                if (ball.col < Game.Player.col + Game.Player.objectWidth && ball.col > 85 && Game.Player.isSwiping)
                {
                    //if in ball is in the path of the sword (the ball is hit)
                    if (ball.row > Game.Player.row && ball.row < Game.Player.row + 20)
                    {
                        ball.Color = ConsoleColor.Black;
                        ball.Draw();
                        fireballs.Remove(ball);
                        Game.Score += Game.fireballPoints;
                        Game.tempScore += Game.fireballPoints;
                        Sounds.SwordHit.Play();
                        this.fireballSpeedTimer.Interval -= 1;   // on each fireball destroyed increase the speed of the balls
                        
                        if (Game.tempScore==Game.starPoints)
                        {
                            Game.tempScore = 0;
                            if (Game.NinjaStars<5)
                            {
                                Game.NinjaStars++;
                                Game.UpdateNinjaStars();
                            }
                        }
                    }
                }
                //check for collision with building
                else if (ball.col<67)
                {
                    ball.Color = ConsoleColor.Black;
                    ball.Draw();
                    fireballs.Remove(ball);
                    Game.BuildingSrength--;
                    Game.UpdateBuildingStrength();
                    Sounds.BuildingCollision.Play();
                }
                ball.Move(Directions.Left, 2);
            }
        }
        public void StopThrowing()
        {
            this.fireballThrowTimer.Stop();
            this.fireballSpeedTimer.Stop();
            this.fireballs.Clear();
        }

        public void ThrowFiraballs()
        {
            fireball = new GameObject("fireball.txt", this.col - 30, this.row);
            fireball.Color = ConsoleColor.DarkYellow;
            fireball.Draw();
            fireballs.Add(fireball);
        }

        private void FireballThrowElapsed(object sender, ElapsedEventArgs e)
        {
            this.ThrowFiraballs();
            
        }
    }
}

