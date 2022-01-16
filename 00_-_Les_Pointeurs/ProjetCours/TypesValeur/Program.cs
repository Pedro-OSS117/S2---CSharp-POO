using System;

namespace TypesValeur
{
    class Program
    {
        struct MyPoint
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            // Types Simples 
            int value = 0;
            int valueSecond = value;
            valueSecond += 1;

            // Lorsqu'on modifie value2, value n'est pas modifiée
            // car il y a eu copie lors de l'assignation !
            Console.WriteLine($"{nameof(value)} : {value} ");
            Console.WriteLine($"{nameof(valueSecond)} : {valueSecond} ");

            MyMethod(value);
            
            Console.WriteLine($"{nameof(value)} : {value} ");

            // Type Valeur (pas simple) => Structure et Enumeration
            MyPoint point1 = new MyPoint();
            // Il y a copie de la valeur dans la nouvelle variable qui a son propre espace mémoire !!!!!
            MyPoint point2 = point1;

            int val = 1;

            point2.x += 1;
            Console.WriteLine($"{nameof(point1)} : {point1.x} ");
            Console.WriteLine($"{nameof(point2)} : {point2.x} ");

            int value = MyMethodToModifyStruct(point2);

            Console.WriteLine($"{nameof(point2)} : {point2.x} ");

            point2 = MyMethodToModifyStructWithReturn(point2);
            
            Console.WriteLine($"{nameof(point2)} : {point2.x} ");
        }

        static void MyMethod(int value)
        {
            value += 1;
        }

        static void MyMethodToModifyStruct(MyPoint point)
        {
            point.x += 10;
        }

        static MyPoint MyMethodToModifyStructWithReturn(MyPoint point)
        {
            point.x += 10;
            return point;
        }
    }
}