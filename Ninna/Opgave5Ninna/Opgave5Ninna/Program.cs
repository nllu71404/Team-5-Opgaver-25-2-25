namespace Opgave5Ninna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Titel
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Udregning af areal og omkreds af en cirkel ud fra given radius");
            Console.WriteLine("--------------------------------------------------------------");

            //Bruger input - radius
            Console.WriteLine("\nIntast radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());


            //Udregninger
            double areal = Math.PI * (radius * radius);
            double omkreds = 2 * Math.PI * radius;

            //Output - Print af resultat 
            Console.WriteLine($"\nArealet er: {areal} ");
            Console.WriteLine($"Omkredsen er: {omkreds}");

            Console.ReadLine();

        }
    }
}
