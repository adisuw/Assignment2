using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace Assignment2
{
    /// <summary>
    /// This class computes and prints the ticket values
    /// it holds the list of Tickets according to the user input
    /// </summary>
    class PrintTickets
    {
        private readonly List<Ticket> _tickets;

        public PrintTickets()
        {
            _tickets = new List<Ticket>();
        }
        /// <summary>
        /// prints a ticket accordingly
        /// </summary>
        /// <param name="single"></param>
        public void IssueTicket(bool single)
        {
            
            var price = 0.0;
            if (single)
            {
                var singleTicket = new Ticket(UserInputReader.ReadInteger("\tEnter your age: "));
                price = ComputePrice(singleTicket);
                Console.WriteLine($"\tTicket Price: {price}\n\tTicket Id: {singleTicket.TicketId}"); 
            }
            else
            {
                price = ComputePrice(_tickets);
                Console.WriteLine($"\tNumber of people: {_tickets.Count} \n\tTotal Ticket Price: {price}");
               
            }

        }
        /// <summary>
        /// gets the price for a single Ticket object
        /// </summary>
        /// <param name="singleTicket"></param>
        /// <returns></returns>
        private double ComputePrice(Ticket singleTicket)
        {
            return singleTicket.Price;
        }
        /// <summary>
        /// I used the elegant property of C# language here, which is summing all
        ///the prices that are available in the list.
        /// </summary>
        /// <param name="mulTickets"></param>
        /// <returns></returns>
        private double ComputePrice(IEnumerable<Ticket> mulTickets)
        {
            AddUsersAge();
            return  mulTickets.Sum(ticket => ticket.Price);
        }

        /// <summary>
        /// The user decided how many number of Tickets are required 
        /// </summary>
        private void AddUsersAge()
        {
            var n = UserInputReader.ReadInteger("\tEnter the number of people: ");
            for (var i = 0; i < n; i++) _tickets.Add(new Ticket(UserInputReader.ReadInteger($"\t{i + 1}. Enter age: ")));
        }
    }
}
