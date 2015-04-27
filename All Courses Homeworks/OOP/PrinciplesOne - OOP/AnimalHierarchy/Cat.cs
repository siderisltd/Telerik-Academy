using System;
using System.Media;

namespace AnimalHierarchy
{
    class Cat : Animal
    {
        public Cat()
        {
        }

        public Cat(int age, string name, string sex)
            : base(age, name, sex)
        {

        }

        public Cat(int age, string name)
            : base(age, name)
        {

        }

        public override void ProduceSound()
        {
            SoundPlayer Sound = new SoundPlayer(@"../../Files/cat_meow_x.wav");
            Sound.PlaySync();
        }

    }
}
