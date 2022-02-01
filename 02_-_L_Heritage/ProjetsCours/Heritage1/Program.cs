using System;

namespace Heritage1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicule vehicule = new Vehicule("Concept de voiture", 60);
            vehicule.Move();
            Voiture voiture = new Voiture("Renault", 50, 4);
            voiture.Move();

            Console.WriteLine("Appel de move au travers d'un tableau de type classe vehicule : ");
            Vehicule[] vehicules = new Vehicule[]{vehicule, voiture, new Moto("Harley", 20)};
            for(int i = 0; i < vehicules.Length; i++)
            {
                vehicules[i].Move();

                if(vehicules[i] is Voiture)
                {
                    Voiture voiture1 = (Voiture)vehicules[i];
                    voiture1.OuvertureDesPortes();
                }
                else if(vehicules[i] is Moto moto)
                {
                    moto.ConnecterUnSideCar();
                }
                Console.WriteLine(vehicules[i]);
            }
        }
    }
}
