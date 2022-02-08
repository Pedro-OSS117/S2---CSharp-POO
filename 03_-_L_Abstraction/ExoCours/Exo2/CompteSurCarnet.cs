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

        public override void Crediter(float montant)
        {
            _solde += montant;
        }

        public override void Debiter(float montant)
        {
            if(_plafond < montant)
            {
                Console.WriteLine("Plafond depassé!");
                return;
            }

            if(_solde < montant)
            {
                Console.WriteLine("Solde Insufisant!");
                return;
            }

            _solde -= montant;
        }
    }
}