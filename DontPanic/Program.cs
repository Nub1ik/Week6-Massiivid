using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab koik 'o' tahed 0iga
            //programm asendab koik 'a' tahed samas lauses '4'

            string dontP = "Dont Panic!";

            dontP = dontP.Replace('o', '0');
            dontP = dontP.Replace('a', '4');

            Console.WriteLine(dontP);
        }
    }
}
