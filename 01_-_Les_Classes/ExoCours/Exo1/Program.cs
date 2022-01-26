using System;

namespace Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Article a = new Article(-1, "", -5, -10);
            //Console.WriteLine(a);
            Article a2 = new Article(404, "ErreurSystem", 100, 404);
            //Console.WriteLine(a2);

            Stock stock = new Stock();
            Stock stock1 = stock;
            stock.AjouterArticle(a);
            stock.AjouterArticle(a2);

            stock.AfficherTousLesArticles();

            Article searchedArticle = stock.RechercheArticle(404);
            if(searchedArticle != null)
            {
                Console.WriteLine(searchedArticle.ToString());
            }

            stock.RemoveArticle(404);            
            stock.AfficherTousLesArticles();

            stock.AjouterArticle(a2);
            stock.ModifyArticle(a2, 325);            
            stock.AfficherTousLesArticles();

            stock1.AfficherTousLesArticles();
    
        }
    }
}
