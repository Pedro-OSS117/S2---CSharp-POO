namespace ParkingManager
{
    // Classe representant une simple voiture
    public class Car
    {
        // propriété qui represente le propriétaire
        private string _ownerName;

        // Constructeur
        public Car(string name)
        {
            _ownerName = name;
        }

        // Accesseur
        public string OwnerName
        {
            get { return _ownerName; }
        }
    }
}