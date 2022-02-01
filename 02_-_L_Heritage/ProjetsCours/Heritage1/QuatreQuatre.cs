namespace Heritage1
{
    public class QuatreQuatre : Voiture
    {
        public QuatreQuatre(string marque, float essence, int nombreDePorte) 
            : base(marque, essence, nombreDePorte)
        {
            _nombreRoueMotrice = 4;
        }
    }
}