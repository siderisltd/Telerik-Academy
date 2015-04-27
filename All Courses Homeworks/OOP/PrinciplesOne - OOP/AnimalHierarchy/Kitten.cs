using System;
using System.Media;

namespace AnimalHierarchy
{
    class Kitten : Cat
    {
        public Kitten()
        {

        }

        public Kitten(int age, string name)
            : base(age,name)
        {
            this.Sex = "Female";
        }

        public override void ProduceSound()
        {
            SoundPlayer Sound = new SoundPlayer(@"../../Files/cat_kitten.wav");
            Sound.PlaySync();
        }
    }
}
