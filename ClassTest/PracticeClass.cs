using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    public static class PracticeClass
    {
        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
        }

        public static void practice1()
        {
            Console.WriteLine("Struct");
            Console.WriteLine("=======================");

            Rectangle rect1;
            rect1.length = 100;
            rect1.width = 30;

            Console.WriteLine("rectangle length:{0}, width:{1}", rect1.length, rect1.width);

            Rectangle rect2 = new Rectangle(200, 50);
            Console.WriteLine("rectangle length:{0}, width:{1}, area:{2}",
                rect1.length, rect1.width, rect1.Area());

            Console.WriteLine(String.Empty);
            Console.WriteLine("Class Animal");
            Console.WriteLine("=======================");

            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("fox", "Raaww"));
            animals.Add(new Animal("dog", "Walwal"));
            animals.Add(new Animal("cat", "nyaong"));

            for (int i = 0; i < animals.Count; i++)
            {
                Animal thisAnimal = animals[i];
            }

            bool bFound = false;
            foreach (var animal in animals)
            {
                var animalName = animal.GetName();
                if (animalName == "pig")
                {
                    bFound = true;
                    break;
                }
            }

            if (bFound)
            {
                Console.WriteLine("pig found");
            }
            else
            {
                Console.WriteLine("pig not found");
            }

            Animal myPig = null;
            myPig = animals.Find(item => item.GetName().Equals("pig"));
            if (myPig != null)
            {
                Console.WriteLine("pig found");
                myPig.MakeSound();
            }
            else
            {
                Console.WriteLine("pig not found");
            }

            Dictionary<enAnimalType, Animal> dicAnimals
                = new Dictionary<enAnimalType, Animal>();

            dicAnimals.Add(enAnimalType.fox, new Animal("red", "Raaww"));
            dicAnimals.Add(enAnimalType.dog, new Animal("blue", "walwal"));
            dicAnimals.Add(enAnimalType.cat, new Animal("pink", "nyaong"));

            var someAnimal = dicAnimals[enAnimalType.cat];

            foreach (KeyValuePair<enAnimalType, Animal> item in dicAnimals)
            {
                var key = item.Key;
                var value = item.Value;

                value.MakeSound();
            }

            foreach (var item in dicAnimals.Values)
            {
                item.MakeSound();
            }

            Animal outAnimal;
            if (dicAnimals.TryGetValue(enAnimalType.pig, out outAnimal))
            {
                outAnimal.MakeSound();
            }
            else
            {
                Console.WriteLine("[E] pig not found");
            }

            Console.WriteLine("numOfAnimals : {0}", Animal.GetNumOfAnimals());
            Console.WriteLine(String.Empty);
            Console.WriteLine("ShapeMath");
            Console.WriteLine("=======================");

            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea(enShape.Rectangle, 5, 6));
            Console.WriteLine("Area of Triangle : {0}", ShapeMath.GetArea(enShape.Triangle, 5, 6));
            Console.WriteLine("Area of Circle : {0}", ShapeMath.GetArea(enShape.Circle, 5));
        }
    }
}
