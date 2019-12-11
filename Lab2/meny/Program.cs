using System;

namespace meny
{
    class Program
    {
        static void Main(string[] args)
        {
            // Här skapar vi en meny för användaren
            bool visaMeny = true;
            while (visaMeny)
            {
                visaMeny = mainMeny();
            }

        }
        public static bool mainMeny()
        {
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Multiplikationstabell ");
            Console.WriteLine("2. Lite matte");
            Console.WriteLine("3. Random nummer");
            Console.WriteLine("4. Exit");
            Console.Write("\r\nDitt alternativ: ");

            switch (Console.ReadLine())
            {
                case "1":
                    tabell();
                    tillbaka();
                    return false;
                case "2":
                    matte();
                    tillbaka();
                    return false;
                case "3":
                    rng();
                    tillbaka();
                    return false;
                case "4":
                    return false;
                default:
                    return true;

            }
        }
        //här skapar vi multiplikationstabellen    
        static void tabell()
        {
            for (int y = 1; y <= 9; y++)
            {

                Console.WriteLine(y + ":ans tabell ");

                for (int x = 1; x <= 9; x++)
                {
                    Console.WriteLine(y + " x " + x + " = " + y * x);
                }
                Console.WriteLine();
            }

        }
        //Skapar en tillbaka alternativ för användaren
        static void tillbaka()
        {
            Console.WriteLine("Vill du återgå till menyn?(JA/NEJ)");
            string svar = "ja";
            svar = Console.ReadLine();
            svar = svar.ToLower();

            if (svar == "ja")
            {
                mainMeny();
            }
        }
        //
        static void rng()
        {
            int storlek;
            Console.Write("Hur många tal vill du slumpmässa: ");
            storlek = Int32.Parse(Console.ReadLine());
            double[] tal = new double[storlek];

            Random rng = new Random();
            for (int i = 0; i < storlek; i++)
            {
                tal[i] = rng.Next(1, 1000);
                Console.WriteLine(tal[i] + " ");
            }
            Console.Write("Här är dina slumpmässade tal sorterad: ");
            Array.Sort(tal);

            foreach (int value in tal)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");
        }
        static void matte()
        {
            int storlek;

            Console.WriteLine("Hur många tal vill du använda?");
            storlek = Int32.Parse(Console.ReadLine());
            double[] tal = new double[storlek];
            Console.WriteLine("Skriv in dina tal:");
            for (int i = 0; i < tal.Length; i++)
            {
                tal[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("Dina tal är: ");
            for (int i = 0; i < tal.Length; i++)
            {
                Console.Write("{0} ", tal[i]);
            }
            double sum = 0;
            for (int i = 0; i < tal.Length; i++)
            {
                sum += tal[i];
            }
            Console.WriteLine("\nSumman av talen är: {0:##}", sum);
            double medel = 0;
            for (int i = 0; i < tal.Length; i++)
            {
                medel += tal[i] / tal.Length;
            }
            Console.WriteLine("Medelvärdet av talen är: {0:##}", medel);

            double min = tal[0];
            for (int i = 0; i < tal.Length; i++)
            {
                if (tal[i] < min)
                {
                    min = tal[i];
                }
            }
            Console.WriteLine("Minsta värdet av dina tal är: {0}", min);

            double max = tal[0];
            for (int i = 0; i < tal.Length; i++)
            {
                if (tal[i] > max)
                {
                    max = tal[i];
                }
            }
            Console.WriteLine("Största värdet av dina tal är: {0} ", max);


        }
    }
}
