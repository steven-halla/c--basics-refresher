using System;

namespace practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRings = 5;
            if(numRings >= 5)
            {
                Console.WriteLine("you are here to join us");
                
            }
            else if (numRings >2)
            {
                Console.WriteLine($"Decenet...but {numRings} rings arnt enough");
            }
            else
            {
                Console.WriteLine("go win more rings");
            }
        }
    }
}
