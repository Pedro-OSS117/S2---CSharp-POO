namespace Exo2
{
    public class Revue : Document
    {
        private int _month;
        private int _year;

        public Revue(int registerNumber, string title, int month, int year) : base(registerNumber, title)
        {
            _month = month;
            _year = year;
        }

        public override string ToString()
        {
            return  base.ToString() + $", Month : {_month}, Year : {_year}";
        }
    }
}