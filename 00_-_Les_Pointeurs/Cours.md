# Les Pointeurs

References :

https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/unsafe-code-pointers/pointer-types

https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/operators/pointer-related-operators

https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/builtin-types/value-types

## I - Les Types Valeur - Notion de copie

Les types valeur et les types référence sont les deux principales catégories de types C#. 
Une variable d’un type valeur contient une instance du type. 
Cela diffère d’une variable d’un type référence, qui contient une référence à une instance du type. 

https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/builtin-types/value-types

### Conséquences :
Par défaut, lors de l' assignation, en passant un argument à une méthode et en retournant un résultat de méthode, les valeurs des variables sont copiées. 
Dans le cas des variables de type valeur, les instances de type correspondantes sont copiées. L’exemple suivant illustre ce comportement :

Type valeur peut être l’un des deux types suivants :
- type __structure__, qui encapsule les données et les fonctionnalités associées
- type __énumération__, qui est défini par un ensemble de constantes nommées et qui représente un choix ou une combinaison de choix

Types valeur intégrés également appelés types simples:
- Types __numériques intégraux__ ou type entier (byte, short, int, long)
- Types __numériques à virgule flottante__ ou type décimal (float, double, decimal)
- __booléen__ qui représente une valeur booléenne
- __char__ qui représente un caractère Unicode UTF-16

```csharp

namespace ProjetCours
{
    public struct MyPoint
    {
        public int x;
        public int y;

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }

    class Program
    {
        public static void Main()
        {
            /// I - Les Types Valeurs - Notion de copie
            Console.WriteLine("\n======== Les Types Valeurs - Notion de copie ========\n");

            // Creation d'une variable du type de la structure MyPoint (un type valeur).
            MyPoint p1 = new MyPoint(1, 2);

            // Creation d'une deuxième variable et initialisation avec la première (il y a copie de la première).
            MyPoint p2 = p1;

            // Modification d'une des valeurs de la deuxième variable.
            p2.y = 200;

            // Affichage des variables pour montrer que seulement p2 est modifée.
            Console.WriteLine($"Valeur {nameof(p1)} : {p1}");
            Console.WriteLine($"Valeur {nameof(p2)} : {p2}\n");

            // Utilisation d'une methode pour modifier p2.
            ModifyMyPointX(p2);

            // p2 n'a pas été modifié car lors de l'appel de la methode une copie a été faite.
            Console.WriteLine($"Valeur {nameof(p1)} : {p1}");
            Console.WriteLine($"Valeur {nameof(p2)} : {p2}");
	}
    }

    private static void ModifyMyPointX(MyPoint p)
    {
	p.x = 100;
	Console.WriteLine($"Point mutated in a method: {p}");
    }
}
```

![Representation de la Memoire](/00_-_Les_Pointeurs/Annexes/Representation_de_la_Memoire.jpg)

## II - Les Pointeurs - Adresse Memoire

https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/unsafe-code-pointers/pointer-types

https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/operators/pointer-related-operators

Une variable prend X octets en mémoire, son adresse est l'adresse du premier octet alloué en mémoire.
Pour accéder à l'adresse d'une variable on utilise les pointeurs.

Un __pointeur__ est une variable qui contient une adresse qui pointe vers une variable en memoire.
Via un pointeur on peut accéder à la variable pointée.
Plusieurs pointeur peuvent pointer vers la même variable. (Notion de référence)

### Declaration d'un pointeur : '*'
Pour declarer

```csharp
type* identifier;
```

Exemple avec des pointeurs de type int
```csharp
int* p1, p2, p3;   // Ok
int *p1, *p2, *p3;   // Invalid in C#
```
### Exemples de declaration avec des pointeurs
Exemple	de declaration | Description
-|-
int* p | p est un pointeur vers un entier.
int** p	| p est un pointeur vers un pointeur vers un entier.
int*[] p | 	p est un tableau unidimensionnel de pointeurs vers des entiers.
char* p |	p est un pointeur vers un caractère.
void* p |	p est un pointeur vers un type inconnu.

