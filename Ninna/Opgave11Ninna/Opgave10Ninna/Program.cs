namespace Opgave10Ninna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Titel og menu til måned-programmet;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Info om årets måneder");
            Console.WriteLine("----------------------------");
            Console.WriteLine("\n|Menu|");
            Console.WriteLine("-----");
            Console.WriteLine("1. Januar");
            Console.WriteLine("2. Februar");
            Console.WriteLine("3. Marts");
            Console.WriteLine("4. April");
            Console.WriteLine("5. Maj");
            Console.WriteLine("6. Juni");
            Console.WriteLine("7. Juli");
            Console.WriteLine("8. August");
            Console.WriteLine("9. September");
            Console.WriteLine("10. Oktober");
            Console.WriteLine("11. November");
            Console.WriteLine("12. December");
            Console.WriteLine("13. Afslut");

            //Bruger input 
            bool RunProgram = false;
            while (!RunProgram)
            {
                Console.WriteLine("\nIndtast et tal fra menuen her og læs om den valgte måned: ");
                double valg = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");

                //Output
                switch (valg)
                {
                    case 1:
                        Console.WriteLine("Januar: Årets første måned, ofte kold og med sne i mange lande. Navnet kommer fra den romerske gud Janus, der havde to ansigter – et der så fremad, og et der så tilbage.");
                        break;
                    case 2:
                        Console.WriteLine("Februar: Den korteste måned, kendt for fastelavn og valentinsdag. Navnet kommer fra det latinske ord \"februa\", der betyder renselse."); 
                        break;
                    case 3:
                        Console.WriteLine("Marts: Forårets komme begynder så småt. Navnet kommer fra den romerske krigsgud Mars.");
                        break;
                    case 4:
                        Console.WriteLine("April: Kendt for påske og for at være en måned med omskifteligt vejr. Navnet kommer fra det latinske ord \"aperire\", der betyder at åbne (blomsterne springer ud).");
                        break;
                    case 5:
                        Console.WriteLine("Maj: Foråret er i fuld gang, og naturen blomstrer. Navnet kommer fra den romerske gudinde Maia.");
                        break;
                    case 6:
                        Console.WriteLine("Juni: Sommerens begyndelse, ofte med varmt vejr og lange dage. Navnet kommer fra den romerske gudinde Juno.");
                        break;
                    case 7:
                        Console.WriteLine("Juli: Højsommer, mange holder ferie. Navnet kommer fra Julius Cæsar.");
                        break;
                        case 8:
                        Console.WriteLine("August: Stadig sommer, men dagene begynder at blive kortere. Navnet kommer fra kejser Augustus.");
                        break;
                        case 9:
                        Console.WriteLine("September: Efterårets begyndelse, bladene begynder at skifte farve. Navnet kommer fra det latinske ord \"septem\", der betyder syv (september var den syvende måned i den gamle romerske kalender).");
                        break;
                        case 10:
                        Console.WriteLine("Oktober: Efteråret er i fuld gang, og det kan være blæsende og regnfuldt. Navnet kommer fra det latinske ord \"octo\", der betyder otte.");
                        break;
                        case 11:
                        Console.WriteLine("November: En mørk og ofte trist måned, hvor mange tænker på de døde. Navnet kommer fra det latinske ord \"novem\", der betyder ni.");
                        break;
                        case 12:
                        Console.WriteLine("December: Årets sidste måned, kendt for jul og nytår. Navnet kommer fra det latinske ord \"decem\", der betyder ti.");
                        break;
                        case 13:
                        //Afslut
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
