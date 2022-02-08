namespace Exo2
{
    public class Banque
    {
        private AbstractCompte[] _tabCount;

        public Banque()
        {
            _tabCount = new AbstractCompte[0];
        }

        private void AjouterCompte(AbstractCompte count)
        {
            AbstractCompte[] tabCount = new AbstractCompte[_tabCount.Length + 1];
            for(int i = 0; i < _tabCount.Length; i++)
            {
                tabCount[i] = _tabCount[i];
            }
            tabCount[_tabCount.Length] = count;
            _tabCount = tabCount;
        }

        public void AjouterCompteSurCheque(string nom, float solde, int numeroCheque,
             int numeroCarte, int dateInvaliditeCarte)
        {
            CompteSurCheque cheque = new CompteSurCheque(nom, solde, numeroCarte, numeroCarte, dateInvaliditeCarte);
            AjouterCompte(cheque);
        }
        
        public void AjouterCompteCarnet(string nom, float solde, int numeroCarnet)
        {
            CompteSurCarnet carnet = new CompteSurCarnet(nom, solde, numeroCarnet);
            AjouterCompte(carnet);
        }
    }
}