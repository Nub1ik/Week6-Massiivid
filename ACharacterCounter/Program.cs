using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajalt sisestada ees- ja perekonnanime
            //programm kuvab mitu a tahte on kasutaja ees ja perekonna nimes kokku

            Console.WriteLine("Palun sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName} {lastName}".ToLower();

            Console.WriteLine(fullName);

            int aCounter = 0;

            for(int i = 0; i < fullName.Length; i++)
            {
                if(fullName[i] == 'a')
                {
                    aCounter++;
                }
            }

            if(aCounter != 1)
            {
                Console.WriteLine($"Sinu taisnimes on {aCounter} 'a' tahte. ");
            }
            else
            {
                Console.WriteLine($"Sinu taisnimes on {aCounter} 'a' taht. ");
            }
            
        }
    }
}
