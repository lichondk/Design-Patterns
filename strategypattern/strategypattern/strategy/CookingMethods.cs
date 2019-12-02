using System;
using System.Collections.Generic;
using System.Text;

namespace strategypattern
{
    class Grilling : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + "by grilling it");
        }

    }

    class OvenBaking : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by ovn baking it.");
        }
    }

    class DeepFrying : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by deep frying it");
        }
    }
}
