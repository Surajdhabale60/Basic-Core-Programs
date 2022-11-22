using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class BasicProgramMain
    {
        public void FlipCoin()
        {
            int heads = 0;
            int tails = 0;
            int counter = 0;
            Random coinflip = new Random();
            Console.WriteLine("How many times would you like to flip a coin? ");
            counter = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                int flip = coinflip.Next(1, 3);
                if (flip == 1)
                {
                    heads++;
                }
                else
                {
                    tails++; 
                }
            }
            Console.WriteLine("You flipped a coin " + counter
               + " times " + "and you got " + heads + " heads and " + tails + " tails.");            
        }
        public void LeapYear()
        {
            {
                Console.WriteLine("Enter Year: ");
                int Year = int.Parse(Console.ReadLine());

                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                {

                    Console.WriteLine("{0} is Leap Year.", Year);
                }
                else
                {
                    Console.WriteLine("{0} Is not a leap year.", Year);
                }
                Console.ReadLine();
            }
        }
        public void PowerOfTwo()
        {
            Console.WriteLine("Enter as 2^Number:- ");
            string NNumber = Console.ReadLine();
            int number = Convert.ToInt32(NNumber);
            int num = 1;
            int i = 1;                
            int LimitPowerTwo = 31;
            if (number > LimitPowerTwo)
            {
                Console.WriteLine($"You Enter {number}  of 2^ exceeds the value limit 31  ");
            }
            else
            {
                for (i = 1; i <= number; i++) //to Check a number 
                {
                    num = (num * 2); // multiply number by 2
                    Console.WriteLine(num);
                }
            }
        }
    }
}
