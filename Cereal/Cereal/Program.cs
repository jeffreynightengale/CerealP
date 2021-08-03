using System;
using System.Collections.Generic;
using System.IO;

namespace Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Cereal_Data.txt");
            List<Cereal> cereals = new List<Cereal>();
            

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split('|');
                Cereal bowls = new Cereal();
                bowls.Name = pieces[0];
                bowls.Manufacturer = pieces[1];
                bowls.Calories = Convert.ToDouble(pieces[2]);
                bowls.Cups = Convert.ToDouble(pieces[3]);

                cereals.Add(bowls);
            }

            foreach (Cereal cereal in cereals)
            {
                if (cereal.Cups <= 1)
                {
                    Console.WriteLine($"{cereal.Name} has a serving size of less than 1 cup and equals {cereal.Cups.ToString("N2")} cups per serving.");
                }
            }

            foreach (Cereal cereal in cereals)
            {
                if (cereal.Calories <= 100)
                {
                    Console.WriteLine($"{cereal.Name} has a serving size less than 100 calories and equals {cereal.Calories.ToString("N2")} calories per serving.");
                }
            }
        }
    }
}
