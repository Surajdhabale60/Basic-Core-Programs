namespace BasicProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Core Program.");
            while(true)
            {
                Console.WriteLine("Select Option\n 1.FlipCoin");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        BasicProgramMain main = new BasicProgramMain();
                        main.FlipCoin();
                        break;

                }
            }
        }
    }
}