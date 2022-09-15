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
            Random r = new Random();
            int random_zahl = r.Next(0, 100);
            int entry = 0;

            do
            {
                entry = Convert.ToInt32(Console.ReadLine());
                if (random_zahl < entry)
                    Console.WriteLine("Eingegebene Zahl ist größer");
                else if (random_zahl > entry)
                    Console.WriteLine("Eingegebene Zahl ist kleiner");
                
            }
            while (random_zahl != entry);
            Console.ReadLine();
        
        } 
    }
}
