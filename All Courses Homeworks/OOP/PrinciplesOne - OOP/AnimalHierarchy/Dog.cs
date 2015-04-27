using System;
using System.Media;

namespace AnimalHierarchy
{
    class Dog : Animal
    {
        public Dog()
        {
        }

        public Dog(int age, string name, string sex)
            :base(age,name,sex)
        {

        }

        public override void ProduceSound()
        {
            SoundPlayer Sound = new SoundPlayer(@"../../Files/dog_bark6.wav");
            Sound.PlaySync();
        }

    }
}
