using System;

namespace AI_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,my name is Szakacsi Ferenc-Adam");
            Console.WriteLine("This programme will make the computer guess the random number you chose");
            int min = 0;    
            int max = 100000;    
            int middle = 50000;  
            int counter = 1;
            string name, input;
            int guess_number;
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Welcome to the game " + name + ",guess a number between " + min + " and " + max + " please!");
            Console.WriteLine("Is your guess " + middle + " ?\nIf it's your guess then write (0) please!\nIf it's too high then write (1) please!\nIf it's too low then write (2) please!");
            input = Console.ReadLine();
            guess_number = Convert.ToInt32(input);
            Console.WriteLine(" You select " + guess_number + " so, ");
            if (guess_number == 0)
            {
                Console.WriteLine("I won on first try!");
                return;
            }
            do
            {
                counter += 1;
                if (guess_number == 2)
                {
                    min = middle + 1;
                }
                else if (guess_number == 1)
                {
                    max = middle - 1;
                }
                else if (guess_number != 1 || guess_number != 2 || guess_number != 0)
                {
                    Console.WriteLine(" Please write 0, 1 or 2 " + name);
                }
                middle = (min + max) / 2;
                Console.WriteLine("Is your guess " + middle + " ?\nIf it's your guess then write (0) please!\nIf it's too high then write (1) please!\nIf it's too low then write (2) please!");

                input = Console.ReadLine();
                guess_number = Convert.ToInt32(input);
            } while (guess_number != 0);Console.WriteLine(counter + " tries were needed to find your number ");
        }
    }
}
