using System;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.atm_dispenser
{
    class AtmDispenserMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to XYZ atm");
            AtmDispenserLogic atm = new AtmDispenserLogic();
            Console.WriteLine("Scenario A -> Given ₹1, ₹2, ₹5, ₹10, ₹20, ₹50, ₹100, ₹200, ₹500 notes, find optimal.");
            atm.StartA();
            Console.WriteLine("Scenario B -> Remove ₹500 temporarily and update strategy.");
            atm.StartB();
            Console.WriteLine("Scenario C -> Display fallback combo if exact change isn’t possible.");
            atm.StartC();
        }
    }
}
