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
            //5 Werte speichern
            int[] zahlen = new int[5];

            //[26 / 8 / 12 / 3 / 6] zahlen2 -> 2er Reihen
            int[] zahlen2 = new int[] { 26, 8, 12, 3, 6 };

            Console.Write("[ ");
            for(int i = 0; i< zahlen.Length; i++)
            {
               Console.Write($" {zahlen[i]}");   
            }
            Console.ReadLine();
        
        } 
    }
}
