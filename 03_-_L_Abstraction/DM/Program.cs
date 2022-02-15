using System;
using Helper;

namespace DM
{
    class Program
    {
        const string errorMessage = "Mauvaise Option, reessayer s'il vous plait.\n";

        static void Main(string[] args)
        {
            Convoi convoi = new Convoi();

            Console.WriteLine("======== Bienvenue dans notre programme de test de Convoi ========");

            string optionsMessage = "_______ Choissisez une des options suivantes _______\n";
            optionsMessage += "1 - Ajouter Vehicule, 2 - Afficher tous les Vehicules , 3 - Afficher vitesse Max , 4 - Terminer Programme";


            int choosenOption = -1;
            int endOptions = 4;
            while (choosenOption != endOptions)
            {
                choosenOption = HelperInput.ReadInt(1, endOptions, optionsMessage, errorMessage);
                switch (choosenOption)
                {
                    case 1:
                        AddNewVehicle(convoi);
                        break;
                    case 2:
                        Console.WriteLine(convoi);
                        break;
                    case 3:
                        Console.WriteLine("La vitesse max du convoi est : " + convoi.GetMaxVitesse());
                        break;
                    case 4:
                        Console.WriteLine("Merci d'avoir utiliser notre programme, bonne journée à vous :) !");
                        break;
                }
            }
        }

        static void AddNewVehicle(Convoi convoi)
        {
            string optionsMessage = "_______ Choissisez un des véhicules suivants _______\n";
            optionsMessage += "1 - Ajouter Petit Bus, 2 - Ajouter Camion Citerne , 3 - Ajouter Camion Baché";
            int choosenOption = HelperInput.ReadInt(1, 3, optionsMessage, errorMessage);

            int immatriculation = HelperInput.ReadInt("Quelle est l'immatriculation du vehicule");
            Vehicule newVehicule = null;
            switch (choosenOption)
            {
                case 1:
                    newVehicule = new PetitBus(immatriculation);
                    break;
                case 2:
                case 3:
                    Camion camion = null;                    
                    if(choosenOption == 2)
                    {
                        camion = new CamionCiterne(immatriculation);
                    }
                    else
                    {
                        camion = new CamionBache(immatriculation);
                    }
                    int charge = HelperInput.ReadInt(0, camion.ChargeMax, $"Entrez la charge du camion entre {0} et {camion.ChargeMax}", errorMessage);
                    camion.NouvelleCharge(charge);
                    newVehicule = camion;
                    break;
            }
            convoi.AddVehicule(newVehicule);
        }
    }
}
