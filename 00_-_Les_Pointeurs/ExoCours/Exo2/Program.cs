using System;


/*** Exo 2
1) Creer une structure FamilyAccount.
Ajouter à la structure une propriété public amount de type float 

2) Creer une structure MemberFamily. 
Ajouter à la structure une propriété :
- private account, 
- un pointeur de type FamilyAccount

3) Creer le constructeur de la structure MemberFamily 

4) Ajouter une fonction à la structure MemberFamily 'UpdateAccount'.
La fonction prend en entrée un montant et l'ajoute au compte (via le pointeur)

5) Dans Main, creer :
- une variable de type FamilyAccount.
- deux variables de type MemberFamily (Dad et Mum)
- appeler la fonction UpdateAccount avec chacune des deux variables et avec un montant different.
- afficher le montant contenu dans la variable de type FamilyAccount.
***/
namespace Exo2
{
    unsafe class Program
    {
        static void Main(string[] args)
        {
            FamilyAccount account = new FamilyAccount();
            FamilyAccount* accountPointer = &account;
            MemberFamily dad = new MemberFamily(accountPointer);
            MemberFamily mum = new MemberFamily(accountPointer);

            dad.AddAmount(150);
            dad.AddAmount(250);
            mum.AddAmount(2500);

            Console.WriteLine("Montant du compte : " + account.amount);
            Console.WriteLine("Montant du compte Mum : " + mum.GetAmount());
            Console.WriteLine("Montant du compte Dad : " + dad.GetAmount());
        }

        struct FamilyAccount
        {
            public float amount;
        }

        struct MemberFamily
        {
            FamilyAccount* account;

            public MemberFamily(FamilyAccount* account)
            {
                this.account = account;
            }

            public float GetAmount()
            {
                return account->amount;
            }

            public void AddAmount(int amount)
            {
                account->amount += amount;
            }
        }
    }
}
