namespace Exo2
{
    public abstract class Livre : Document
    {
        private string _author;

        public string Author { get { return _author; } }

        private int _numberPages;

        public Livre(int registerNumber, string title, string author, int numberPages) : base(registerNumber, title)
        {
            _author = author;
            _numberPages = numberPages;
        }

        public override string ToString()
        {
            return base.ToString() + $", Author : {_author}, Number Pages : {_numberPages}";
        }
    }
}