using System;

namespace Exo2
{
    public class Manager : Employee
    {
        private Employee[] _slaves;

        public Manager(string name, float indexWage) : base(name, indexWage)
        {
            _slaves = new Employee[0];            
        }

        public void AddSlave(Employee employee)
        {
            Employee[] newSlaves = new Employee[_slaves.Length + 1];
            for (int i = 0; i < _slaves.Length; i++)
            {
                newSlaves[i] = _slaves[i];
            }
            newSlaves[_slaves.Length] = employee;
            _slaves = newSlaves;
        }

        public void DisplayHierachy()
        {
            Console.WriteLine("=======================\n");
            Console.WriteLine(this);
            Console.WriteLine("Hierarchie Manager :\n");
            for (int i = 0; i < _slaves.Length; i++)
            {
                Console.WriteLine(_slaves[i]);
                if(_slaves[i] is Manager underManager)
                {
                    underManager.DisplayHierachy();
                }
            }
        }
    }
}