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
            Console.WriteLine("Bitte gebe einen Namen ein");
            string name = Console.ReadLine();
            int anzahl = 0;

            if(name == "")
            {
                Console.WriteLine(" Hast du keinen Namen");
                name= Console.ReadLine();   
            }

            for(int i = 0; i < name.Length; i++)
            {
                anzahl = name.Count(c => c == 'a');

            }
          
            Console.WriteLine("Anzahl 'a' im Namen" + anzahl);
           

            Console.ReadLine();
        }
 
    } 
   
} 