### Operateurs utilisés pour les pointeurs : 
Opérateur/Instruction | Utilisation
------------ | -------------
&  | 	Obtient l'adresse d'une variable.
\*  | 	Exécute l'indirection de pointeur.
->  | 	Accède à un membre d'un struct via un pointeur.
[]  | 	Indexe un pointeur.
++ et --  | 	Incrémente et décrémente les pointeurs.
\+ et -  | 	Exécute des opérations arithmétiques sur les pointeurs.

### Initialiser un pointeur - Referencement d'une variable

On utilise l'operateur '&' devant une variable pour l'initialiser
```csharp
// Declaration d'une variable i de type int
int i = 0;
// Declaration du pointeur p1 et 
int* p1 = &i;
```

### Accès à la variable pointée

On utilise l'opérateur '*' pour accéder à la variable pointée (référencée) par le pointeur

```csharp
// Affichage de la valeur de la variable i
Console.WriteLine($"Valeur de i : {*p1});
// Affichage de l'adresse de la variable i
Console.WriteLine($"Adresse de i : {(long)p1});
```
### Structure et Pointeur

```csharp
// Declaration d'une variable de type MyPoint 
MyPoint point = new Point(1,2);
// Declaration d'une pointeur sur la varible
MyPoint* pointer = &point;
// Accès à la propriété via l'operateur '->' à la place du '.'
pointer->x = 3;
```
### Tableau et Pointeur

On peut référencer l'index d'un tableau avec un pointeur.
Via un pointeur, les opérateurs arithmétiques sont utilisés pour avancer ou reculer dans l'indexation d'un tableau.

```csharp
// Declaration d'un tableau de int
int[] tabValues = new int[] { 1, 2, 3 };

// Intialisation du pointeur sur le premier élément du tableau
// Création d'une portée '__fixed__' pour l'utilisation d'un pointeur sur tableau
fixed (int* firstElementPointer = &tabValues[0])
{
    fixed (int* secondElementPointer = &tabValues[1])
    {
        // Affichage de l'adresse du premier index
        Console.WriteLine($"Adresse {nameof(firstElementPointer)} : {(long)firstElementPointer}");
        // Affichage de l'adresse du second index
        Console.WriteLine($"Adresse {nameof(secondElementPointer)} : {(long)secondElementPointer}\n");
    }

    Console.WriteLine($"Adresse {nameof(firstElementPointer)} : {(long)firstElementPointer}");
    // Utilisation de l'operateur + pour acceder à l'adresse du second element via le pointeur du premier
    Console.WriteLine($"Adresse {nameof(firstElementPointer)} + 1 : {(long)(firstElementPointer + 1)}\n");
}	    
```
## III - Le problème des pointeurs en CSharp - Garbage Collector

Le __Garbage collector__ : gère l’allocation et la libération de mémoire pour votre application automatiquement.
Pour pouvoir utiliser les pointeurs en CSharp il faut declarer les portées d'instructions "unsafe".
Les portées unsafe ne sont pas gérées pas le Garbage Collector.
https://docs.microsoft.com/fr-fr/dotnet/standard/garbage-collection/

Pour pouvoir compiler un programme avec des pointeurs il faut ajouter dans le fichier de configuration .cproj la balise suivante :
```csharp
<PropertyGroup>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
</PropertyGroup>
```
  
Attention : Utiliser les pointeurs en CSharp n'est pas conseillé. C'est une notion très importante pour le C++ et le C.

Deux mots clefs doivent être declarés dans votre programme pour pouvoir utiliser les pointeurs :
- __unsafe__ : à declarer dans la portée où un pointeur est utilisé.
```csharp
class Program
{
    public unsafe static void Main()
    {
        // Declaration d'une variable i de type int
        int i = 0;
        // Declaration du pointeur p1 et 
        int* p1 = &i;
    }
}
```

- __fixed__ : à declarer lors de la création d'un pointeur 
```csharp
int[] tabValues = new int[] { 1, 2, 3 };

fixed (int* firstElementPointer = &tabValues[0])
{
}	    
```
