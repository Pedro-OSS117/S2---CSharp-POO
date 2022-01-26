using System;

namespace MyNamespace
{
    public class Person
    {
        // Propriété membre
        private int _age;
        private string _name = "Anonyme";
        
        // Surcharge constructeur par defaut
        public Person()
        {
            Age = 0;
        }

        public Person(int age)
        {
            Age = age;
        }

        public Person(int age, string name)
        {
            Age = age;
            _name = name;
        }

        /* 
         Accesseur de base qui n'a pas trop de sens
         parce que ici la variable devient comme public
        */
        public int Age
        {
            get { return _age; }
            set 
            { 
                if(value >= 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("ERROR : Age negatif");
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if(value != "")
                {
                    // tester qu'il n'y a pas de chiffre

                    // Setter la valeur du nom
                    _name = value;
                }
                else
                {
                    Console.WriteLine("ERROR : Age negatif");
                }
            }
        } 

        public override string ToString()
        {
            return $"Age : {Age}, Name : {Name}"; 
        }
    }
}