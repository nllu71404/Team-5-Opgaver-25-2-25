namespace Opgave8Ninna
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            //Titel på karakter-program
            Console.WriteLine("\n---------------------");
            Console.WriteLine("Tjek om du er bestået");
            Console.WriteLine("---------------------");

            //Brugerinput og mulige output - hvis brugeren ikke taster en rigtig karakter ind, genstarter programmet. 
            bool input = false;
            while (!input)
            {
                Console.WriteLine("\nSkriv din karakter her (A, B, C, D eller F): ");
            char karakter = Convert.ToChar(Console.ReadLine());
            karakter = char.ToUpper(karakter);


                switch (karakter)
                {
                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                        Console.WriteLine("\nTillykke, du er bestået!");
                        input = true;
                        break;
                    case 'F':
                        Console.WriteLine("\nØv, du er desværre ikke bestået!");
                        input = true;
                        break;
                    default:
                        Console.WriteLine("\nDu har ikke tastet en karakter ind. Prøv igen");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
