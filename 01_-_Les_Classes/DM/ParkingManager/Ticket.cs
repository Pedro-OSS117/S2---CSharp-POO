using System;

namespace ParkingManager
{
    // Classe permettant de representer le fait qu'on vient de parker une voiture.
    // Enregistre le moment ou la voiture a été parké.
    public class Ticket
    {
        private Car _car;

        // Proriété utilisant DateTime
        private DateTime _timeCreated;

        public Ticket(Car car)
        {
            _car = car;
            _timeCreated = DateTime.Now;
        }

        // Accesseur
        public DateTime Time
        {
            get { return _timeCreated; }
        }

        public Car Car
        {
            get { return _car; }
        }
    }
}