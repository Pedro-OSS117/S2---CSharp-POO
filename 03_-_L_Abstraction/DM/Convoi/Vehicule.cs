namespace DM
{
    public abstract class Vehicule
    {
        private int _immatriculation;

        protected int _poidsAVide;

        protected int _vitesseMax;

        public int VitesseMax
        {
            get { return _vitesseMax; }
        }

        public Vehicule(int imm)
        {
            _immatriculation = imm;
        }

        public override string ToString()
        {
            return " Immatriculé : " + _immatriculation;
        }

        protected abstract int PoidsTotal();
    }
}