using strategypattern.Ctr;
using System;

namespace strategypattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What food would you like to cook?");
           
            var food = Console.ReadLine();

            CookingMethod cookMethod = new CookingMethod();
            cookMethod.SetFood(food);

            Storages storage = new Storages();

            Console.WriteLine("What cooking strategy would you like to use (1-3)?");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch (input)
            {
                case 1:
                    cookMethod.SetCookStrategy(new Grilling());
                    cookMethod.Cook();
                    storage.SetStorageStrategy(new Refrigerator());
                    storage.save();
                    break;

                case 2:
                    cookMethod.SetCookStrategy(new OvenBaking());
                    cookMethod.Cook();
                    storage.SetStorageStrategy(new Frezeser());
                    storage.save();
                    break;

                case 3:
                    cookMethod.SetCookStrategy(new DeepFrying());
                    cookMethod.Cook();
                    break;

                default:
                    Console.WriteLine("Invalid Selection!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
