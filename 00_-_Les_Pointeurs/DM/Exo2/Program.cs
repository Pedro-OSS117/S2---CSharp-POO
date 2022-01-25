using System;

namespace Exo2
{
    unsafe class Program
    {        
        static void Main(string[] args)
        {
            Boss boss = new Boss(100, 0.5f);
            Player p1 = new Player("p1", &boss, 10);
            Player p2 = new Player("p2", &boss, 10);
            p1.Attack();
            p1.Attack();
            p2.Attack();
            boss.DisplayState();
        }

        struct Boss
        {
            private int life;
            private float shield;

            public Boss(int life, float shield = 1)
            {
                this.life = life;
                this.shield = shield;
            }

            public int Hurt(int damage)
            {
                if(IsAlive())
                {
                    int realDamage = (int)(damage * shield);
                    life -= realDamage;
                    return realDamage;
                }
                else
                {
                    Console.WriteLine("I'm already dead !");
                }
                return 0;
            }

            public bool IsAlive()
            {
                return life > 0;
            }

            public void DisplayState()
            {
                if(life > 0)
                {
                    Console.WriteLine($"Le Boss a {life} de vie et sa protection est de {shield}");
                }
                else
                {
                    Console.WriteLine("Le Boss est mort !");
                }
            }
        }

        struct Player
        {
            string name;
            Boss* bossPointer;
            int damageAttack;

            public Player(string name, Boss* bossPointer, int damageAttack)
            {
                this.name = name;
                this.bossPointer = bossPointer;
                this.damageAttack = damageAttack;
            }

            public void Attack()
            {
                int realDamageApplied = bossPointer->Hurt(damageAttack);
                Console.WriteLine($"Le Player {name} a blessé le Boss de {realDamageApplied} de dégats !");
            }
        }
    }
}
