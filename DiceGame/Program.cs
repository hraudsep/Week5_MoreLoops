using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb 2 mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem, on mängu võitja
            //*täringuid visatakse 3 korda
            //programm kuulutab võitja

            Random rnd = new Random();
                                   
            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {

                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");
                if (cpuRandom < userRandom)
                {

                    Console.WriteLine($"Kasutaja on mängu võitnud. Kasutaja punktide arv on {userScore + 1}.");
                    userScore = userScore + 1;

                }

                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine($"Arvuti on mängu võitnud. Arvuti puntide arv on {cpuScore + 1}.");
                    cpuScore = cpuScore + 1;
                }

                else
                {
                    Console.WriteLine("Viik!");
                }

                
            }
            Console.WriteLine("Suurima punktidega arvuga mängija on üldvõitja! Viigi korral proovige uuesti!");
        }
    }
}
