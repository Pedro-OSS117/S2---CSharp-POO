using System;

/**
================== Exo 1 - Char Pointer =====================

1) Creer les variables suivantes ;
- un char caractere1 intialisé avec 'O'
- un char caractere2 intialisé avec 'A'
- un pointeur de type char qui reference la variable caractere1
- un pointeur de type char qui reference la variable caractere2

2) Creer une fonction qui prend deux pointeurs de type char en entrée.
La fonction doit copier la valeur de la variable pointée par le premier pointeur dans la variable pointée par le deuxième.

3) Appeler la fonction avec comme paramètres les deux pointeurs déclarés dans 1).

4) Afficher les valeurs de caractere1 et caractere2 via les pointeurs.
Le résultat doit être 'O' et 'O'.

**/
namespace Exo1
{
    unsafe class Program
    {
        static void Main(string[] args)
        {
            // Déclaration et assignation des variables.
            char caractere1 = 'O';
            char caractere2 = 'A';

            // Déclaration et assignation des pointeurs.
            char* pointerCaractere1 = &caractere1;
            char* pointerCaractere2 = &caractere2;

            // Pointeur sur la même variable.
            char* pointerCaractere1_2 = &caractere1;
            char* pointerCaractere1_3 = pointerCaractere1;
             
            // Affichage des adresses des differents pointeurs qui pointent sur la même adresse
            // et donc qui pointent sur la même variable. On a plusieurs référence vers la même variable.
            Console.WriteLine($"Adresse {nameof(pointerCaractere1)} : {(long)pointerCaractere1}.");
            Console.WriteLine($"Adresse {nameof(pointerCaractere1_2)} : {(long)pointerCaractere1_2}.");
            Console.WriteLine($"Adresse {nameof(pointerCaractere1_3)} : {(long)pointerCaractere1_3}.");

            // On incremente l'adresse du pointeur => l'adresse s'incremente en fonction du type
            pointerCaractere1++;
            // Affichage de l'adresse incrementée => 2 octets en plus
            Console.WriteLine($"Adresse {nameof(pointerCaractere1)} : {(long)pointerCaractere1}.");
            pointerCaractere1--;

            // Appelle de la notre fonction sur les deux variables déclarées précédemment.
            FromToCharPointer(pointerCaractere1, pointerCaractere2);
            // FromToCharPointer(&caractere1, &caractere2); // Equivalent à l'instruction au dessus.

            // Affichage des valeurs des variables via les pointeurs
            Console.WriteLine($"Value {nameof(caractere1)} : {*pointerCaractere1}.");
            Console.WriteLine($"Value {nameof(caractere1)} : {*pointerCaractere1_3}.");
            Console.WriteLine($"Value {nameof(caractere2)} : {*pointerCaractere2}.");
        }

        // La fonction copie la valeur de la variable pointée par pointerFrom
        // dans la variable pointée pointerTo.
        static void FromToCharPointer(char* pointerFrom, char* pointerTo)
        {
            // Assignation de la valeur de la variable à l'adresse pointée par pointerFrom 
            // dans la variable présente à l'adresse pointée par pointerTo.
            *pointerTo = *pointerFrom;
        }

    }
}
