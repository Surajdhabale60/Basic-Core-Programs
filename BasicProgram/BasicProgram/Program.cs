namespace BasicProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Core Program.");
            
            while(true)
            {
                Console.WriteLine("Select Option\n 1.Flip Coin\n 2.Leap Year\n 3.Power Of Two\n 4.Harmonic Number\n 5.Swap Two Numbers\n 6.Even Or Odd\n 7.Quotient and Reminder\n 8. Vowels and Consonant\n 9.Largest Three Number");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        BasicProgramMain main = new BasicProgramMain();
                        main.FlipCoin();
                        break;
                    case 2:
                        BasicProgramMain main1 = new BasicProgramMain();
                        main1.LeapYear();
                        break;
                    case 3:
                        BasicProgramMain main2 = new BasicProgramMain();
                        main2.PowerOfTwo();
                        break;
                    case 4:
                        BasicProgramMain main3 = new BasicProgramMain();
                        main3.HarmonicNumber();
                        break;
                    case 5:
                        BasicProgramMain main5 = new BasicProgramMain();
                        main5.SwapTwoNumbers();
                        break;
                    case 6:
                        BasicProgramMain main6 = new BasicProgramMain();
                        main6.EvenOdd();
                        break;
                   case 7:
                        BasicProgramMain main7 = new BasicProgramMain();
                        main7.QuotientandReminder();
                        break;
                   case 8:
                        BasicProgramMain main8 = new BasicProgramMain();
                        main8.VowelConsonant();
                        break;
                    case 9:
                        BasicProgramMain main9 = new BasicProgramMain();
                        main9.LargestNumber();
                        break;
                }
            }
        }
    }
}
