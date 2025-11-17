using System;

namespace Pranita
{
    public class Farm
    {
        private const int ROWS = 2;
        private const int COLS = 5;

        private ClimateControl[,] farmData;
        private Random rand = new Random();

        // Constructor 
        public Farm()
        {
            farmData = new ClimateControl[ROWS, COLS];
        }

        // Generates random climate readings for all sensors
        public void GenerateClimateData()
        {
            if (farmData == null)
                farmData = new ClimateControl[ROWS, COLS]; 

            for (int r = 0; r < ROWS; r++)
            {
                for (int c = 0; c < COLS; c++)
                {
                    ClimateControl sensor = new ClimateControl
                    {
                        Temperature = (float)(rand.Next(0, 1500) / 10.0),
                        Humidity = rand.Next(0, 101),
                        LightIntensity = rand.Next(0, 10000),
                        CO2 = rand.Next(300, 2301),
                        SoilMoisture = rand.Next(0, 101)
                    };
                    farmData[r, c] = sensor; // assign the filled struct
                }
            }
        }

        // Displays all data
        public void DisplayClimateData()
        {
            Console.WriteLine(" Transflower Farm Climate Data (Tambade Mala) \n");

            for (int r = 0; r < ROWS; r++)
            {
                for (int c = 0; c < COLS; c++)
                {
                    Console.Write($"[R{r + 1}C{c + 1}] " +
                                  $"T={farmData[r, c].Temperature:F1}°C " +
                                  $"H={farmData[r, c].Humidity:F1}% " +
                                  $"L={(int)farmData[r, c].LightIntensity} Lux " +
                                  $"CO₂={farmData[r, c].CO2:F0}ppm " +
                                  $"SM={farmData[r, c].SoilMoisture:F1}%\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
