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

            Console.WriteLine("Gebe mir eine Zahl");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte gebe noch eine Zahl ein");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            int ergebnis = Add(zahl1, zahl2);
            Console.WriteLine(ergebnis);
            Console.ReadLine();

            
        }
        static int Add(int z1, int z2)
        {
            int summe = z1 * z2;
            return summe;
            Console.WriteLine("Das Erbgenis von " + z1 + z2 + "=" + summe);

        }
    }
    
} 
