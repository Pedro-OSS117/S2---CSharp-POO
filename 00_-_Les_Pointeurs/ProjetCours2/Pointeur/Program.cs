using System;

namespace Pointeur
{
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
        static unsafe void Main(string[] args)
        {
            int a = 1;
            // Je mets l'adresse 1 dans le pointeur
            //int* p1 = (int*)a;

            // Je mets l'adresse de a dans le pointeur
            int* p1 = &a;
            //Console.WriteLine(p1);
            Console.WriteLine((long)p1);
            Console.WriteLine(*p1);

            // J'incrémente l'adresse du pointeur de 4 octets car 
            // c'est un pointeur de type int
            p1++;
            Console.WriteLine((long)p1);
            Console.WriteLine(*p1);
            
            // Je tente de traffiquer l'adresse
            long adresseTrafiked = (long)p1;
            adresseTrafiked++;
            p1 = (int*)adresseTrafiked;

            Console.WriteLine((long)p1);
            Console.WriteLine(*p1);

            // Pointeur sur des longs
            long l = 10;
            long lSecondo = l;
            long* pointeurLong = &l;
            long* pointeurLong2 = &l;
            long* pointeurLonglSecondo = &lSecondo;

            Console.WriteLine($"{nameof(pointeurLong)} : {(long)pointeurLong}");
            Console.WriteLine($"{nameof(pointeurLong)} : {*pointeurLong}");
            Console.WriteLine($"{nameof(pointeurLonglSecondo)} : {(long)pointeurLonglSecondo}");

            pointeurLong--;
            Console.WriteLine((long)pointeurLong);
            Console.WriteLine(*pointeurLong);

            *pointeurLong += 2;
            *pointeurLong2 += 5;

            Console.WriteLine(l);
            Console.WriteLine(lSecondo);

            adresseTrafiked = (long)pointeurLonglSecondo;
            adresseTrafiked++;
            pointeurLonglSecondo = (long*)adresseTrafiked;
            
            *pointeurLonglSecondo += 150000000;

            Console.WriteLine(l);
            Console.WriteLine(lSecondo);

            // Pointeur sur structure
            Point point = new Point();
            Point* pointeur = &point;
            pointeur->x = 5;
            Console.WriteLine(*pointeur);
            ModifyPoint(pointeur, 5, 16);
            Console.WriteLine(*pointeur);

            // Pointeur sur tableau
            long[] tabVar = new long[] {15, 5, 6, 8};
            tabVar[2] = 9;

            fixed(long* myPointeurTab = &tabVar[0])
            {
                Console.WriteLine(*myPointeurTab);

                long newAdress = (long)myPointeurTab;
                newAdress += 24;
                long* pointeur2 = (long*)newAdress;
                Console.WriteLine((long)myPointeurTab);
                Console.WriteLine((long)pointeur2);
                Console.WriteLine(*pointeur2);
            }
        }

        private unsafe static void ModifyPoint(Point* pointeur, int newX, int newY)
        {
            pointeur->x = newX;
            pointeur->y = newY;
            Console.WriteLine(*pointeur);
        }

        private unsafe static void ModifyInt(int* pointeur, int newX)
        {
            *pointeur = newX;
        }
    }
}
