using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm asendab koik 'o' tahed lauses "Hello World" tarniga (*)

            string helloW = "Hello World!";

            //for(int i = 0; i < helloW.Length; i++)

            // helloW[i] = '*'; //sonad on muutumatud



            helloW = helloW.Replace('o', '*');
            helloW = helloW.Replace('!', '1');
            Console.WriteLine(helloW);
        }

    }
}
