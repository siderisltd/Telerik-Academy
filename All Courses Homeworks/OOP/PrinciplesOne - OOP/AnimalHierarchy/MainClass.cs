using System;
using System.Collections;
using System.Collections.Generic;

namespace AnimalHierarchy
{
    class MainClass
    {
        static void Main()
        {
            List<Animal> listOfAnimals = new List<Animal>();
            listOfAnimals.Add(new Dog(5, "Sharo", "Male"));
            listOfAnimals.Add(new Frog(3, "Jaburana", "Female"));
            listOfAnimals.Add(new Cat(4, "Pisana", "Female"));
            listOfAnimals.Add(new Kitten(1, "Kotence"));
            listOfAnimals.Add(new Tomcat(4, "Tom"));

            Animal[] animals = new Animal[6];
            animals[0] = (new Dog(5, "Jess", "Female"));
            animals[1] = (new Frog(3, "Jabur", "Male"));
            animals[2] = (new Cat(4, "Kotaranka", "Female"));
            animals[3] = (new Kitten(1, "BebeKote"));
            animals[4] = (new Tomcat(4, "Tommy"));
            animals[5] = (new Cat(5, "Kotangens", "Male"));

            //this will execute base calculation static method aplicable for each type of animal
            Animal.CalculateAge(animals);

            Dog someDog = new Dog();
            //this will play real sound
            someDog.ProduceSound();
        }
    }
}
