namespace Emne3_GjettTallet
{
    internal class Program
    {
        public static void getRandomNum()
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int guesses;
            int number;
            string response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Gjett et tall mellom " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Gjett: " + guess);

                    if (guess > number)
                    { 
                        Console.WriteLine(guess + " er for høyt!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " er for lavt!");
                    }
                    guesses++;
                }
                Console.WriteLine("Nummer: " + number);
                Console.WriteLine("DU VANT!");
                Console.WriteLine("Antall ganger gjettet: " + guesses);

                Console.WriteLine("Vil du spille igjen? (Ja/Nei: ");
                response = Console.ReadLine();
                response = response.ToLower();

                if (response == "ja")
                {
                    playAgain = true;
                }
                else 
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Takk for at du spilte. Hade!");
        }
        static void Main(string[] args)
        {
            getRandomNum();
        }
    }
}
