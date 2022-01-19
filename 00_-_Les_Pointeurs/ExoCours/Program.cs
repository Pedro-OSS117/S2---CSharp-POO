using System;

namespace ExoCours
{
    unsafe class Program
    {

        struct FamilyAccount
        {
            public float amount;
        }
        
        struct MemberFamily
        {
            private FamilyAccount* account;

            public MemberFamily(FamilyAccount* account)
            {
                this.account = account;
            }

            public void UpdateAccount(float value)
            {
                if(account != null)
                {
                    account->amount += value;
                }
            }
        }

        static void Main(string[] args)
        {
            // EXO 1
            int myValue = 15;
            int* myValuePointer = &myValue;
            //Console.WriteLine("Valeur de "+ nameof(myValue) + " : " +  *myValuePointer);
            Console.WriteLine($"Valeur de {nameof(myValue)} : {*myValuePointer}");
            Console.WriteLine($"Adresse de {nameof(myValue)} : {(long)myValuePointer}");
            Console.WriteLine($"Adresse de {nameof(myValue)} : {(long)&myValue}");

            *myValuePointer = 2;
            Console.WriteLine($"Valeur de {nameof(myValue)} : {*myValuePointer}");

            int[] myTabValues = new int[]{1, 2, 3};
            fixed(int* myTabValuePointer = &myTabValues[1])
            {
                Console.WriteLine("Valeur de "+ nameof(myTabValues) + " : " +  *myTabValuePointer);
                Console.WriteLine($"Adresse de {nameof(myTabValues)} : {(long)myTabValuePointer}");

                *myTabValuePointer = 15;
                Console.WriteLine("Valeur de "+ nameof(myTabValues) + " : " +  *myTabValuePointer);
            }

            int myValue2 = 87;
            int* myValuePointer2 = &myValue2;
            Console.WriteLine($"Valeur de {nameof(myValue2)} : {*myValuePointer2}");
            MyFunction(myValuePointer, myValuePointer2);
            MyFunction(&myValue2, &myValue);
            Console.WriteLine($"Valeur de {nameof(myValue2)} : {*myValuePointer2}");

            // EXO 2
            FamilyAccount account = new FamilyAccount();
            FamilyAccount* accountPointer = &account;
            MemberFamily dad = new MemberFamily(accountPointer);
            MemberFamily mum = new MemberFamily(&account);
            dad.UpdateAccount(100);
            mum.UpdateAccount(100);

            Console.WriteLine(account.amount);
        }

        private static void MyFunction(int* pointer1, int* pointer2)
        {
            *pointer2 = *pointer1;
        }
    }
}
