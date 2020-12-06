using System;
//
namespace practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRings = 5;
            string name = "kobe";
            if(numRings >= 5 && name == "kobe")
            {
                Console.WriteLine($"Welcome to the party {name}, congratulation on your {numRings} championships!");
                
            }
            else if (numRings >2)
            {
                Console.WriteLine($"Decenet...but {numRings} rings arnt enough");
            }
            else
            {
                Console.WriteLine("go win more rings");
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(5);
            }

            Random rand = new Random();
        }
    }
}
