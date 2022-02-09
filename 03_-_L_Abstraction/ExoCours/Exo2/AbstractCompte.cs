using System;

namespace Exo2
{
    public abstract class AbstractCompte
    {
        private int _numero;
        public int Numero {get{return _numero;}}

        protected string _nomPropriétaire;
        public string NomPropriétaire {get{return _nomPropriétaire;}}

        protected float _solde;
        public float Solde {get{return _solde;}}

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

        public virtual void Crediter(float montant)
        {
            _solde += montant;
        }

        public virtual void Debiter(float montant)
        {
            if(_solde < montant)
            {
                Console.WriteLine("Solde Insufisant!");
                return;
            }

            _solde -= montant;
        }

        public override string ToString()
        {
            return $"Numero : {Numero}\nNom : {NomPropriétaire}\nSolde : {Solde}";
        }
    }
}