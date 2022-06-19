using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruitSalat = new List<string>();

            fruitSalat.Add("jogurt");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter the ingredient {i + 1}:");
                string userIngredient = Console.ReadLine();
                fruitSalat.Add(userIngredient);

            }

            Console.WriteLine($"Your salat consists of {fruitSalat.Count} ingredients:");
            DisplayIngredients(fruitSalat);

        }

        public static void DisplayIngredients(List<string> someList)
        {
            foreach (string ingredient in someList)
            {
                Console.WriteLine(ingredient);
            }


        }
    }
}