using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Animal : ISound
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }

        public Animal()
        {
        }

        public Animal(int age, string name, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public Animal(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public virtual void ProduceSound()
        {
            throw new NotImplementedException("This method is not implemented for the current object");
        }

        public static void CalculateAge(IEnumerable<Animal> animals)
        {
            Console.Write("You can check average age on animal types : Cats , Dogs, Frogs, Kittens, TomcatsType Cats/Dogs/Frogs/Kittens or Tomcats : ");
            string input = Console.ReadLine().ToLower();
            CalculateAverageAge(input, animals);
        }

        private static void CalculateAverageAge(string animalType, IEnumerable<Animal> animalCollection)
        {
            double averageAgeSum = 0;
            switch (animalType)
            {
                case "cats":
                    averageAgeSum = SelectCurrentTypeAndCalculateAverageAge("AnimalHierarchy.Cat", animalCollection);
                    break;
                case "dogs":
                    averageAgeSum = SelectCurrentTypeAndCalculateAverageAge("AnimalHierarchy.Dog", animalCollection);
                    break;
                case "frogs":
                    averageAgeSum = SelectCurrentTypeAndCalculateAverageAge("AnimalHierarchy.Frog", animalCollection);
                    break;
                case "kittens":
                    averageAgeSum = SelectCurrentTypeAndCalculateAverageAge("AnimalHierarchy.Kitten", animalCollection);
                    break;
                case "tomcats":
                    averageAgeSum = SelectCurrentTypeAndCalculateAverageAge("AnimalHierarchy.Tomcat", animalCollection);
                    break;
                default:
                    throw new ArgumentException("Invalid animal group !");
            }
            Console.WriteLine("Average age of {0} in the collection is : {1}",animalType, averageAgeSum);
        }

        private static double SelectCurrentTypeAndCalculateAverageAge(string type, IEnumerable<Animal> animalCollection)
        {
            double averageAgeSum = 0d;
            var onlyCurrentAnimal =
             from animals in animalCollection
             where animals.GetType().ToString() == type
             select animals;
            foreach (var animal in onlyCurrentAnimal)
            {
                averageAgeSum += animal.Age;
            }
            averageAgeSum /= 2;
            return averageAgeSum;
        }

    }
}
