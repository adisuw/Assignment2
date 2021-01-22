using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    /// <summary>
    /// The Ticket object is supposed to hold the user age, the price and its id
    /// sets the _price based on the age it gets
    /// </summary>
    class Ticket
    {
        private static int _ticketId = 0;
        private double _price;
        public Ticket(int age)
        {
            Age = age;
        }

        /// <summary>
        /// performs some validations and assigns a static value to the price field.
        /// </summary>
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
    
        //Only returns the price we do not need to set the price at it is constant
        public double Price => _price;

        //This field is added for the dome purpose.
        public int TicketId => _ticketId;
    }
}
