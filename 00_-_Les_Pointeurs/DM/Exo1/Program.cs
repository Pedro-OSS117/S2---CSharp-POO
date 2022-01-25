using System;

namespace ExoCours
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            char c1 = 'O';
            char c2 = 'A';
            char* pC1 = &c1;
            char* pC2 = &c2;
            ModifyChar(pC1, pC2);
            Console.WriteLine($"{nameof(c1)} : {c1}");
            Console.WriteLine($"{nameof(c2)} : {c2}");
        }

        static unsafe void ModifyChar(char* from, char* to)
        {
            *to = *from;
        }
    }
}
