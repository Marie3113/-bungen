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
            Console.WriteLine("Gebe bitte deinen Namen an");
            string name = Console.ReadLine();

            if(name == "")
            {
                Console.WriteLine("Hast du wirklich keinen Namen");
                name = Console.ReadLine();
            }

            int count = 0;
            for(int i = 0; i < name.Length; i++)
            {
                if (name[i].ToString() == "a")
                { 
                count++;
                }
            }

            Console.WriteLine("In deinem Namen sind " + count + " a ");

            Console.WriteLine("Bitte gebe eine Zahl ein");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte gebe noch eine Zahl ein");
                int number2 = Convert.ToInt32(Console.ReadLine());  
            if(number > number2)
            {
                Console.WriteLine("Nummer 1 ist größer");
            }
            else
            { Console.WriteLine("Nummer 2 ist größer");
            }
            Console.ReadLine();
        }
 
    } 
   
} 
