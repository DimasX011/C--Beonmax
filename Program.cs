using System;
using System.Collections.Generic;

namespace D__OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            object obj = x;

            int y = (int)obj;

            double pi = 3.14;
            object obj1 = pi;

            int number = (int)(double)obj1;
            Console.WriteLine(number);
           
        }
        static void Do(object obj)
        {
            bool isPointRef = obj is PointRef;
            if (isPointRef)
            {
                PointRef pr = (PointRef)obj;
                Console.WriteLine(pr.X);
            }
            else
            {
                //do smth
            }

            PointRef pr1 = obj as PointRef;
            if (pr1 != null)
            {
                Console.WriteLine(pr1.X);
            }
            else
            {
                //
            }
        }

        static void NRE_NullableValTypesDemo()
        {
            PointVal? pv = null;
            if (pv.HasValue)
            {
                PointVal pv2 = pv.Value;
                Console.WriteLine(pv.Value.X);
                Console.WriteLine(pv2.X);
            }

            else
            {
                //
            }

            PointVal pv3 = pv.GetValueOrDefault();
            Console.WriteLine(pv.Value);

            PointRef C = null;
            Console.WriteLine(C.X); //NullReferenceException

        }
        static void PassByteDemo()
        {
            int a = 1;
            int b = 2;

            Swap(ref a, ref b);

            Console.WriteLine($"a={a}, b={b}");


            Console.ReadLine();

            var List = new List<int>();
            AddNumbers(List);

            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
        }
        static void Swap(ref int a, ref int b)
        {
            Console.WriteLine($"Original a={a}, b={b}");

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine($"Swapped a={a}, b={b}");
        }


        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }
        static void StructAndMetods()
        {
            EvilStruct es1 = new EvilStruct();
            es1.PointRef = new PointRef() { X = 1, Y = 2 };
            //es1.PointRef.X = 1;
            // es1.PointRef.Y = 2;
            EvilStruct es2 = es1;

            Console.WriteLine($"es1.PointRef.X = {es1.PointRef.X}, es1.Point.Ref.Y = {es1.PointRef.Y}");
            Console.WriteLine($"es2.PointRef.X = {es2.PointRef.X}, es2.Point.Ref.Y = {es2.PointRef.Y}");

            es2.PointRef.X = 42;
            es2.PointRef.Y = 45;

            Console.WriteLine($"es1.PointRef.X = {es1.PointRef.X}, es1.Point.Ref.Y = {es1.PointRef.Y}");
            Console.WriteLine($"es2.PointRef.X = {es2.PointRef.X}, es2.Point.Ref.Y = {es2.PointRef.Y}");

            Console.ReadLine();

            PointVal a; // same as PointVal a = new PointVal();

            a.X = 3;
            a.Y = 5;

            PointVal b = a;
            b.X = 7;
            b.Y = 10;

            a.LogValues();
            b.LogValues();

            Console.WriteLine("After structs");

            PointRef c = new PointRef();

            c.X = 3;
            c.Y = 5;

            PointRef d = c;
            d.X = 7;
            d.Y = 10;

            a.LogValues();
            b.LogValues();

        }
        static void NeCalculator()
        {/*
            Calculator calc = new Calculator();
            if (calc.TryDivide(10, 2, out double result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Failed to divide");
            }
            Console.ReadLine();


            Console.WriteLine("Enter a number, please.");

            string line = Console.ReadLine();


            bool wasParsed = int.TryParse(line, out int number);
            if (wasParsed)
            {
                Console.WriteLine(number);
            }

            else
            {
                Console.WriteLine("Failed to Parse");
            }


            Console.WriteLine(number);
            */
        }
    }
}
