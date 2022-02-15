namespace DM
{
    public class CamionCiterne : Camion
    {
        public CamionCiterne(int imm) : base(imm)
        {
            _poidsAVide = 3;
            _chargeMax = 10;
            NouvelleCharge(0);
        }

        public override string ToString()
        {
            return "Camion Citerne " + base.ToString();
        }

        protected override int CacluleVitesseMax()
        {
            int poidTotat = PoidsTotal();
            if (poidTotat <= 3)
            {
                return 130;
            }
            else if (poidTotat <= 4)
            {
                return 110;
            }
            else if (poidTotat <= 7)
            {
                return 90;
            }
            else
            {
                return 80;
            }
        }
    }
}