using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    public static class PracticeClass
    {
        struct RectangleTest
        {
            public double length;
            public double width;

            public RectangleTest(double l, double w)
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

            RectangleTest rect1;
            rect1.length = 100;
            rect1.width = 30;

            Console.WriteLine("rectangle length:{0}, width:{1}", rect1.length, rect1.width);

            RectangleTest rect2 = new RectangleTest(200, 50);
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

        public static void practice2()
        {
            string str = "Kunsan University";
            //            0123456789
            Console.WriteLine(str.Substring(str.IndexOf("University")));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i).Append(" ");
            }

            Console.WriteLine(sb.ToString());

            StringBuilder sb2 = new StringBuilder();
            sb2.Append("The list starts here:");
            sb2.AppendLine();
            sb2.Append("1 cat").AppendLine();

            string str2 = sb2.ToString();
            Console.WriteLine(str2);

            // example 3
            StringBuilder sb3 = new StringBuilder(
                "Korea University");
            sb3.Replace("Korea", "Kunsan");
            Console.WriteLine(sb3.ToString());

            // example 4
            string[] items = { "Cat", "Dog", "Fox", "Pig" };

            StringBuilder sb4 = new StringBuilder(
                "These animals are required:").AppendLine();

            foreach(string item in items)
            {
                sb4.Append(item).AppendLine();
            }

            Console.WriteLine(sb4.ToString());

            //example 5
            StringBuilder sb5 = new StringBuilder("Kunsan is University");
            sb5.Remove(6, 3);
            Console.WriteLine(sb5.ToString());

            // example 6
            StringBuilder sb6 = new StringBuilder();
            sb6.Append("Kunsan University.");

            TrimEnd(sb6, '.');
            Console.WriteLine(sb6.ToString());
        }

        private static void TrimEnd(StringBuilder sb, char letter)
        {
            if (sb.Length == 0) return;

            if (sb[sb.Length - 1] == letter)
            {
                sb.Length -= 1;
            }
        }

        public static void practice3()
        {
            // Create an array containing the area of some squares.
            Tuple<string, double>[] areas =
                    {   Tuple.Create("Sitka, Alaska", 2870.3),
                        Tuple.Create("New York City", 302.6),
                        Tuple.Create("Los Angeles", 468.7),
                        Tuple.Create("Detroit", 138.8),
                        Tuple.Create("Chicago", 227.1),
                        Tuple.Create("San Diego", 325.2) };

            Console.WriteLine("{0,-18} {1,14:N1} {2,30}\n", "City", "Area (mi.)",
                              "Equivalent to a square with:");

            foreach (var area in areas)
                Console.WriteLine("{0,-18} {1,14:N1} {2,14:N2} miles per side",
                                  area.Item1, area.Item2, Math.Round(Math.Sqrt(area.Item2), 2));
        }

        public static void practice4()
        {
            Console.Write("Enter your ID : ");
            string strID = Console.ReadLine();
            Console.Write("Enter your Password : ");
            string strPassword = Console.ReadLine();

            Console.WriteLine("ID : {0}, Password : {1}", strID, strPassword);
        }

        public static void practice12()
        {
            // A : 3, 4, 5
            // B : 3, 3, 3

            //Triangle triA = new Triangle(3, 4, 5);

            List<TriangleTest> triangles = new List<TriangleTest>();
            triangles.Add(new TriangleTest(3, 4, 5));
            triangles.Add(new TriangleTest(3, 3, 3));
            triangles.Add(new TriangleTest(5, 4, 3));

            int index = 1;
            foreach(TriangleTest shape in triangles)
            {
                shape.Draw(index);
                index++;
            }

            /*
            index = 1;
            for (int i = 0; i < triangles.Count; i++)
            {
                Triangle shape = triangles[i];
                shape.Draw(index);
                index++;
            }
            */

            // Output
            // 삼각형1: A-3, B-4, C-5
            // 둘레길이: 12
            // 삼각형2: A-3, B-3, C-3
            // 둘레길이: 9
        }

        public static void practice13_1()
        {
            int a = 20, b = 10;
            Calculator cal = new Calculator();
            Console.WriteLine("a={0}, b={1}", a, b);
            Console.WriteLine("사칙연산 결과: {0},{1},{2},{3}",
                cal.Add(a, b),
                cal.Substract(a, b),
                cal.Multiply(a, b),
                cal.Divide(a, b));

            Console.WriteLine();

            double x = 20.5, y = 10.5;
            Console.WriteLine("x={0}, y={1}", x, y);
            Console.WriteLine("사칙연산 결과: {0},{1},{2},{3}",
                cal.Add(x, y),
                cal.Substract(x, y),
                cal.Multiply(x, y),
                cal.Divide(x, y));
        }

        public static void practice13_2()
        {
            Calculator2<int> calInt = new Calculator2<int>();
            int a = 20, b = 10;
            Console.WriteLine("a={0}, b={1}", a, b);
            Console.WriteLine("사칙연산 결과: {0},{1},{2},{3}",
                calInt.Add(a, b),
                calInt.Substract(a, b),
                calInt.Multiply(a, b),
                calInt.Divide(a, b));

            Console.WriteLine();

            Calculator2<double> caldouble = new Calculator2<double>();
            double x = 20.5, y = 10.5;
            Console.WriteLine("x={0}, y={1}", x, y);
            Console.WriteLine("사칙연산 결과: {0},{1},{2},{3}",
                caldouble.Add(x, y),
                caldouble.Substract(x, y),
                caldouble.Multiply(x, y),
                caldouble.Divide(x, y));
        }

        public static void practice14()
        {
            // Output
            //시작시 속도: 1
            //엑셀 1단계 속도: 11
            //엑셀 2단계 속도: 31
            //정지후 속도: 0

            Car myCar = new Car("MadMax");
            myCar.Start();
            Console.WriteLine("시작시 속도:{0}", myCar.Speed);
            myCar.Accelerate();
            Console.WriteLine("엑셀1단계 속도:{0}", myCar.Speed);
            myCar.Accelerate(20);
            Console.WriteLine("엑셀2단계 속도:{0}", myCar.Speed);
            myCar.Stop();
            Console.WriteLine("정지후 속도:{0}", myCar.Speed);
        }

        public static void practice15()
        {
            MyPaint paint = new MyPaint();

            Triangle t = new Triangle(3, 4, 5);
            paint.DrawShape(t);
            Console.WriteLine();

            Rectangle r = new Rectangle(5, 10);
            paint.DrawShape(r);
            Console.WriteLine();

            CustomShape cs = new CustomShape(5, 10, 2, 2);
            paint.DrawShape(cs);

            // Output
            //Draw Triangle(3,4,5)
            //Draw Triangle(3,4,5)
            //Draw Rectangle(5,10)
            //
            //Draw Triangle(3,4,5)
            //Draw Rectangle(5,10)
            //Draw CustomShape(5,10,2,2)
        }

        public interface IDrawble
        {
            void Draw();
        }

        public class MyPaint
        {
            List<IDrawble> shapes = new List<IDrawble>();

            public MyPaint() { }

            public void DrawShape(IDrawble shape)
            {
                shapes.Add(shape);

                foreach(IDrawble obj in shapes)
                {
                    obj.Draw();
                }
            }
        }

        public class Triangle : IDrawble
        {
            private int v1;
            private int v2;
            private int v3;

            public Triangle(int v1, int v2, int v3)
            {
                this.v1 = v1;
                this.v2 = v2;
                this.v3 = v3;
            }

            public void Draw()
            {
                Console.WriteLine($"Draw Triangle({v1},{v2},{v3})");
            }
        }

        public class Rectangle : IDrawble
        {
            private int v1;
            private int v2;

            public Rectangle(int v1, int v2)
            {
                this.v1 = v1;
                this.v2 = v2;
            }

            public void Draw()
            {
                Console.WriteLine($"Draw Rectangle({v1},{v2})");
            }
        }

        public class CustomShape : IDrawble
        {
            private int v1;
            private int v2;
            private int v3;
            private int v4;

            public CustomShape(int v1, int v2, int v3, int v4)
            {
                this.v1 = v1;
                this.v2 = v2;
                this.v3 = v3;
                this.v4 = v4;
            }

            public void Draw()
            {
                Console.WriteLine($"Draw CustomShape({v1},{v2},{v3},{v4})");
            }
        }

        class Car
        {
            private int speed;

            public string Name { get; set; }
            public string Maker { get; set; }
            public string Model { get; set; }

            public int Speed { get { return this.speed; } }

            public Car(string name)
            {
                Name = name;
            }

            public void Start()
            {
                speed = 1;
            }

            public void Stop()
            {
                speed = 0;
            }

            public void Accelerate(int value = 10)
            {
                speed += value;
            }

            public void Break()
            {
                speed -= 10;
                speed = (speed > 0) ? speed : 0;
            }
        }

        class Calculator2<T>
        {
            public T Add(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;

                dynamic sum = da + db;
                return sum;
            }

            public T Substract(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;

                return da - db;
            }

            public T Multiply(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;

                return da * db;
            }

            public T Divide(T a, T b)
            {
                dynamic da = a;
                dynamic db = b;

                return da / db;
            }
        }

        class Calculator
        {
            public Calculator() { }

            public int Add(int a, int b){ return a + b; }
            public int Substract(int a, int b){ return a - b; }
            public int Multiply(int a, int b){ return a * b; }
            public double Divide(int a, int b)
            {
                if (b == 0)
                {
                    Console.WriteLine("0으로 못나눠요!~");
                    return 0;
                }

                return a * 1.0 / b;
            }

            public double Add(double a, double b) { return a + b; }
            public double Substract(double a, double b) { return a - b; }
            public double Multiply(double a, double b) { return a * b; }
            public double Divide(double a, double b)
            {
                if (b == 0)
                {
                    Console.WriteLine("0으로 못나눠요!~");
                    return 0;
                }

                return a / b;
            }
        }

        class TriangleTest
        {
            private int A, B, C;

            public TriangleTest(int a, int b, int c)
            {
                A = a;
                B = b;
                C = c;
            }

            public void Draw(int index)
            {
                int sum = A + B + C;
                Console.WriteLine("삼각형{0} : A-{1}, B-{2}, C={3}", index, A, B, C);
                Console.WriteLine("둘레길이:{0}", sum);
            }
        }


    }
}
