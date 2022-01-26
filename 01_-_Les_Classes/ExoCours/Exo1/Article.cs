using System;

namespace Exo1
{
    public class Article
    {
        private int _reference;
        private string _nom;
        private float _prix;
        private float _prixVente;

        public Article(int reference, string nom, float prix, float prixVente)
        {
            Reference = reference;
            Nom = nom;
            Prix = prix;
            PrixVente = prixVente;
        }

        public int Reference
        {
            get { return _reference; }
            private set 
            {
                if(value > 0)
                {
                    _reference = value;
                }
                else
                {
                    Console.WriteLine("La reference doit être strictement positif");
                }
            }
        }

        public string Nom
        {
            get {return _nom;}
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    _nom = "PAS DE NOM!";
                    Console.WriteLine("Nom vide, problème!");
                }
                else
                {
                    _nom = value;
                }
            }
        }

        public float Prix
        {
            get { return _prix; }
            set 
            {
                if(value > 0)
                {
                    _prix = value;
                }
                else
                {
                    _prix = 0.01f;
                    Console.WriteLine("Le prix doit être strictement positif");
                }
            }
        }

        public float PrixVente
        {
            get { return _prixVente; }
            set 
            {
                if(value >= _prix)
                {
                    _prixVente = value;
                }
                else
                {
                    _prixVente = _prix;
                    Console.WriteLine("Le prix de vente doit être superieur au prix d'achat");
                }
            }
        }

        public override string ToString()
        {
            return $"Reference : {_reference}\n"
            + $"Nom : {_nom}\n"
            + $"Prix d'achat : {_prix}\n"
            + $"Prix vente : {_prixVente}";
        }
    }
}