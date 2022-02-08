using System;

namespace TestAbstraction
{
    public class C : A
    {
        public override void Method1()
        {
            Console.WriteLine("Method1 C");
        }

        public override void Method2()
        {
            Console.WriteLine("Method2 C");
        }
    }
}