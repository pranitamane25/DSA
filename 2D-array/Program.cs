using System;

namespace Pranita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Farm myFarm = new Farm();        // Create a farm instance
            myFarm.GenerateClimateData();    // Generate random data
            myFarm.DisplayClimateData();     // Display it on console
        }
    }
}
