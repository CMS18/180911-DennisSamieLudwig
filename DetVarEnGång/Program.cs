using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetVarEnGång
{
    class Program
    {
        static void Main(string[] args)
        {   // Inmatning av favorit-saker.

            Console.WriteLine("Välkommen!");
            Console.WriteLine("Vad är din favoritfärg?");
            string färg = Console.ReadLine();
            Console.WriteLine("Vad är ditt favoritland?");
            string land = Console.ReadLine();
            Console.WriteLine("Vad är din favoriträtt?");
            string rätt = Console.ReadLine();
            Console.WriteLine("Vad är din favoritsport?");
            string sport = Console.ReadLine();


            // Börja berättelse här.
            Console.WriteLine("Vad är ditt favoritnummer?");
            string nummer = Console.ReadLine();
            

            Console.ReadKey();
        }
    }
}
