using System;

namespace Exo2
{
    public class CompteSurCarnet : AbstractCompte
    {
        private int _numeroCarnet;
        
        private int _plafond = 10000;
        
        public CompteSurCarnet(string nom, float solde, int numeroCarnet) : base(nom, solde)
        {
            _numeroCarnet = numeroCarnet;
        }

        public override void Debiter(float montant)
        {
            base.Debiter(montant);

            if(_plafond < montant)
            {
                Console.WriteLine("Plafond depassé!");
                return;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nNumero Carnet : {_numeroCarnet}\nPlafond : {_plafond}";
        }
    }
}