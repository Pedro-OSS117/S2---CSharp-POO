namespace DM
{
    public class CamionBache : Camion
    {
        public CamionBache(int imm) : base(imm)
        {
            _poidsAVide = 4;
            _chargeMax = 20;
            NouvelleCharge(0);
        }

        public override string ToString()
        {
            return "Camion Baché " + base.ToString();
        }

        protected override int CacluleVitesseMax()
        {
            int poidTotat = PoidsTotal();
            if(poidTotat <= 4)
            {
                return 130;
            }
            else if(poidTotat <= 7)
            {
                return 110;
            }
            else if(poidTotat <= 11)
            {
                return 90;
            }
            else if(poidTotat <= 14)
            {
                return 80;
            }
            else
            {
                return 70;
            }
        }
    }
}