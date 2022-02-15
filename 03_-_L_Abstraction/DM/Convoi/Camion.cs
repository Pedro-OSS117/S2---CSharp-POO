namespace DM
{
    public abstract class Camion : Vehicule
    {
        private int _charge;

        protected int _chargeMax;

        public int ChargeMax { get { return _chargeMax; } }

        public Camion(int imm) : base(imm)
        {
        }

        public override string ToString()
        {
            return base.ToString() +
                $", Poids à vide : {_poidsAVide}" +
                $", Charge Max : {_chargeMax} " +
                $", Charge Courante : {_charge} ";
        }

        public void NouvelleCharge(int newCharge)
        {
            if (newCharge > _chargeMax)
            {
                newCharge = _chargeMax;
            }
            else if (newCharge < 0)
            {
                newCharge = 0;
            }
            _charge = newCharge;

            _vitesseMax = CacluleVitesseMax();
        }

        protected override int PoidsTotal()
        {
            return _poidsAVide + _charge;
        }

        protected abstract int CacluleVitesseMax();
    }
}