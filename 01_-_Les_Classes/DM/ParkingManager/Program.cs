using System;
using Helper;

namespace ParkingManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int options = -1;
            string optionsMessage = "_______ Choissisez une des options suivantes _______\n";
            optionsMessage += "1 - Park car, 2 - Pick up car, 3 - Display Parks State, 4 - End day";
            string errorMessage = "Bad Options, retry please.\n";

            Parking parking = new Parking(10, 2);
            Clients clients = new Clients();
            int endOptions = 4;
            while (options != endOptions)
            {
                string message = "\n============== PARKING ================\n";
                message += $"Number parks taken {parking.GetSpacesAvailable()} / {parking.GetNbrSpaces()}\n";
                message += $"Number tickets pending {clients.GetNumberTickets()}\n\n";
                message += optionsMessage;
                options = HelperInput.ReadInt(1, endOptions, message, errorMessage);

                if (options == 1)
                {
                    Console.WriteLine("Enter your name please");
                    string nameOwner = Console.ReadLine();
                    Car car = new Car(nameOwner);
                    if (parking.AddCar(car))
                    {
                        Console.WriteLine($"Thanks to park your car {car.OwnerName} !");

                        clients.AddTicket(car);
                    }
                    else
                    {
                        Console.WriteLine("Sorry no space available - try later.");
                    }
                }
                else if (options == 2)
                {
                    Ticket ticket = clients.GetRandomTicket();
                    if (ticket != null)
                    {
                        parking.RemoveCar(ticket.Car);
                        float money = parking.AddMoneyFromTime(ticket.Time);
                        Console.WriteLine($"{ticket.Car.OwnerName}, you have to pay : {money.ToString("00.00")}$");
                        clients.RemoveTicket(ticket);
                    }
                }
                else if (options == 3)
                {
                    parking.DisplayParkingState();
                }
            }

            Console.WriteLine($"It's the end of the day, you won {parking.EarnedMoney.ToString("00.00")}$");
        }
    }
}
