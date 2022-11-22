namespace BasicProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Core Program.");
            
            while(true)
            {
                Console.WriteLine("Select Option\n 1.Flip Coin\n 2.Leap Year\n 3.Power Of Two\n 4.Harmonic Number\n 5.Quotient And Reminder\n 6.Swap Two Numbers");
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
                }
            }
        }
    }
}
