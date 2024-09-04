using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vehicle 
    {

        public string Name { get; set; }
        public int Fuel { get; set; }

        public Vehicle(string name, int fuel)
        {
            Name = name;
            Fuel = fuel;
        }

        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine($"{Name} is driving.");
                Fuel-= 10;
                Console.WriteLine($"Fuel left: {Fuel}");
            }
            else
            {
                Console.WriteLine($"{Name} has no fuel.");
            }

            if(Fuel < 0)
            {
                Console.WriteLine($"You cannot drive on {Name} anymore its have not fuel, you must refuel car");
            }
        }

        public void Refuel(int amount)
        {
            Fuel += amount;
            Console.WriteLine($"Refueled {Name} with {amount} units of fuel.");
            Console.WriteLine($"Fuel left: {Fuel}");

            if (amount > 100)
            {
                Console.WriteLine($"You cannot refuel {Name} with this amount of fuel.");
                return;
            }
        }

    }
}
