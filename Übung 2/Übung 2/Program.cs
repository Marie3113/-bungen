using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_2
{
    internal class Program
    {
        private static List<string> name;

        static void Main(string[] args)
        { 
            //Aufgabe 2
            List<int> numbers = new List<int> { 5, 3, 7 };
            //Aufgabe 3
            string input; 
            do
            {
                input = Console.ReadLine();
                if (input != "")
                {
                    Console.WriteLine("Gebe eine Zahl ein");
                    numbers.Add(Convert.ToInt32(input));
                }


            }
            while (input != "");

            //Aufgabe 4
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            
            //Aufgabe 5
            numbers.Insert(1, 99);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //Aufgabe 6

            List<int> numbers2 = new List<int> { 91, 92, 93 };
            numbers.AddRange(numbers2);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //Aufgabe 7

            numbers.RemoveAt(0);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //Aufgabe 8 
            numbers.Remove(99);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //Aufgabe 9
            numbers.RemoveAt(numbers.Count -1);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //Aufgabe 10
            numbers.Sort(89);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            numbers.Reverse(89);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            numbers.Remove(<80);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

        }
        
    }
        
    
      

}


        
