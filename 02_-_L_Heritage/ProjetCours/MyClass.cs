using System;

namespace ProjetCours
{
    public class MyClass
    {
        public int id = 0;

        private int myPropsAPrivate;
        protected int myPropsAProtected;

        private void MyMethodA()
        {
            myPropsAPrivate = 1;
        }

        public virtual void MyMethodPublic()
        {
            Console.WriteLine("Call MyMethodPublic in MyClass");
        }

        protected virtual void MyMethodProtected()
        {
            Console.WriteLine("Call MyMethodProtected in MyClass");
        }

        public override string ToString()
        {
            return "Override de la fonction ToString pour la classe MyClass id : " + id + " - " + myPropsAPrivate;
        }

        public override bool Equals(object obj)
        {
            // "Override de la fonction Equals pour la classe MyClass"
            MyClass myClassVar = obj as MyClass;
            if (myClassVar == null)
            {
                return false;
            }
            // Les instances sont egales si leur id sont egaux.
            return id == myClassVar.id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}