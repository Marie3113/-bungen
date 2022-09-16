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
            Console.WriteLine("Bitte gebe eine Zahl ein");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte gebe noch eine Zahl ein");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Was möchtest du mit den Zahlen machen?(+,-,*,/)");
            string opperator = Console.ReadLine();

            double result = 0;

            switch(opperator)
            {
                case "+":
                    result = number + number2;
                    break;  
                    case "-":   
                    result = number - number2;  
                    break;
                case "*":
                    result = number * number2;
                    break;
                case "/":
                    result = number / number2;
                    break;
                    

            }

            Console.WriteLine("Das Erbgenis von " + number + opperator + number2 + "=" + result);


           
            
              

            

            Console.ReadLine();
        }
 
    } 
   
} 
