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
            int zahl = Convert.ToInt16(Console.ReadLine());

            switch(zahl)
            {
                case 1:
                    Console.WriteLine("Die Zahl ist 1");
                        case 2:
                    Console.WriteLine("Die Zahl ist 2");
                case 5:
                    Console.WriteLine("Die Zahl ist 5");
                    break;
                    default:
                    Console.WriteLine("Kein Fall tritt ein");
                    break;

            }

            Console.ReadLine();
        }
 
    } 
   
} 
