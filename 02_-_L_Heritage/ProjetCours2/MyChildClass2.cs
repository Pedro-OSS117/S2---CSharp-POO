using System;

namespace ProjetCours2
{
    public class MyChildClass2 : MyClass
    { 
        /*public override void MyMethodMother()
        {
            //Console.WriteLine("Coucou je suis la fille 2 !");
        }*/

        public void MyMethodSpecificFille2()
        {
            Console.WriteLine("Je suis le comportement specifique de la classe fill 2 !");
        }
    }
}