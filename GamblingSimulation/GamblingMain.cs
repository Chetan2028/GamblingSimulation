using System;

namespace GamblingSimulation
{
    class GamblingMain
    {
        //Variables
        public const int STAKE = 100;
        public const int BET = 1;
        public static int updatedStake = STAKE;
        static int wins = 0;
        static int loss = 0;

        public static int Bet()
        {
            Random random = new Random();
            int randomChoice = random.Next(0,2);
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
                    wins++;
                    updatedStake += BET;
                }
                else
                {
                    loss++;
                    updatedStake -= BET;
                }

            }
            Console.WriteLine(updatedStake);
            return updatedStake;
        }

        //UC4And UC5
        public static void PlayingFor20Days()
        {
            int amount = 0;
            int[] arr = new int[20];
            for (int i = 0; i < 20; i++)
            {
                int dayAmount = CalculativeGambler();
                amount = amount + dayAmount;
                arr[i] = amount;
                Console.WriteLine("Day" + i+ "amount : " + amount);
                Console.WriteLine("Total Amount Difference: " + (amount-dayAmount));
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Day " +i + "amount is : " + arr[i]);
            }
            Console.WriteLine("Total amount  :" + amount);
            Console.WriteLine("Total wins : " + wins);
            Console.WriteLine("Total loss : " + loss);
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambling Simulation Problem");
            GamblingMain gambling = new GamblingMain();
            //Bet();
            //CalculativeGambler();
            PlayingFor20Days();
        }
    }
}
