using System;

namespace GamblingSimulation
{
    class GamblingMain
    {
        //Variables
        public const int STAKE = 100;
        public const int BET = 1;

        public void Bet()
        {
            Random random = new Random();
            int choice = random.Next(0, 1);
            if (choice == 1)
            {
                Console.WriteLine("Gambler won 1$ ");
            }
            else
            {
                Console.WriteLine("Gambler lost 1$");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambling Simulation Problem");
            GamblingMain gambling = new GamblingMain();
            gambling.Bet();
        }
    }
}
