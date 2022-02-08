using System;

namespace Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Roger", 10);
            Employee employee2 = new Employee("Fanny", 20);
            Employee employee3 = new Employee("Bob", 20);
            Employee employee4 = new Employee("Marius", 20);

            /*Console.WriteLine(employee1);
            Console.WriteLine(employee2);
            Console.WriteLine(employee3);
            Console.WriteLine(employee4);*/
            
            Employee.mulptWaste = 10;

            /*Console.WriteLine(employee1);
            Console.WriteLine(employee2);
            Console.WriteLine(employee3);
            Console.WriteLine(employee4);*/

            Manager manager = new Manager("Chef", 15);
            Manager manager2 = new Manager("SousChef", 15);
            manager.AddSlave(employee1);
            manager.AddSlave(employee2);
            manager.AddSlave(manager2);
            manager2.AddSlave(employee3);
            manager2.AddSlave(employee4);
            
            manager.DisplayHierachy();
        }
    }
}
