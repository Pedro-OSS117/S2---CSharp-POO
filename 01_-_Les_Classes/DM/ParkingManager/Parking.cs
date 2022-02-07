using System;

namespace ParkingManager
{
    public class Parking
    {
        // Tableau de voiture representant les places
        private Car[] _parkingSpaces;

        // Prix d'une heure
        private float _oneHourPrice;

        // Combien la personne à gagner au cours de cette journée
        private float _earnedMoney;

        public Parking(int nbrPlace, float price)
        {
            // Verification du nombre de place passer en paramètre
            if (nbrPlace < 1)
            {
                nbrPlace = 1;
            }

            // Initialisation du tableau en fonction du nombre de place
            _parkingSpaces = new Car[nbrPlace];

            // Initilasation de earned money
            _earnedMoney = 0;

            // Verification du montant du prix
            if (price < 0)
            {
                price = 0.1f;
            }
            _oneHourPrice = price;
        }

        public float EarnedMoney
        {
            get { return _earnedMoney; }
        }

        public int GetNbrSpaces()
        {
            return _parkingSpaces.Length;
        }

        // Methode qui me retourne un index d'une place libre
        // -1 si il n'y a pas de place.
        private int FindFreeSpace()
        {
            for (int i = 0; i < _parkingSpaces.Length; i++)
            {
                // Si place == null je retourne l'index car place vide.
                if (_parkingSpaces[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }

        // Ajout d'une voiture
        public bool AddCar(Car car)
        {
            // Recuperation de l'index d'une place libre
            int index = FindFreeSpace();
            if (index != -1)
            {
                // Assignation de la variable car au tableau au bon index.
                _parkingSpaces[index] = car;
                return true;
            }
            return false;
        }

        // Suppression d'une voiture dans le parking
        public void RemoveCar(Car car)
        {
            for (int i = 0; i < _parkingSpaces.Length; i++)
            {
                // Test par reference pour trouver la voiture correpsondante
                if (_parkingSpaces[i] == car)
                {
                    // on met à null pour liberer la place
                    _parkingSpaces[i] = null;
                    return;
                }
            }
        }

        // Calcule nombre de place disponible
        public int GetSpacesAvailable()
        {
            int nbrPlace = 0;
            for (int i = 0; i < _parkingSpaces.Length; i++)
            {
                if (_parkingSpaces[i] != null)
                {
                    nbrPlace++;
                }
            }
            return nbrPlace;
        }

        // Caclule argent gagné en fonction du temps passé en paramètre
        public float AddMoneyFromTime(DateTime time)
        {
            // Calcule du temps passé
            TimeSpan timeSpan = DateTime.Now.Subtract(time);

            // On multiplie le temps par le pognon par heure
            float money = timeSpan.Hours * _oneHourPrice;

            // On mutliplie aussi le temps par le pognon par minutes
            money += timeSpan.Minutes / 60.0f * _oneHourPrice;

            // Ajoute a la varible qui contient le pognon gagné depuis le debut de la journée
            _earnedMoney += money;

            return money;
        }

        public void DisplayParkingState()
        {
            for (int i = 0; i < _parkingSpaces.Length; i++)
            {
                string parkState = "Park n°" + (i + 1) + " : ";
                parkState += _parkingSpaces[i] != null ? _parkingSpaces[i].OwnerName : "None";
                Console.WriteLine(parkState);
            }
        }
    }
}