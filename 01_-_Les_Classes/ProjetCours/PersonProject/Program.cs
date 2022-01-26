using System;
using MyNamespace;

namespace PersonPoject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(15);
            // Utilisation de l'accesseur get
            int ageRoggger = p.Age;

            // utilisation du setter set
            p.Age = -10;

            Console.WriteLine(p);

            p.Name = "";            
            Console.WriteLine(p);

            p.Name = "Bob";
            Console.WriteLine(p);
        }
    }
}
