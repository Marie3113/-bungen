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
            List<string> names = new List<string>();

            for(int i = 0; i < 4; i++)    
            {
                Console.WriteLine("Gib einen Namen ein");
                names.Add(Console.ReadLine());

            }

            for(int i = 0; i < names.Count(); i++)
            {
                Console.WriteLine(names[i]);    
            }



            Console.ReadLine();
        }
 
    } 
   
} 
