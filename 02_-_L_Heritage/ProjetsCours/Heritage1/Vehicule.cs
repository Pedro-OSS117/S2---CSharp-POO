using System;

namespace Heritage1
{
    public class Vehicule
    {
        private string _marque;

        private float _essenceMax;

        private float _essenceCourante;

        public Vehicule(float essenceMax)
        {
            _marque = "Shut, shut, pas de marque!";
            _essenceMax = essenceMax;
            _essenceCourante = 0;
        }

        public Vehicule(string marque, float essenceMax)
        {
            _marque = marque;
            _essenceMax = essenceMax;
            _essenceCourante = 0;
        }

        public virtual void Move()
        {
            Console.WriteLine("Je suis un vehicule et je roule, mais je ne suis qu'un concept");
        }

        public override string ToString()
        {
            string display = "Mon vehicule :\n";
            display += "Marque : " + _marque + "\n";
            display += "Essence : " + _essenceCourante + "/" + _essenceMax + "\n";
            return display;
        }
    }
}