using List;
using System;
using System.Runtime.ConstrainedExecution;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store()
            { Name = "GPP", Number = 249638, Email = "gpp@net.hr"};

            store.Address = new Address
            { City = "Osijek", Street = "Kapucinska 12", Zip = 31000 };

            Console.WriteLine("Information about store: \nName:"+store.Name + "\nNumber: " +
                store.Number + "\nE-mail: " + store.Email + "\nCity: " + store.Address.City +
                "\nStreet: " + store.Address.Street + "\nZip: " + store.Address.Zip);


            List<Buyer> listOfBuyer = new List<Buyer>();

            var escapeKey = "1";
            do
            {
                Buyer buyer = new Buyer();

                Console.WriteLine("Enter buyer first name: ");
                buyer.FirstName = Console.ReadLine().Trim();    //ukloni sve bijele znakove s početka i kraja unosa
                while (buyer.FirstName == "")
                {
                    Console.WriteLine("Invalid input. Please enter a vale for the first name: ");
                    buyer.FirstName = Console.ReadLine().Trim();
                }

                Console.WriteLine("Enter buyer last name: ");
                buyer.LastName = Console.ReadLine().Trim();
                while (buyer.LastName == "")
                {
                    Console.WriteLine("Invalid input. Please enter a vale for the last name: ");
                    buyer.LastName = Console.ReadLine().Trim();
                }

                Console.WriteLine("Enter buyer age(1-100): ");
                buyer.Age = Int32.Parse(Console.ReadLine());

                while (buyer.Age < 1 || buyer.Age > 100)
                {
                    Console.WriteLine("Invalid number, plz try again(1-100): ");
                    buyer.Age = Int32.Parse(Console.ReadLine());
                    
                }

                Console.WriteLine("Ticket types:\nRegular\nDiscount\npensioner" +
                "\nEnter your tipe of ticket ");
                
                while(true)
                {
                    buyer.Ticket = Console.ReadLine().ToLower();
                    if (buyer.Ticket == "regular" || buyer.Ticket == "discount" || buyer.Ticket == "pensioner")
                    {
                        break;
                    }
                    Console.WriteLine("Input invalid, plz enter Regular, Discount or Pensioner");

                }
                listOfBuyer.Add(buyer);

                Console.WriteLine("To finish, press 1, to contunie press any key");
                escapeKey = Console.ReadLine();
            } while (escapeKey != "1");

            Console.WriteLine("Number of people in the list: " + listOfBuyer.Count);

            foreach (Buyer buyer in listOfBuyer)
            {
                Console.WriteLine("\nBuyer first name: " + buyer.FirstName);
                Console.WriteLine("\nBuyer last name: " + buyer.LastName);
                Console.WriteLine("\nBuyer age: " + buyer.Age);
                Console.WriteLine("\nBuyer ticket: " + buyer.Ticket);
            }



        }
    }
}
