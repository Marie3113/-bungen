﻿using System;
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
            Console.WriteLine("Bitte gib einen Text ein");

            string entry = Console.ReadLine();

            int count = entry.Length;
 
            
            Console.WriteLine("Die Länge deines Textes ist:" + count);
          
            Console.ReadLine(); 
        } 
    }
}
