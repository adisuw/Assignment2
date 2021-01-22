using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Ticket
    {
        private static int _ticketId = 0;
        private double _price;
        public Ticket(int age)
        {
            Age = age;
        }

        public int Age
        {
            set
            {
                if (value >= 5 && value < 20)
                {
                    _price = 80;
                }
                else if (value > 64 && value <= 100)
                {
                    _price = 90;
                }
                else if (value < 5 || value > 100)
                {
                    _price = 0.0;
                }
                else
                {
                    _price = 120;
                }

                _ticketId += 1;
            }
        }

        public double Price => _price;
        public int TicketId => _ticketId;
    }
}
