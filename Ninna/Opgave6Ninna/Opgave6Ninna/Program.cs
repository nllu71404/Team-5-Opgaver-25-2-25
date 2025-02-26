namespace Opgave6Ninna
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Variabler
            bool IsEqual = (5 == 7);
            bool IsNotEqual = (5 != 7);
            bool IsGreater = (5 > 7);
            bool IsLess = (5 < 7);
            bool IsGreaterOrEqual = (5 >= 7);
            bool IsLessOrEqual = (5 <= 7);

            //Output - Print af resultaer 
            Console.WriteLine($"Is Equal: {IsEqual},  Is Not Equal: {IsNotEqual},  Is Greater: {IsGreater},  Is Less: {IsLess},  Is Greater Or Equal: {IsGreaterOrEqual},  Is Less Or Equal: {IsLessOrEqual}");

            Console.ReadLine();
        }
    }
}
