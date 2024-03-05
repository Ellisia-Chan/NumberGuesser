using System;

namespace Hello_World 
{
    class Program
    {
        static void Main(string[] args)
        {   
            int attempts = 0;
            Random numGen = new Random();
            int roll = numGen.Next(1, 11);

            while (true) {
                Console.Write("Guess a number [1-10]: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                attempts++;
                if (guess >= 11 || guess <= 0) {
                    Console.WriteLine("Please enter inside the range of [1-10]\n");
                    continue;
                }

                if (guess == roll) {
                    Console.WriteLine("Correct Guess\n");
                    break;
                }
                else if (guess < roll) {
                    Console.WriteLine("Guess higher, try again\n");
                    continue;
                }
                else if (guess > roll) {
                    Console.WriteLine("Guess Lower, try again\n");
                    continue;
                }


            }
            Console.WriteLine("Attempts to guess the number: " + attempts);
            //For Closing
            Console.ReadKey();

        }   
    }
}
