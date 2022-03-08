using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis kasutajaga juhtub homme (kasutame random klassi)



            string[] predictions = { "win a million", "fall in love", "buy youtube Premium", "join the darkside for cookies" };


            Random rnd = new Random();
            int userNumber = rnd.Next(0, predictions.Length);

            Console.WriteLine($"Today you will {predictions[userNumber]}.");

        }
    }
}
