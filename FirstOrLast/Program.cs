using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutaja sisestada ees ja perekonna nime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem, kas ees voi perekonnanimi

            Console.WriteLine("Palun sisesta enda eesnimi");
            string firstName = Console.ReadLine();
            Console.WriteLine("Palun sisesta enda perekonnanimi");
            string lastName = Console.ReadLine();

            if(firstName.Length < lastName.Length)
            {
                Console.WriteLine("Sinu perekonnanimes on rohkem sümboleid");
            }
            else
            {
                Console.WriteLine("sinu eesnimes on rohkem sümboleid");
            }

            Console.WriteLine("Ilusat päeva");
        }
    }
}
