using System;
using System.Media;

namespace AnimalHierarchy
{
    class Tomcat : Cat
    {
        public Tomcat()
        {

        }

        public Tomcat(int age, string name)
            : base(age, name)
        {
            this.Sex = "Male";
        }

        public override void ProduceSound()
        {
            SoundPlayer Sound = new SoundPlayer(@"../../Files/cat_big_x.wav");
            Sound.PlaySync();
        }
    }
}
