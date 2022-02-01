namespace Heritage1
{
    public class Moto : Vehicule
    {
        private bool _sideCar;
        
        public Moto(string marque, float essence) : base(marque, essence)
        {
            _sideCar = false;
        }

        public override string ToString()
        {
            string display = base.ToString();
            display += "Type : Moto\n";
            display += "Sidecar : " + (_sideCar ? "Oui" : "Non" );
            return display;
        }

        public void ConnecterUnSideCar()
        {
            _sideCar = true;
        }
    }
}