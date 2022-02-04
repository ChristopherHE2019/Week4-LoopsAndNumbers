using System;

namespace GuessingGame3Tries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutaja ol kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //*programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 3;
            Console.WriteLine($"Juhuslik number on {cpuNumber}");

            while (i > 0)
            {
                Console.WriteLine("Sisesta number");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Võitsid mängu.");
                    break;
                }
                else if (i == 1)
                {
                    i--;
                    Console.WriteLine("Arvuti võitis mängu.");
                }
                else
                {
                    i--;
                    Console.WriteLine($"Proovi uuesti. Katseid on alles {i}.");
                }
            }
        }
    }
}
