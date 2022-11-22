using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public void HarmonicNumber()
        {
            double num = 0;
            Console.WriteLine("Enter the number");
            double value = Convert.ToInt32(Console.ReadLine());
            for (double i = 1; i <= value; i++)
            {
                num += (double)(1 / i);
                Console.WriteLine(" Series is " + num);
            }
        }
        public void SwapTwoNumbers()
        {
            Console.WriteLine("Enter First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After Swap" + "\n" + "First Number Is " + a + "\n" + "Second Number Is " + b);
        }
        public void EvenOdd()
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("Entered Number is even number");
            else
                Console.WriteLine("Entered Number is odd number");
        }
        public void QuotientandReminder()
        {
            Console.WriteLine("Enter Dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = (dividend / divisor);
            int reminder = (dividend % divisor);
            Console.WriteLine("Quotient is  " + quotient);
            Console.WriteLine("Remainder is " + reminder);
        }
        public void VowelConsonant()
        {
            Console.WriteLine("Enter any Alphabet: ");
            char c = Convert.ToChar(Console.ReadLine());

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                Console.WriteLine(c + " is vowel.");

            }
            else
            {
                Console.WriteLine(c + " is consonant.");

            }           
        }
        public void LargestNumber()
        {
            {
                int num1, num2, num3;

                Console.Write("Find the largest of three numbers:");
                Console.Write("\nInput the 1st number :");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the  2nd number :");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the 3rd  number :");
                num3 = Convert.ToInt32(Console.ReadLine());
                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        Console.Write("The 1st Number is the greatest among three.");
                    }
                    else
                    {
                        Console.Write("\nThe 3rd Number is the greatest among three.");
                    }
                }
                else if (num2 > num3)
                    Console.Write("The 2nd Number is the greatest among three.");
                else
                    Console.Write("The 3rd Number is the greatest among three.");
            }
        }
    }
}
