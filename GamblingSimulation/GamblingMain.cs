using System;

namespace GamblingSimulation
{
    class GamblingMain
    {
        //Variables
        public const int STAKE = 100;
        public const int BET = 1;
        public static int updatedStake = STAKE;

        public static int Bet()
        {
            Random random = new Random();
            int randomChoice = random.Next(2);
            if (randomChoice == 1)
            {
                Console.WriteLine("Gambler won 1$ ");
            }
            else
            {
                Console.WriteLine("Gambler lost 1$");
            }
            Console.WriteLine(updatedStake);
            return randomChoice;
        }

        public static int CalculativeGambler()
        {
            while ((updatedStake > STAKE / 2) && (updatedStake < (STAKE + STAKE / 2)))
            {
                if (Bet() == 1)
                {
                    updatedStake += BET;
                }
                else
                {
                    updatedStake -= BET;
                }

            }
            Console.WriteLine(updatedStake);
            return updatedStake;
        }

        public static void PlayingFor20Days()
        {
            int amount = 0;
            for (int i = 1; i <= 20; i++)
            {
                amount = amount + CalculativeGambler();
                Console.WriteLine("Day" + i+ "amount : " + amount);
            }
            Console.WriteLine("Total amount  :" + amount);
            if (amount < 0)
            {
                Console.WriteLine("Loss : " + amount);
            }
            else
            {
                Console.WriteLine("Winning : " + amount);
            }
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambling Simulation Problem");
            GamblingMain gambling = new GamblingMain();
            Bet();
            CalculativeGambler();
            PlayingFor20Days();
        }
    }
}
