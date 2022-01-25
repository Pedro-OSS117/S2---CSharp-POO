using System;

/**
===================== Exo 2 - Boss And Player =====================

1) Creer une structure Boss ayant les propriétés suivantes :
- une vie sous forme d'entier (si la vie tombe à zero il est mort).
- une protection (float) qui sera un multiplicateur des dégats reçus.

2) La structure doit avoir un constructeur permettant de setter ces propriétés.

3) Dans la structure Boss, creer une fonction qui verifie si le boss est mort.

4) Dans la structure Boss, creer une fonction qui permet d'attribuer des dégats au boss.
Appliquer les degats en fonction de s'il n'est pas mort et de sa protection (on multiplie les degats par la protection).
Cette fonction doit être public.
Cette fonction retourne le nombre réél de degats appliqués.

5) Dans la structure Boss, créer une fonction qui affiche l'état du boss (vie et protection)

6) Creer une structure Player ayant les propriétés suivantes :
- un nom
- un nombre de dégats
- un pointeur de type Boss

7) Dans la structure Player, creer une constructeur qui permet de setter ces propriétés.

8) Dans la structure Player, creer une fonction 'Attack' qui permet d'appliquer des dégats au Boss pointé par la propriété de type pointeur.
La fonction utilise les dégats de la propriété de la structure.
La fonction affiche à chaque attaque : "Le Player {NomPlayer} a blessé le Boss de {dégats}".

9) Utiliser ces deux structures pour faire un programme qui :
- Creer une variable de type Boss.
- Creer deux variables de type Player avec des dégats differents, et qui ont leur propriétés de pointeur Boss pointant la variable Boss créée juste avant.
- Appliquer plusieurs fois les degats via les variables de type player.
- Terminer le programme en affichant l'état du Boss après l'application des attaques.
**/

namespace Exo2
{
    unsafe class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss(50, 1.2f);
            
            Player p1 = new Player("Bob", 15, &boss);
            Player p2 = new Player("Alice", 30, &boss);
            
            p1.Attack();
            p2.Attack();
            p1.Attack();
            p2.Attack();

            Console.WriteLine(boss);
        }
        
        // Structure representant un Boss.
        struct Boss
        {
            // Vie du Boss.
            private int life;
            // Protection du Boss.
            private float protection;

            // Constructeur avec paramètres pour setter les propriétés.
            public Boss(int life, float protection)
            {
                this.life = life;
                this.protection = protection;
            }

            // Fonction de test - Est ce que le Boss est tjrs en vie.
            public bool IsAlive()
            {
                return life > 0;
            }

            // Fonction pour appliquer des dommages au Boss.
            public int ApplyDamages(int damages)
            {
                // On test d'abord si le Boss est en vie.
                if(IsAlive())
                {
                    // si oui on applique les dégats en fonction de la protection.
                    int realDamage = (int)(damages * protection);
                    life -= realDamage;
                    return realDamage;
                }
                else
                {
                    Console.WriteLine("Chui déjà mort les mecs !");
                }
                return 0;
            }

            public override string ToString()
            {
                return $"State Boss => life : {life}, protection {protection}";
            }
        }

        struct Player
        {
            private string nom;
            private int damageAttack;
            private Boss* currentBoss;

            public Player(string nom, int damageAttack, Boss* pointerBoss)
            {
                this.nom = nom;
                this.damageAttack = damageAttack;
                this.currentBoss = pointerBoss;
            }

            public void Attack()
            {
                int damageApplied = currentBoss->ApplyDamages(damageAttack);
                Console.WriteLine($"Le Player {nom} a blessé le Boss de {damageApplied}.");
            }
        }
    }
}
