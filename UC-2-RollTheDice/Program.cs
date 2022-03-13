using System;

namespace UC_2_RollTheDice
{
     public class Program
    {
        static void Main(string[] args)
        {
            
            int player = 1;
            int StartingP = 0;

            Random random = new Random();
            int DiceRoll = random.Next(1, 7);

            Console.WriteLine("No. of Player " + player);

            Console.WriteLine("You got number :" + DiceRoll);
            Console.ReadLine();
        }
    }
    }

