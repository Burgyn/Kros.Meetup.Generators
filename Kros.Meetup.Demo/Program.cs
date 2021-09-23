using System;

namespace Kros.Meetup.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address() { City = "Žilina", Street = "A. Rudnaya" };
            Console.WriteLine("Hello World!");
        }
    }

    public partial class Address
    {
        public string City { get; set; }

        public string Street { get; set; }

        public override string ToString() => $"City = {City}, Street = {Street}";
    }
}
