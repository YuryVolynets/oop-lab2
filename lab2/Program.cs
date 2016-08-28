using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Triangle t = new Triangle(r.Next(100), r.Next(100), r.Next(100));

            t.Print();
            Console.WriteLine("Существует ли такой треугольник: {0}", t.IsExist);
            if (t.IsExist)
            {
                Console.WriteLine("Периметр: {0}", t.Perimeter());
                Console.WriteLine("Площадь: {0}", t.Area());
            }

            Console.WriteLine("\nt++");
            t++.Print();

            Console.WriteLine("\nt--");
            t--.Print();

            Console.WriteLine("\nbool");
            Console.WriteLine(t ? true : false);

            Console.WriteLine("\nt*2");
            (t * 2).Print();

            Console.WriteLine("\nt to string");
            Console.WriteLine(t);

            Console.WriteLine("\n\"1,2,3\" to Triangle");
            ((Triangle)"1,2,3").Print();
        }
    }
}