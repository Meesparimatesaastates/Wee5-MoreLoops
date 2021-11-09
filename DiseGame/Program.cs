using System;

namespace DiseGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad vikavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem
            //mängjia, kes viskas rohkem, ongi mängu võitja
            //*täringuid visatakse kolm korda
            //programm kuulutab võitja;

                Random rnd = new Random();
                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);
                int cpuScore = 0;
                int userScore = 0;
            for (int i = 0; i < 3; i++)
            {
                userScore = userScore + userRandom;
                cpuScore = cpuScore + cpuRandom;
            }
                Console.WriteLine($"Arvuti viskas {cpuScore}. Kasutaja viskas {userScore}");
                if (cpuScore < userScore)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju Õnne");
                    userScore = userScore + userRandom;
                }
                else if (cpuScore > userScore)
                {
                    Console.WriteLine("Arvuti on mängu võitnud.");
                    cpuScore = cpuScore + cpuRandom;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
            }
        }
    }

