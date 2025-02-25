namespace Opgave2Ninna
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
         
            //Her kunne man f.eks lave en menu med valgene: 1. Fahrenheit til celcius og 2. Celcius til fahrenheit

            //Brugerinput: Intast fahrenheit
            Console.WriteLine("Fahrenheit til celcius udregner. Indtast fahrenheit:");
            double Finput = Convert.ToDouble(Console.ReadLine());

            double celcius = (Finput - 32) / 1.8; 

            Console.WriteLine($"{Finput}°F = {celcius}°C");

            //Brugerinput: Indtast celcius
            Console.WriteLine("\nCelcius til fahrenheit udregner. Indtast celcius:");
            double Cinput = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = Cinput * 1.8 + 32;

            Console.WriteLine($"{Cinput}°C = {fahrenheit}°C");

            Console.ReadLine();


        }
    }
}
