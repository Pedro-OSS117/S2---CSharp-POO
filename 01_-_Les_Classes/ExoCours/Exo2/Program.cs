using System;

/**
Soit à développer une application de gestion des adhérents qui sont inscrits dans une Médiathèque. 
Lorsqu’un adhérent est inscrit à la Médiathèque, on lui affecte automatiquement un numéro et on fixe sa cotisation. L’ adhèrent qui le souhaite peut ne plus appartenir à la médiathèque, il démissionne.
1. Créer la classe Adhérent.
2. Ajouter à la classe Adhérent les méthodes :
         a. ToString () : affichage des attributs de la classe Adhérent sous forme de chaine de caractères.
         b. Modifie (Double cotisation) : modification de la cotisation.
3. Ajouter un constructeur par défaut qui permet de créer un objet Adhérent dont le nom est « anonyme ».
4. Ajouter un constructeur qui permet de crée un objet adhèrent en générant un numéro aléatoire.
5. Ecrire le code permettant de saisir un adhèrent et prévoir les cas d’exception.
6. Ajouter une méthode de modification d’un adhèrent.
7. Ajouter une méthode d’affichage et de recherche d’un adhèrent.
8. Ajouter une méthode de suppression d’un adhérent.
9. Ajouter une méthode d’affichage de tous les adhérents.
**/
namespace Exo2
{
    class Program
    {
        private Adherent[] _adherents;

        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENUE DANS VOTRE PROGRAMME DE GESTION DE MEDIATHEQUE :) !");
            Program mediatheque = new Program();
            mediatheque.AddAdherent();
            mediatheque.DisplayAllAdherent();
        }

        public Program()
        {
            _adherents = new Adherent[1];
        }

        public void AddAdherent()
        {
            Console.WriteLine("Entrer un nouvel adherent : ");

            bool isValid = false;
            string name = "";
            while(!isValid)
            {
                Console.WriteLine("Entrer le nom de l'adherent");
                name = Console.ReadLine();

                if(!string.IsNullOrEmpty(name))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Erreur : entrez une valeur non vide !");
                }
            }
            
            isValid = false;
            double contribution = 0;
            while(!isValid)
            {
                Console.WriteLine("Entrer la cotisation de l'adherent");
                string cotisationEntered = Console.ReadLine();
                if(double.TryParse(cotisationEntered, out contribution))
                {
                    if(Adherent.IsValidContribution(contribution))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine($"Erreur : Entrez une valeur superieur à {Adherent.DefaultContribution} !");
                    }
                }
                else
                {
                    Console.WriteLine("Erreur : Entrez une valeur numérique !");
                }
            }

            // Creation de l'adherent après validation des valeurs
            Adherent newAdherent = new Adherent(name);
            newAdherent.Modify(contribution);

            // Ajout de l'adherent dans la liste            
            for (int i = 0; i < _adherents.Length; i++)
            {
                if (_adherents[i] == null)
                {
                    _adherents[i] = newAdherent;
                    return;
                }
            }

            Adherent[] newArticles = new Adherent[_adherents.Length + 1];
            for (int i = 0; i < _adherents.Length; i++)
            {
                newArticles[i] = _adherents[i];
            }
            newArticles[_adherents.Length] = newAdherent;
            _adherents = newArticles;
        }

        public void DisplayAllAdherent()
        {
            Console.WriteLine("Liste de tous les adherents : ");
            foreach(Adherent a in _adherents)
            {
                if(a != null)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
