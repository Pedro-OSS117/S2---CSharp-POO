using System;

/* Exo 3
1 - Creer une classe Rectangle et Ajoutez des attributs à la classe : sa largeur, sa hauteur en pixel et sa position à l’écran (positionX,positionY) en pixel.

2 - Ajoutez un constructeur paramétrique qui initialise la taille et la position de l’objet.

3 - Ajoutez une méthode d’instance Aire (sans argument) qui retourne l’aire du rectangle.

4 - Dans la méthode Main de la classe Program :
- Créez une nouvelle instance de la classe Rectangle de dimension 20 par 30 à la position (15,20).
- Affichez les valeurs des attributs de l’objet créé.
- Affichez l’aire de l’objet créé (utilisez la méthode Aire) afin de la calculer.
- Exécutez votre programme et vérifiez que tout fonctionne correctement (ajoutez l’instruction Console.Read(); à la fin du Main pour éviter que la fenêtre ne se ferme tout de suite).

5 - Ajoutez un constructeur sans argument qui initialise la forme comme un carré de coté 10 et de position (0,0). Respectez le principe DRY : utilisez le chainage de constructeurs pour que le corps de votre constructeur ne contienne aucune instruction !

6 - Ajoutez une méthode DoublerTaille qui multiplie la largeur et la longueur du rectangle par 2.

7 - Dans la méthode Main de la classe Program :
- Créez une nouvelle instance de la classe Rectangle avec votre constructeur sans argument.
- Doublez la taille du rectangle créé avec la méthode DoublerTaille.
- Affichez les dimensions du rectangle pour vérifier que tout a bien fonctionné.

8 - Ajoutez une méthode TestePlusPetit qui prend en paramètre un rectangle r et retourne vrai si l’aire de r est plus petite que l’aire de l’instance courante.

9 - Dans la méthode Main de la classe Program : Testez la méthode TestePlusPetit avec les 2 références de Rectangle déjà créées.

10 - Créez le constructeur de recopie : constructeur qui reçoit en paramètre une référence sur un objet du même type et qui initialise à l’identique l’objet en cours de création. Respectez le principe DRY : utilisez le chainage de constructeurs pour que le corps de votre constructeur ne contienne aucune instruction !

11 - Dans la méthode Main de la classe Program :
- Créez une copie du premier rectangle créé.
- Modifiez la largeur de la copie.
- Vérifiez que la largeur du premier rectangle n’a pas changé.

*/
namespace Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 4
            Rectangle rect = new Rectangle(20, 30, 15, 20);
            Console.WriteLine(rect);
            Console.WriteLine(rect.Aire());

            // Question 7
            Rectangle rect2 = new Rectangle();
            rect2.DoublerTaille();
            Console.WriteLine(rect2);

            // Question 9             
            Console.WriteLine(rect2.IsLittleThan(rect));

            // Question 10
            Rectangle rect3 = rect.Copy();
            Rectangle rect4 = new Rectangle(rect2);

            // Question 11
            rect3.DoublerTaille();
            rect4.DoublerTaille();
            Console.WriteLine(rect);
            Console.WriteLine(rect2);
            Console.WriteLine(rect3);
            Console.WriteLine(rect4);
        }
    }
}