using System;

namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Här skapar vi variabler för namn och ålder för varje person.
            string namnMom;
            string namnDad; 
            string namnBro; 
            string namnSis; 
            int ageMom;
            int ageDad;
            int ageBro;
            int ageSis;

            /*Här vill vi få svar från användaren om 
                deras familjemedlemmar(namn/ålder).
            */ 
            Console.WriteLine("Skriv in din mors namn: ");
                namnMom = Console.ReadLine();
            Console.WriteLine("Skriv åldern på din mor: ");
                ageMom = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in din fars namn: ");
                namnDad = Console.ReadLine();
            Console.WriteLine("Skriv åldern på din far: ");
                ageDad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in din brors namn: ");
                namnBro = Console.ReadLine();
            Console.WriteLine("Skriv åldern på din bror: ");
                ageBro = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in din systers namn: ");
                namnSis = Console.ReadLine();
            Console.WriteLine("Skriv åldern på din syster: ");
                ageSis = Int32.Parse(Console.ReadLine());

            Console.WriteLine(namnMom + " är " + ageMom + " gammal.");
            Console.WriteLine(namnDad + " är " + ageDad + " gammal.");
            Console.WriteLine(namnBro + " är " + ageBro + " gammal.");
            Console.WriteLine(namnSis + " är " + ageSis + " gammal.");

             float summa = ageMom + ageDad + ageBro + ageSis;

            Console.WriteLine("Sammanlagd ålder är: " + summa);
            Console.WriteLine("Medelåldern är: " + summa/4);

            Console.WriteLine(namnMom + " har levt i " + ageMom * 365 + " dagar!");
            Console.WriteLine(namnDad + " har levt i " + ageDad * 365 + " dagar!");
            Console.WriteLine(namnBro + " har levt i " + ageBro * 365 + " dagar!");
            Console.WriteLine(namnSis + " har levt i " + ageSis * 365 + " dagar!");
                       
        }
    }
}
