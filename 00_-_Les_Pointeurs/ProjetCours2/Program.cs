using System;

namespace ProjetCours2
{
    enum MyEnum
    {
        MaValeur1,
        MaValeur2,
        MaValeur3,
    }

    struct Point
    {
        public int x;
        public int y;

        // Surcharge de To String
        public override string ToString()
        {
            return $"({x},{y})";
        }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            // LES TYPES VALEURS

            // Les types bases
            int maVarEntiere = 4;
            int maVarEntiere2 = maVarEntiere;
            maVarEntiere++;
            
            Console.WriteLine($"Valeur {nameof(maVarEntiere)} : {maVarEntiere}"); 
            MyFunctionInt(maVarEntiere);
            Console.WriteLine($"Valeur {nameof(maVarEntiere)} : {maVarEntiere}"); 
            Console.WriteLine($"Valeur {nameof(maVarEntiere2)} : {maVarEntiere2}");

            // Les Enumerations
            MyEnum maVarEnum;
            maVarEnum = MyEnum.MaValeur1;

            MyEnum maVarEnum2 = maVarEnum;
            //maVarEnum += 2;
            maVarEnum = MyEnum.MaValeur3;

            Console.WriteLine($"Valeur Enum {nameof(maVarEnum)} : {maVarEnum}"); 
            MyFunctionEnum(maVarEnum);
            Console.WriteLine($"Valeur Enum {nameof(maVarEnum)} : {maVarEnum}"); 
            Console.WriteLine($"Valeur Enum {nameof(maVarEnum2)} : {maVarEnum2}");

            ConsoleKey key = ConsoleKey.Backspace;
            ConsoleKey key2 = key;
            key++;
            ConsoleKey key3 = key;
            key3++;
            Console.WriteLine($"Valeur Enum {nameof(key)} : {key}"); 
            Console.WriteLine($"Valeur Enum {nameof(key2)} : {key2}");
            Console.WriteLine($"Valeur Enum {nameof(key3)} : {key3}");

            // Les structures
            Point p = new Point();
            p.x = 1;
            Point p2 = p;
            p2.y = 2;

            Console.WriteLine($"Valeur Point {nameof(p)} : {p}"); 

            Console.WriteLine($"Valeur Point {nameof(p2)} : {p2}");
            MyFunctionStruc(p2);
            Console.WriteLine($"Valeur Point {nameof(p2)} : {p2}");
        }

        private static void MyFunctionInt(int val)
        {
            val++;
        }
        
        private static void MyFunctionEnum(MyEnum val)
        {
            val++;
        }

        private static void MyFunctionStruc(Point point)
        {
            point.x++;
            point.y++;
            Console.WriteLine($"Valeur Point {nameof(point)} : {point}"); 
        }
    }
}
