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
           
           Console.WriteLine("Wir holen uns jetzt eine Zahl aus Number()");
           List<string> names= Number();
           foreach (var name in names)
           {
               Console.WriteLine(name);
           }
           Console.ReadLine();
            

             
            


           
            
        }
        static List <string> Number()
        {
            List<string> name = new List<string>();
            name.Add("ABC");

            return name;
        }
    } 
   
} 
