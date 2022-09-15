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
            Console.WriteLine("Bitte gebe einen Buchstaben ein");
           string entry = Console.ReadLine();
            List<string> list = new List<string>();
            list.Add("Mona");
            list.Add("Marie");
            list.Add("Erwin");
            list.Add("Philipp");
            list.Add("Hannes");
            list.Add("Leon");
            list.Add("Jonas");
            list.Add("Robert");
            list.Add("Andreas");
            list.Add("Robin");
            list.Add("Marcello");
            list.Add("Lukas");
            for(int i = 0; i < list.Count; i++) 

            {
                if (list[i].Contains(entry));
                Console.WriteLine(list[i]);
            }
                   

            

            Console.ReadLine(); 
        } 
    }
}
