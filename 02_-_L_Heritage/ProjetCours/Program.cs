using System;

namespace ProjetCours
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass var = new MyClass();
            MyChildClass var1 = new MyChildClass();

            // Utilisation dans un tableau
            MyClass[] tabMyClass = new MyClass[]{var, var1};

            foreach(MyClass instance in tabMyClass)
            {
                Console.WriteLine(instance);
                instance.MyMethodPublic();

                if(instance is MyChildClass instanceMyChildClasse)
                {
                    instanceMyChildClasse.MyBMethod();
                }
            }
        }
    }
}
