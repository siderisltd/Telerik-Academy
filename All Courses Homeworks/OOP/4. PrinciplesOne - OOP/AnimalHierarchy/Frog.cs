using System;
using System.Media;

namespace AnimalHierarchy
{
    class Frog : Animal
    {
        public Frog()
        {
        }

        public Frog(int age, string name, string sex)
            : base(age, name, sex)
        {

        }

        public override void ProduceSound()
        {
            SoundPlayer Sound = new SoundPlayer(@"../../Files/frog-ribbet4.wav");
            Sound.PlaySync();
        }

    }
}
