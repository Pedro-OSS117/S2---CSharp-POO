using System;

/*** Exo 1

1) Declarer :
- une variable "myValue" de type int avec une valeur.
- un pointeur "myValuePointer" qui pointe sur cette variable.
- un tableau "myTabValues" de 3 int avec des valeurs differentes assignées à chaque index.
- un pointeur "myTabValuePointer" qui pointe sur le deuxième élément du tableau.

2) Afficher les valeurs des variables via les pointeurs

3) Afficher les adresses des variables via les pointeurs

4) Modifier les variables via les pointeurs et afficher les nouvelles valeurs

5) Ecrire une fonction qui prend en paramètre deux pointeurs de type int.
La fonction doit assigner la valeur de la variable pointé par le premier pointeur
à la seconde variable pointé par le second pointeur.

Appeler la fonction avec le pointeur sur myValue, et un pointeur sur le premier élément du tableau.
***/

namespace ExoCours
{
    unsafe class Program
    {
        static void Main(string[] args)
        {
            int myValue = 10;
            int* myValuePointer = &myValue;

            int[] myTabValues = new int[]{ 1, 2, 3};
            fixed(int* myTabValuePointer = &myTabValues[1])
            {
                Console.WriteLine($"{nameof(myValuePointer)} : {*myValuePointer} ");
                Console.WriteLine($"{nameof(myTabValuePointer)} : {*myTabValuePointer} ");
                Console.WriteLine($"Adress {nameof(myValuePointer)} : {(long)myValuePointer} ");
                Console.WriteLine($"Adress {nameof(myTabValuePointer)} : {(long)myTabValuePointer} ");

                *myValuePointer = 100;
                *myTabValuePointer = 230;

                Console.WriteLine($"{nameof(myValuePointer)} : {*myValuePointer} ");
                Console.WriteLine($"{nameof(myTabValuePointer)} : {*myTabValuePointer} ");

                // 1ere sol pour le 5)
                AssignFromTo(myValuePointer, myTabValuePointer - 1);

                Console.WriteLine($"{nameof(myTabValuePointer)} : {*(myTabValuePointer - 1)} ");

                // 2eme sol pour le 5)
                fixed(int* myTabValuePointer2 = &myTabValues[0])
                {
                    AssignFromTo(myValuePointer, myTabValuePointer2);
                    Console.WriteLine($"{nameof(myTabValuePointer)} : {*myTabValuePointer2} ");
                }

            }
        }

        static void AssignFromTo(int* from, int* to)
        {
            *to = *from;
        }
    }
}
