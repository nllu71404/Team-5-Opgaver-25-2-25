namespace gitprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //opgave 1: Deklarer og initialiser variabler af forskellige datatyper (int, float, double, char, string, bool). Udskriv deres værdier til konsollen.
            //person person1 = new person(25, "Alice", 1.75, 70.5, true);
            //Console.WriteLine($"Age: {person1.age}, Height: {person1.height}, Weight {person1.weight}, initial: {person1.initital}, Name: {person1.name}, is Student: {person1.isStudent}");

            //opgave 2: Skriv et program, der konverterer en temperatur fra Celsius til Fahrenheit og omvendt. Brug passende datatyper. tryparse, out

            char choice;
            double Ctemp;
            double Ftemp;
            do
            {
                Console.WriteLine("Converting mellem C og F, tryk C eller F for at angive den tilhørende værdi! (C/F)");
                choice = Console.ReadLine()[0];
                switch (choice)
                {
                    case 'c':
                    case 'C':
                        Console.WriteLine("angiv værdi i C");
                        Ctemp = Convert.ToDouble(Console.ReadLine());
                        Ftemp = Ctemp * (9.0 / 5) + 32;   //skriver 9.0 så programmet opfatter det som en double
                        Console.WriteLine($"{Ctemp}¤C is {Ftemp}¤F");
                        break;
                    case 'f':
                    case 'F':
                        Console.WriteLine("angiv værdi i F");
                        Ftemp = Convert.ToDouble(Console.ReadLine());
                        Ctemp = (Ftemp - 32) * (5.0 / 9);
                        Console.WriteLine($"{Ftemp}¤F is {Ctemp}¤C");
                        break;
                }
            }
            while (true);
            
        }
    }
}
