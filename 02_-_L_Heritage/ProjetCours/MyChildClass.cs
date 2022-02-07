using System;

namespace ProjetCours
{
    public class MyChildClass : MyClass
    {
        public void MyBMethod()
        {
            // Pas d'accès à myPropsAPrivate car private.
            // myPropsAPrivate = 10; // ERROR
            // Mais accès à la prop myPropsAProtected car protected
            myPropsAProtected = 10;
            
            Console.WriteLine("Call MyBMethod in MyChildClass myPropsAProtected : " + myPropsAProtected);
        }

        public override void MyMethodPublic()
        {
            Console.WriteLine("Call MyMethodPublic in MyChildClass");
        }

        protected override void MyMethodProtected()
        {
            Console.WriteLine("Call MyMethodProtected in MyChildClass");
        }
        
        public override string ToString()
        {
            return "Override de la fonction ToString pour la classe MyChildClass id : " + id;
        }
    }
}