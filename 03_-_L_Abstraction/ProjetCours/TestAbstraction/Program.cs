using System;

namespace TestAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Impossible d'instancier A car la classe est abstraite
            //A a = new A();

            B b = new B();
            b.Method1();

            C c = new C();
            c.Method1();
        }
    }
}
