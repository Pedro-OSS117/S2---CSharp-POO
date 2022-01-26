using System;

namespace CreateClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Notion de type valeur et de type reference
            // Structure type valeur
            MyStruct myVar1 = new MyStruct();
            myVar1.value = 10;
            MyStruct myVar2 = new MyStruct();
            myVar2 = myVar1;
            myVar1.value = 15;

            Console.WriteLine($"{nameof(myVar1)} : {myVar1.value}");
            Console.WriteLine($"{nameof(myVar2)} : {myVar2.value}");

            // Classe type reference
            MyClass myClass1 = new MyClass();
            myClass1.value = 10;
            MyClass myClass2 = new MyClass();
            myClass2 = myClass1;
            myClass1.value = 15;

            Console.WriteLine($"{nameof(myClass1)} : {myClass1.value}");
            Console.WriteLine($"{nameof(myClass2)} : {myClass2.value}");
        }

        struct MyStruct
        {
            public int value;
        }

        class MyClass
        {
            public int value;
        }
    }
}
