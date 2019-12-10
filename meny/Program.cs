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
        public static bool mainMeny ()
        {
            Console.Clear();
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Multiplikationstabell ");
            Console.WriteLine("2. Lite matte");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("5. exit");
            Console.Write("\r\nDitt alternativ: ");

            switch (Console.ReadLine()){
                case "1":
                    tabell();
                    return false;
                case "2":
                    matte();
                    return false;
                case "3":
                    return true;
                case "4":
                    return true;
                case "5":
                    return false;        
                default:
                return true;

            }
        }
        static void tabell (){
            for (int y = 1; y <=9; y++){

                Console.WriteLine(y +":ans tabell");
                
                for (int x = 1; x <=9; x++){
                    Console.WriteLine(y + " x " + x + " = " + y*x);
                }
                Console.WriteLine();
            }

        }
        public void tillbaka() {
        Console.WriteLine("Vill du återgå till menyn? Programmet kommer avslutas om du svarar nej. (JA/NEJ)");
            string svar = "ja";
            svar = Console.ReadLine();
            svar = svar.ToLower();

            if(svar == "ja")
            {
                mainMeny();
            }
     }
        static void matte(){
            int storlek;

            Console.WriteLine("Hur många tal vill du använda?");
            storlek = Int32.Parse(Console.ReadLine());
            double[] tal = new double[storlek];
            Console.WriteLine("Skriv in dina tal:");
            for ( int i=0;i<tal.Length;i++){
                tal[i]=double.Parse(Console.ReadLine());
            }
            Console.Write("Dina tal är: ");
            for(int i=0;i<tal.Length;i++){
                Console.Write("{0} ", tal[i]);
            }
            double sum = 0;
            for (int i =0; i<tal.Length;i++){
                sum +=tal[i];
            }
            Console.WriteLine("\nSumman av talen är: {0:##}", sum);
            double medel = 0;
            for(int i=0;i<tal.Length;i++){
                medel+=tal[i]/tal.Length;
            }
            Console.WriteLine("Medelvärdet av talen är: {0:##}", medel);

            double min = tal[0];
            for(int i=0;i<tal.Length;i++)
            {
                if(tal[i] < min)
                {
                    min = tal[i];
                }
            }
            Console.WriteLine("Minsta värdet av dina tal är: "+min);

            double max = tal[0];
            for(int i=0;i<tal.Length;i++)
            {
                if(tal[i] > max)
                {
                    max = tal[i];
                }
            }
            Console.WriteLine("Största värdet av dina tal är: {0} ", max);
        
            
        }
    }
}
