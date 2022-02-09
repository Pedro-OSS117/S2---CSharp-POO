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

        public override string ToString()
        {
            return base.ToString() + $"\nNumero Cheque : {_numeroCheque}\nNumero Carte : {_numeroCarte}\nDate Invalidité Carte : {_dateInvaliditeCarte}";
        }
    }
}