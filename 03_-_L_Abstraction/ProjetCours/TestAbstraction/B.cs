using System;

namespace TestAbstraction
{
    public class B : A
    {
        public override void Method1()
        {
            Console.WriteLine("Method1 B");
        }

        public override void Method2()
        {
            Console.WriteLine("Method2 B");
        }
    }
}