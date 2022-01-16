using System;

namespace LesPointeurs
{
    unsafe class Program
    {
        static void Main(string[] args)
        {
            /// ======== Pointeur et Types Valeur simples ========
            Console.WriteLine("======== Pointeur et Types Valeur simples ========");

            int v1 = 1532;

            int* p1 = &v1;
            int* p2 = &v1;

            *p2 = 5;
            
            // Affichage de la valeur de v1 via le pointeur
            Console.WriteLine($"{nameof(p1)} : {*p1}");

            // Affichage des adresses
            int v2 = 52;
            int v3 = 6552;

            int* pointerV2 = &v2;
            int* pointerV3 = &v3;

            Console.WriteLine($"Adresse de {nameof(v2)} : {(long)pointerV2}");
            Console.WriteLine($"Adresse de {nameof(v3)} : {(long)pointerV3}");

            pointerV3 += 1;
            Console.WriteLine($"Adresse de {nameof(v3)} : {(long)pointerV3}");
            Console.WriteLine($"Valeur pointée par {nameof(pointerV3)} : {*pointerV3}");

            /// ======== Pointeur et Types Valeur ========
            Console.WriteLine("\n======== Pointeur et Types Valeur ========");

            MyPoint point = new MyPoint();            
            Console.WriteLine($"{nameof(point)} : {point}");

            // Declaration d'un pointeur sur la variable point :
            MyPoint* pointerPoint = &point;
            Console.WriteLine($"Value {nameof(pointerPoint)} : {*pointerPoint}");

            point.x = 1;

            // Accès aux propriétés d'une structure via un pointeur
            pointerPoint->x = 12;
            pointerPoint->y = 42;
            Console.WriteLine($"Value {nameof(pointerPoint)} : {pointerPoint->y}");

            // Modification d'une variable dans une fonction via un pointeur
            int value = 11;
            int* pointerValue = &value;

            ModifyVariableByPointer(pointerValue);

            Console.WriteLine($"Value {nameof(value)} : {value}");

            MyPoint pointTest = new MyPoint();
            MyPoint* pointerPointTest = &pointTest;
            ModifyMyPointByPointer(pointerPointTest);

            Console.WriteLine($"Value {nameof(pointTest)} : {pointTest}");

            ModifyMyPoint(pointTest);
            Console.WriteLine($"Value {nameof(pointTest)} : {pointTest}");
        }

        static void ModifyVariableByPointer(int* pointerV)
        {
            *pointerV = 42;
        }

        static void ModifyMyPoint(MyPoint point)
        {
            point.x = 111; 
            point.y = 422; 
        }

        static void ModifyMyPointByPointer(MyPoint* pointerPoint)
        {
            pointerPoint->x = 11; 
            pointerPoint->y = 42; 
        }        

        struct MyPoint
        {
            public int x;
            public int y;

            public override string ToString()
            {
                return $"({x},{y})";
            }
        }
    }
}
