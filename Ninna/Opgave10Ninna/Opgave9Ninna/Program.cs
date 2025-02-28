namespace Opgave9Ninna
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            
                //Titel og menu til ugedag-programmet;
                Console.WriteLine("----------------------------");
                Console.WriteLine("Hvilken ugedag er det i dag?");
                Console.WriteLine("----------------------------");
                Console.WriteLine("\n|Menu|");
                Console.WriteLine("-----");
                Console.WriteLine("1. Mandag");
                Console.WriteLine("2. Tirsdag");
                Console.WriteLine("3. Onsdag");
                Console.WriteLine("4. Torsdag");
                Console.WriteLine("5. Fredag");
                Console.WriteLine("6. Lørdag");
                Console.WriteLine("7. Søndag");

                //Bruger input 
                bool RunProgram = false;
                while (!RunProgram)
            { 
                    Console.WriteLine("\nIndtast et tal fra menuen her: ");
                double valg = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");

                //Output
                switch (valg)
                {
                    case 1:
                        Console.WriteLine("Det er mandag i dag!");
                        RunProgram = true;
                        break;
                    case 2:
                        Console.WriteLine("Det er tirsdag i dag!");
                        RunProgram = true;
                        break;
                        case 3:
                        Console.WriteLine("Det er onsdag i dag!");
                        RunProgram = true;
                        break;
                        case 4:
                        Console.WriteLine("Det er torsdag i dag!");
                        RunProgram = true;
                        break;
                        case 5:
                        Console.WriteLine("Det er fredag i dag!");
                        RunProgram = true;
                        break;
                        case 6:
                        Console.WriteLine("Det er lørdag i dag!");
                        RunProgram = true;
                        break;
                        case 7:
                        Console.WriteLine("Det er søndag i dag!");
                        RunProgram = true;
                        break;
                    default:
                        Console.WriteLine("Du har ikke indtastet et gyldigt tal. Prøv igen!");
                        break;

                        
                }
                Console.ReadLine();
            }
        }
    }
}
