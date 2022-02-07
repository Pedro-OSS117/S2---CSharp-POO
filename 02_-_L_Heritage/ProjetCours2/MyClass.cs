using System;

namespace ProjetCours2
{
    public class MyClass
    {
        private int _myVarPrivate = 1;

        public int myVarPublic = 2;

        protected int _myVarProtected = 3; 

        private void MyMethodMyClassPrivate()
        {

        }

        public void MyMethodMyClassPublic()
        {

        }

        protected void MyMethodMyClassProtected()
        {

        } 


        public virtual void MyMethodMother()
        {
            Console.WriteLine("Coucou je suis la mother !");
        }

        public override bool Equals(object obj)
        {
            if(obj is MyClass varMyClass)
            {
                return this._myVarPrivate == varMyClass._myVarPrivate;
            }
            return false;
        }
    }
}