using System;

namespace GamblingSimulation
{
    class GamblingMain
    {
        //Variables
        public const int STAKE = 100;
        public const int BET = 1;
        public static int updatedStake = STAKE;

        public static void Bet()
        {
            Random random = new Random();
            int randomChoice = random.Next(2);
            if (randomChoice == 1)
            {
                updatedStake += BET;
                Console.WriteLine("Gambler won 1$ ");
            }
            else
            {
                updatedStake -= BET;
                Console.WriteLine("Gambler lost 1$");
            }
        }

        public static void CalculativeGambler()
        {
            int i = 2000;
            while (i > 0)
            {
                Bet();
                Console.WriteLine(updatedStake);
                if (updatedStake == STAKE / 2 || (updatedStake == STAKE + STAKE / 2))
                {
                    break;
                }
                i--;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambling Simulation Problem");
            GamblingMain gambling = new GamblingMain();
            Bet();
            CalculativeGambler();
        }
    }
}
