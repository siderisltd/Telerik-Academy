using System;

using System.Media;
namespace TelerikDefender
{
    class Sounds
    {
        public static SoundPlayer MainTheme = new SoundPlayer(Environment.CurrentDirectory + "\\" + "Assets" + "\\" + "Sounds" + "\\" + "Pacman_Introduction_Music-KP-826387403.wav");
        public static SoundPlayer GameOverSound = new SoundPlayer(Environment.CurrentDirectory + "\\" + "Assets" + "\\" + "Sounds" + "\\" + "gameOver.wav");
        public static SoundPlayer LevelUpSound = new SoundPlayer(Environment.CurrentDirectory + "\\" + "Assets" + "\\" + "Sounds" + "\\" + "levelUp.wav");
        public static SoundPlayer GameWinSound = new SoundPlayer(Environment.CurrentDirectory + "\\" + "Assets" + "\\" + "Sounds" + "\\" + "Win.wav");
        public static SoundPlayer SwordSwipe = new SoundPlayer();
        public static SoundPlayer BuildingCollision = new SoundPlayer();
        public static SoundPlayer EnemyHit = new SoundPlayer();
        public static SoundPlayer SwordHit = new SoundPlayer();
    }
}
