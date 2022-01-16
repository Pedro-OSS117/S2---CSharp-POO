using System;

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
        public unsafe static void Main()
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

            /// Les Pointeurs - Adresse Memoire
            Console.WriteLine("\n\n======== Les Pointeurs - Adresse Memoire ========\n");

            // Declaration de deux variables int et assignation
            int myVariable1 = 10, myVariable2 = 20;

            // Declaration de deux variables de type pointer (int)
            // Les deux variables pointent sur la même adresse (la même variable ici)
            // On utilise le caractère '*' pour déclarer une variable de type pointer
            int* pointerMyVariable1_1 = &myVariable1;
            int* pointerMyVariable1_2 = &myVariable1;
            int* pointerMyVariable2_1 = &myVariable2;
            int** pointerOfPointerMyVariable1 = &pointerMyVariable1_1;

            Console.WriteLine($"Adresse {nameof(pointerMyVariable1_1)} : {(long)pointerMyVariable1_1}");
            Console.WriteLine($"Adresse {nameof(pointerMyVariable1_2)} : {(long)pointerMyVariable1_2}\n");

            Console.WriteLine($"Valeur {nameof(pointerMyVariable1_1)} : {*pointerMyVariable1_1}");
            Console.WriteLine($"Valeur {nameof(pointerMyVariable1_2)} : {*pointerMyVariable1_2}");

            pointerMyVariable1_1 -= 1;
            Console.WriteLine($"Valeur {nameof(pointerMyVariable1_2)} : {*(pointerMyVariable1_1)}");
            Console.WriteLine($"Valeur {nameof(pointerOfPointerMyVariable1)} : {((long)*pointerOfPointerMyVariable1)}\n");

            // On créé deux pointeurs qui pointent tous les deux à la même adresse,
            // l'adresse de la variable p1.
            MyPoint* pointerP1_1 = &p1;
            MyPoint* pointerP1_2 = &p1;
            MyPoint* pointerP2_1 = &p2;

            Console.WriteLine($"Valeur struct p1 : {*pointerP1_1} et struct p2 {*pointerP2_1}");

            Console.WriteLine($"Adresse {nameof(pointerP1_1)} : {(long)pointerP1_1} \n"
            + $"Adresse {nameof(pointerP1_2)} : {(long)pointerP1_2}\n"
            + $"Adresse {nameof(pointerP2_1)} : {(long)pointerP2_1}\n");

            Console.WriteLine($"\nValeur {nameof(pointerP1_1)} : {pointerP1_1->x} \n"
            + $"Valeur {nameof(pointerP1_2)} : {pointerP1_2->x}\n"
            + $"Valeur {nameof(pointerP2_1)} : {pointerP2_1->x}\n");

            ModifyMyPointXByPointer(pointerP1_1);

            Console.WriteLine($"Après Modif \nValeur {nameof(pointerP1_1)} : {pointerP1_1->x} \n"
            + $"Valeur {nameof(pointerP1_2)} : {pointerP1_2->x}\n"
            + $"Valeur {nameof(pointerP2_1)} : {pointerP2_1->x}\n");

            int[] tabValues = new int[] { 1, 2, 3 };
            // Intialisation du pointeur sur le premier élément du tableau
            // Création d'une portée '__fixed__' pour l'utilisation d'une pointeur sur tableau
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
        }

        private static void ModifyMyPointX(MyPoint p)
        {
            p.x = 100;
            Console.WriteLine($"Point mutated in a method: {p}");
        }

        private unsafe void ModifyIntByPointer(int* value)
        {
            // On utilise le caractère '*' devant une variable pointeur
            // pour acceder à la variable pointée.
            // Ici on assigne à la variable pointé par le pointeur value, la valeur 10.
            *value = 10;
        }

        private unsafe static void ModifyMyPointXByPointer(MyPoint* p)
        {
            // On utilise le caractère '-' pour acceder aux propriétés de la structure.
            // Ici on assigne une autre valeur à propriété de la variable 
            // pointée par le pointeur passé en paramètre.
            p->x = 100;
        }
    }
}
