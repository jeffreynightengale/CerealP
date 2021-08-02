using System;
using System.IO;

namespace Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Cereal_Data.txt");
            string findingCups = lines[3];
            string findingCalories = lines[2];

            for (int i = 1; i < findingCups.Length; i++)
            {
                double pieces = findingCups[i];
                if (pieces <= 1)
                {
                    Console.WriteLine(lines);
                }
            }
        }
    }
}
