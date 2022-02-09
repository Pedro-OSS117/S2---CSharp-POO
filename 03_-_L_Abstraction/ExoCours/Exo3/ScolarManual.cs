namespace Exo2
{
    public class ScolarManual : Livre
    {
        private int _level;

        public ScolarManual(int registerNumber, string title, string author, int numberPages, int level) : base(registerNumber, title, author, numberPages)
        {
            _level = level;
        }

        public override string ToString()
        {
            return  base.ToString() + $", Lvel : {_level}";
        }
    }
}