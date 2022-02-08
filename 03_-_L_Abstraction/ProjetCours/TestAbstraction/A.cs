namespace TestAbstraction
{
    public abstract class A
    {
        private int value;

        public abstract void Method1();
        public abstract void Method2();

        protected virtual void MethodVirtual()
        {
            Method1Classic();
        }

        protected virtual void MethodVirtual2()
        {
            Method1Classic();
        }

        private void Method1Classic()
        {

        }
    }
}