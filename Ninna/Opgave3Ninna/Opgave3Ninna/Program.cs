namespace Opgave3Ninna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BMI input og udregning
            double vægt = 70;
            double højde = 1.75;
            double BMI = vægt / (højde * højde);

            //Output: Print BMI
            Console.WriteLine($"BMI: {BMI}");

            Console.ReadLine();
        }
    }
}
