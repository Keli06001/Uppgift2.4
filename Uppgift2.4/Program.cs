using System;

namespace Uppgift2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in lön 1");
            string ettText = Console.ReadLine();
            int ett = int.Parse(ettText);
            Console.WriteLine("Skriv in lön 2");
            string tvåText= Console.ReadLine();
            int två=int.Parse(tvåText);
            Console.WriteLine("Skriv in lön 3");
            string treText = Console.ReadLine();
            int tre = int.Parse(treText);
            int medel = (ett + två + tre) / 3;
            Console.WriteLine("Medel lönen är "+medel + "kr");
        }
    }
}
