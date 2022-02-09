using System;

namespace Exo2
{
    public class Banque
    {
        private AbstractCompte[] _tabCompte;

        public Banque()
        {
            _tabCompte = new AbstractCompte[0];
        }

        public void AjouterCompte(AbstractCompte account)
        {
            AbstractCompte[] newTabCompte = new AbstractCompte[_tabCompte.Length + 1];
            for(int i = 0; i < _tabCompte.Length; i++)
            {
                newTabCompte[i] = _tabCompte[i];
            }
            newTabCompte[_tabCompte.Length] = account;
            _tabCompte = newTabCompte;
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

        public AbstractCompte RechercherCompte(int numeroCompte)
        {
            foreach(AbstractCompte compte in _tabCompte)
            {
                if(compte.Numero == numeroCompte)
                {
                    return compte;
                }
            }
            Console.WriteLine($"Le compte {numeroCompte} n'existe pas");
            return null;
        }

        public void SuppressionCompte(int numeroCompte)
        {   
            int indexRemove = -1;
            for(int i = 0; i < _tabCompte.Length; i++)
            {
                if(_tabCompte[i].Numero == numeroCompte)
                {
                    indexRemove = i;
                    break;
                }
            }

            if(indexRemove == -1)
            {
                Console.WriteLine($"Le compte {numeroCompte} n'existe pas");
            }

            if(_tabCompte.Length > 1)
            {
                AbstractCompte[] newTabCompte = new AbstractCompte[_tabCompte.Length - 1];
                int indexReplace = 0;
                for(int i = 0; i < _tabCompte.Length; i++)
                {
                    if(i == indexRemove)
                    {
                        continue;
                    }
                    newTabCompte[indexReplace] = _tabCompte[i];
                    indexReplace++;
                }
                _tabCompte = newTabCompte;
            }
            else
            {
                _tabCompte = new AbstractCompte[0];
            }
        }

        public override string ToString()
        {
            string diplay = "==== Banque ====\n";
            foreach(AbstractCompte compte in _tabCompte)
            {
                diplay += "Compte :\n";
                diplay += compte.ToString();
                diplay += "\n";
                diplay += "\n";
            }
            return diplay;
        }
    }
}