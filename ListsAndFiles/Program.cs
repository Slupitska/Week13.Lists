using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ListsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\slupi\source\repos\Week13.Lists\Data\fruits.txt"; 
            List<string> fileContent = File.ReadAllLines(filePath).ToList(); 
            Console.WriteLine("Original file content:"); 
            DisplayListElements(fileContent);

            //fileContent.Add("yogurt"); //DisplayListElements(fileContent); 
            int indexofTomato = fileContent.IndexOf("tomato"); 
            Console.WriteLine($"Tomato is located at index {indexofTomato}"); 
            fileContent.RemoveAt(indexofTomato);
            Console.WriteLine("Updated list content"); 
            DisplayListElements(fileContent);
            File.WriteAllLines(filePath, fileContent);
        }
        public static void DisplayListElements(List<string> somelist)
        {
            foreach (string elements in somelist) { Console.WriteLine(elements); }
        }
    }
}