using System;

namespace Kros.Meetup.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address() { City = "Žilina", Street = "Kvačalová" };
            Console.WriteLine("Hello World!");
        }
    }

    [ToString]
    public partial class Address
    {
        public string City { get; set; }

        public string Street { get; set; }

        //public string ZipCode { get; set; }

        //public string Country { get; set; }
    }
}
