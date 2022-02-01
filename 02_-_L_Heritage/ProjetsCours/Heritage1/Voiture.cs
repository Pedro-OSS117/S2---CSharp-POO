using System;

namespace Heritage1
{
    public class Voiture : Vehicule
    {
        private int _nombrePorte;

        protected int _nombreRoueMotrice;

        private bool[] _etatPortes;

        public Voiture(string marque, float essence, int nombreDePorte) : base(marque, essence)
        {
            _nombrePorte = nombreDePorte;
            _nombreRoueMotrice = 2;
            _etatPortes = new bool[nombreDePorte];
        }

        public override void Move()
        {
            Console.WriteLine("Je suis une voiture et je bouge. Je fais Vroom Vroom");
        }

        public override string ToString()
        {
            string display = base.ToString();
            display += "Type : Voiture\n";
            display += "Nombre portes : "+ _nombrePorte;
            return display;
        }

        public void OuvertureDesPortes()
        {
            for(int i = 0; i < _etatPortes.Length; i++)
            {
                _etatPortes[i] = true;
            }
        }
    }
}