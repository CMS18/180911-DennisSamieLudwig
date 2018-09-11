using System;

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
            Console.WriteLine("Vad är ditt favoritnummer?");
            string nummer = Console.ReadLine();

            // Börja berättelse här.


            Console.WriteLine("Det var en " + färg + " hund från " + land + " som älskade " + rätt +
                " & han älskade att kolla på " + sport + ". Han hade " + nummer + " jobbiga ungar.");



            Console.ReadKey();
        }
    }
}
