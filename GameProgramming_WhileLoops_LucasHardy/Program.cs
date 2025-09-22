using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GameProgramming_WhileLoops_LucasHardy
{
    internal class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {

            
            int randomNumber = random.Next(-1, 101);

            
            

            while(true)
            {
                Console.WriteLine("Guess a number from 1-100.");
                Console.WriteLine();
                Console.WriteLine("Press any key to start.");
                
                string myGuess = Console.ReadLine();
                int valueOfGuess = int.Parse(myGuess);

                if (valueOfGuess < randomNumber)
                {
                    Console.WriteLine("Higher");
                    
                    continue;
                }

                else if (valueOfGuess > randomNumber)
                {
                    Console.WriteLine("Lower");
                    continue;
                }

                else if (valueOfGuess == randomNumber)
                {
                    Console.WriteLine("Correct!");
                    break;
                }

                
            }


           


        }
    }
}
