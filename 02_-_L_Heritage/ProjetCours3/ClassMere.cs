namespace ProjetCours3
{
    public abstract class ClassMere
    {
        private int _myPropsPrivate;

        public int _myPropsPublic;

        protected int _myPropsProtected;

        private int MyMethodPrivate()
        {
            MyMethodPrivate();
        }
        
        public int MyMethodPublic()
        {
            this._myPropsPrivate = 1;
            MyMethodPrivate();
        }
        
        protected int MyMethodProtected()
        {
            this._myPropsPrivate = 4;
        }
    }
}