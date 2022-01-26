using System;

namespace Exo2
{
    public class Adherent
    {
        private static double defaultContribution = 10;

        public static double DefaultContribution
        {
            get { return defaultContribution; }
        } 

        public static bool IsValidContribution(double testedValue)        
        {
            return testedValue >= defaultContribution;
        }

        private int _num;
        private string _name;
        private double _contribution;

        public string Name
        {
            get { return _name; }
            private set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    value = "Anonyme";
                }
                _name = value;
            }
        }

        public Adherent()
        {
            _num = 0;
            Name = "";
            _contribution = Adherent.defaultContribution;
        }

        public Adherent(string name)
        {
            Random rand = new Random();
            _num = rand.Next();

            Name = name;
        }

        public void Modify(double contribution)
        {
            if(contribution < defaultContribution)
            {
                contribution = defaultContribution;
            }
            _contribution = contribution;
        }

        public override string ToString()
        {
            return $"Numero de l'adherent : {_num}, Nom de l'adherent : {_name}, Cotisation : {_contribution}.";
        }
    }
}