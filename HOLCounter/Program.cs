using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis mitu 'h', 'o' ja 'l' tahte on lauses "hello World!"
            string HelloWorld = "Hello World!";
            string helloWorld = $"{HelloWorld!}".ToLower();

            Console.WriteLine("Hello World!");

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'h')
                {
                    hCounter++;
                }
                if (helloWorld[i] == 'o')
                {
                    oCounter++;
                }
                if (helloWorld[i] == 'l')
                {
                    lCounter++;
                }
            }

            if (hCounter != 1)
            {
                Console.WriteLine($"Selles lauses on {hCounter} 'h' tähte. ");
            }
            else if (hCounter >= 1)
            {
                Console.WriteLine($"Selles lauses on {hCounter} 'h' täht. ");
            }
            if (oCounter != 1)
            {
                Console.WriteLine($"Selles lauses on {oCounter} 'o' tähte. ");
            }
            else if (oCounter >= 1)
            {
                Console.WriteLine($"Selles lauses on {oCounter} 'o' täht. ");
            }
            if (lCounter != 1)
            {
                Console.WriteLine($"Selles lauses on {lCounter} 'l' tähte. ");
            }
            else if (lCounter >= 1)
            {
                Console.WriteLine($"Selles lauses on {lCounter} 'l' täht. ");
            }

        }
    }
}
