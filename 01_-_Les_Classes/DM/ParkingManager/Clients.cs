using System;

namespace ParkingManager
{
    public class Clients
    {
        private Ticket[] _tickets;

        public int GetNumberTickets()
        {
            return _tickets != null ? _tickets.Length : 0;
        }

        public Ticket GetRandomTicket()
        {
            if (_tickets != null && _tickets.Length > 0)
            {
                Random rand = new Random();
                return _tickets[rand.Next(0, _tickets.Length)];
            }
            else
            {
                Console.WriteLine("No Ticket Available");
                return null;
            }
        }

        public void AddTicket(Car car)
        {
            Ticket ticket = new Ticket(car);
            if (_tickets == null)
            {
                _tickets = new Ticket[1];
                _tickets[0] = ticket;
                return;
            }

            Ticket[] tmpTickets = new Ticket[_tickets.Length + 1];
            for (int i = 0; i < _tickets.Length; i++)
            {
                tmpTickets[i] = _tickets[i];
            }
            tmpTickets[_tickets.Length] = ticket;
            _tickets = tmpTickets;
        }

        public void RemoveTicket(Ticket ticket)
        {
            if (_tickets != null && _tickets.Length > 0)
            {
                int index = -1;
                for (int i = 0; i < _tickets.Length; i++)
                {
                    if (_tickets[i] == ticket)
                    {
                        index = i;
                    }
                }

                if (_tickets.Length > 1)
                {
                    Ticket[] tmpTickets = new Ticket[_tickets.Length - 1];
                    for (int i = 0; i < index; i++)
                    {
                        tmpTickets[i] = _tickets[i];
                    }

                    for (int i = index; i < tmpTickets.Length; i++)
                    {
                        tmpTickets[i] = _tickets[i + 1];
                    }
                    _tickets = tmpTickets;
                }
                else
                {
                    _tickets = null;
                }
            }
            else
            {
                Console.WriteLine("No Ticket Available");
            }
        }
    }
}