using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Einträge möchtest du in deinem Array? ");
           int entries_count = Convert.ToInt32(Console.ReadLine());
           int[] entry_array = new int[entries_count];


            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);

            }
               




            Console.ReadLine(); 
        } 
    }
}
