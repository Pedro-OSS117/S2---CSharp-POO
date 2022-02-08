using System;

namespace Exo2
{
    public class CompteSurCheque : AbstractCompte
    {
        private int _numeroCheque, _numeroCarte, _dateInvaliditeCarte;
        
        public CompteSurCheque(string nom, float solde, int numeroCheque,
             int numeroCarte, int dateInvaliditeCarte) : base(nom, solde)
        {
            _numeroCheque = numeroCheque;
            _numeroCarte = numeroCarte;
            _dateInvaliditeCarte = dateInvaliditeCarte;
        }

        public override void Crediter(float montant)
        {
            _solde += montant;
        }

        public override void Debiter(float montant)
        {
            if(_solde < montant)
            {
                Console.WriteLine("Solde Insufisant!");
                return;
            }

            _solde -= montant;
        }
    }
}