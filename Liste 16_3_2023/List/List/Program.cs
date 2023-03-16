using List;
using System;
using System.Runtime.ConstrainedExecution;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kupac> listOfKupac = new List<Kupac>();

            var escapeKey = "1";
            do
            {
                Kupac kupac = new Kupac();
                Console.WriteLine("Enter buyer first name: ");
                kupac.FirstName = Console.ReadLine();

                Console.WriteLine("Enter buyer last name: ");
                kupac.LastName = Console.ReadLine();

                Console.WriteLine("Enter buyer age(1-100): ");
                int age;
                while (!Int32.TryParse(Console.ReadLine(), out age) || age < 1 || age > 100)
                {
                    Console.WriteLine("Invalid number, plz try again(1-100): ");
                }

                Console.WriteLine("Ticket types:\nr->Regular\nd->Discount for children\np->pensioner" +
                "\nEnter your tipe of ticket ");
                string ticket;
                while(true)
                {
                    ticket = Console.ReadLine().ToLower();

                    if(ticket == "r" || ticket == "d" || ticket == "p")
                    {
                        break;
                    }
                    Console.WriteLine("Input invalid, plz enter r for Regular," +
                        "d for Discount for children or p for Pensioner");
                }
                listOfKupac.Add(kupac);

                Console.WriteLine("To finish, press 1, to contunie press any key");
                escapeKey = Console.ReadLine();
            } while (escapeKey != "1");


        }            
    }
}
