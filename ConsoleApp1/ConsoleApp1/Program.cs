using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vehicle car = null;
            List<Vehicle> carList = new List<Vehicle>();

            while (true)
            {
                Console.WriteLine("\n Vehicle Information:");
                Console.WriteLine("1. Register Car");
                Console.WriteLine("2. Show Car");
                Console.WriteLine("3. Drive Car");
                Console.WriteLine("4. Refuel car");
                Console.WriteLine("5. exit");
                Console.Write("write choose: ");

                int makeChoice = int.Parse(Console.ReadLine());

                switch (makeChoice)
                {
                    case 1:
                        Console.WriteLine("\n1. Register Mercedes");
                        Console.WriteLine("2. Register BMW");

                        int choiceBetweenCars = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nEnter Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("\nEnter Fuel:");
                        int fuel = int.Parse(Console.ReadLine());

                        if (choiceBetweenCars == 1)
                        {
                            car = new Vehicle(name, fuel);
                            carList.Add(car);
                        }
                        else if (choiceBetweenCars == 2)
                        {
                            car = new Vehicle(name, fuel);
                            carList.Add(car);
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n Car List:");

                        foreach (var item in carList)
                        {
                            Console.WriteLine($"Name: {item.Name}, Fuel: {item.Fuel}");
                        }

                        break;

                    case 3:
                        Console.WriteLine("\nSelect a car to drive:");

                        for (int i = 0; i < carList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {carList[i].Name}");
                        }

                        int choice = int.Parse(Console.ReadLine());

                        if (choice > 0 && choice <= carList.Count)
                        {
                            carList[choice - 1].Drive();
                        }

                        else
                        {
                            Console.WriteLine("No");
                        }

                        break;

                    case 4:
                        Console.WriteLine("\n Select a car to refuel:");

                        for (int i = 0; i < carList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {carList[i].Name}");
                        }

                        int choiceRefuel = int.Parse(Console.ReadLine());

                        if (choiceRefuel > 0 && choiceRefuel <= carList.Count)
                        {
                            Console.WriteLine("Enter amount to refuel:");
                            int refuelAmount = int.Parse(Console.ReadLine());
                            carList[choiceRefuel - 1].Refuel(refuelAmount);
                        }

                        else
                        {
                            Console.WriteLine("No");
                        }

                        break;

                    case 5:
                        return;


                }
            }


        }
    }
}
