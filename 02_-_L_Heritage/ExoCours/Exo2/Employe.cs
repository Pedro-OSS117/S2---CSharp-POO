namespace Exo2
{
    public class Employee
    {
        /// <summary>
        /// Nom de l'employé
        /// </summary>
        private string _name;

        /// <summary>
        /// Matricule de l'employé, numéro unique dans le programme
        /// </summary>
        private int _register;

        /// <summary>
        /// Indice du salaire l'employé
        /// </summary>
        private float _indexWage;

        
        /// <summary>
        /// Valeur globale à multiplier au salaire de l'employe
        /// </summary>
        public static float mulptWaste = 1;

        private static int _currentRegister = 0;

        /// <summary>
        /// Permet d'obtenir un matricule unique à chaque création d'employé
        /// </summary>
        private static int GetNewRegister()
        {
            int newRegister = _currentRegister;
            _currentRegister++;
            return newRegister;
        }

        public Employee(string name, float indexWage)
        {
            _name = name;
            _register = Employee.GetNewRegister();
            _indexWage = indexWage;
        }

        public float CaluclateWage()
        {
            return _indexWage * mulptWaste;
        }

        public override string ToString()
        {
            return $"Matricule : {_register}\nNom : {_name}\nSalaire : {CaluclateWage()}";
        }
    }
}