using System;
// namespace is used to organize your code, and it is a container for classes and other namespaces
namespace practise
{
    //class is a container for data and methods, which brings functionaility to our program.
    class Program
    {
        //Main is a method 

        //highlight lines, then command key + / to comment out multiple lines
    
        static void Main(string[] args)
        {   
            //variables are containers for storing values 
            //int is the type, numRings is the variable name, 5 is the value of numRings
            //if you assign a new value to an existing variable, it will overwrite previous value
            //The const keyword wont let us overwrite existing values
             int numRings = 5;
            numRings=3;
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
