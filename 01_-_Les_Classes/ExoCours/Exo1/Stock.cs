using System;

namespace Exo1
{
    public class Stock
    {
        private Article[] _articles;

        public Stock()
        {
            _articles = new Article[0];
        }

        public void AjouterArticle(Article newArticle)
        {
            if(RechercheArticle(newArticle.Reference) == null)
            {
                Article[] newTabArticles = new Article[_articles.Length + 1];
                for(int i = 0; i < _articles.Length; i++)
                {
                    newTabArticles[i] = _articles[i];
                }
                newTabArticles[_articles.Length] = newArticle;
                _articles = newTabArticles;
            }
            else
            {
                Console.WriteLine("L'Article existe déjà : " + newArticle);
            }
        }

        public void AfficherTousLesArticles()
        {
            Console.WriteLine("Mon Stock: \n");
            for(int i = 0; i < _articles.Length; i++)
            {
                Console.WriteLine(_articles[i] + "\n");
            }
        }

        public Article RechercheArticle(int reference)
        {
            for(int i = 0; i < _articles.Length; i++)
            {
                if(_articles[i].Reference == reference)
                {
                    return _articles[i];
                }
            }
            Console.WriteLine("ERREUR Cet article n'existe pas : " + reference);
            return null;
        }

        public Article RechercheArticle(string nom)
        {
            for(int i = 0; i < _articles.Length; i++)
            {
                if(_articles[i].Nom == nom)
                {
                    return _articles[i];
                }
            }
            Console.WriteLine("ERREUR Cet article n'existe pas : " + nom);
            return null;
        }

        public void RemoveArticle(int reference)
        {
            Article toDestroy = RechercheArticle(reference);
            if(toDestroy != null)
            {
                if(_articles.Length > 1)
                {
                    Article[] newTabArticles = new Article[_articles.Length-1];
                    int indexNewTab = 0;
                    for(int i = 0; i < _articles.Length; i++)
                    {
                        if(_articles[i].Reference == reference)
                        {
                            i++;
                        }
                        else
                        {
                            newTabArticles[indexNewTab] = _articles[i];
                            indexNewTab++;
                        }
                    }
                    _articles = newTabArticles;
                }
                else
                {
                    _articles = new Article[0];
                }
            }
        }

        public void ModifyArticle(int reference, float newPrixVente)
        {
            Article toModify = RechercheArticle(reference);
            if(toModify != null)
            {
                toModify.PrixVente = newPrixVente;
            }
        }

        public void ModifyArticle(Article article, float newPrixVente)
        {
            ModifyArticle(article.Reference, newPrixVente);
        }
    }
}