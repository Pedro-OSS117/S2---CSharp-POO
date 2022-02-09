using System;

namespace Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Banque banque = new Banque();

            CompteSurCheque compteCheque = new CompteSurCheque("Roger", 100, 1201, 6544, 1212011);
            CompteSurCarnet compteCarnet = new CompteSurCarnet("Bob", 1000, 1512);
            
            banque.AjouterCompte(compteCheque);
            banque.AjouterCompte(compteCarnet);

            Console.WriteLine(banque);

            AbstractCompte account = banque.RechercherCompte(2);            
            Console.WriteLine(account);
            banque.RechercherCompte(10);

            banque.SuppressionCompte(2);
            Console.WriteLine(banque);
        }
    }
}
