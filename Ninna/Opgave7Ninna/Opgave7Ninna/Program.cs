using System.ComponentModel.Design;

namespace Opgave7Ninna
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Titel på skudår-program
            Console.WriteLine("-----------------");
            Console.WriteLine("Er det et skudår?");
            Console.WriteLine("-----------------");

            //Brugerinput 
            Console.WriteLine("Indtast år: ");
            double år = Convert.ToDouble(Console.ReadLine());

            //Output 
            if (år % 4 == 0 && år % 100 != 0 || år % 400 == 0) 
            { 
                Console.WriteLine("\nJa, det er et skudår!!");
            }
            else 
            {
                Console.WriteLine("\nNej, det er ikke et skudår.");
            }

            Console.ReadLine();
        
        }
    }
}
