namespace Exo2
{
    public abstract class AbstractCompte
    {
        private int _numero;

        protected string _nomPropriétaire;
        public string NomPropriétaire {get;}

        protected float _solde;
        public float Solde {get;}

        private static int counterNumero;
        
        public AbstractCompte()
        {
            _numero = GetNewNumero();
            _nomPropriétaire = "Anonyme";
        }
        
        public AbstractCompte(string nom, float solde)
        {
            _numero = GetNewNumero();
            _nomPropriétaire = nom;
            _solde = solde;
        }

        private static int GetNewNumero()
        {
            counterNumero++;
            return counterNumero;
        }

        public abstract void Crediter(float montant);

        public abstract void Debiter(float montant);
    }
}