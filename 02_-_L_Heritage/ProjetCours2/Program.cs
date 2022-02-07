using System;

namespace ProjetCours2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass varMyClass = new MyClass();
            varMyClass.MyMethodMyClassPublic();
            varMyClass.MyMethodMother();

            MyChildClass varMyChildClass = new MyChildClass();
            varMyChildClass.MyMethodMyClassPublic();
            varMyChildClass.MyMethodMother();

            MyClass[] varTab = new MyClass[] { varMyClass, varMyChildClass};
            foreach(MyClass var in varTab)
            {
                var.MyMethodMother();
            }
        }
    }
}
