namespace DM
{
    public class PetitBus : Vehicule
    {
        public PetitBus(int imm) : base(imm)
        {
            _poidsAVide = 4;
            _vitesseMax = 150;
        }

        public override string ToString()
        {
            return "Petit Bus " + base.ToString() + $", Poids à vide : {_poidsAVide}";
        }

        protected override int PoidsTotal()
        {
            return _poidsAVide;
        }
    }
}