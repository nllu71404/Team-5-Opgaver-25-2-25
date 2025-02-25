using System.Net.NetworkInformation;

namespace Opgave1Ninna
{
    internal class Program
    {
        static int Age = 25;
        static double Height = 1.75;
        static float Weight = 70.5f;
        static char Initial = 'A';
        static string Name = "Alice";
        static bool IsStudent = true;
        


        static void Main(string[] args)
        {
            Console.WriteLine($"Age: {Age}, Height: {Height}, Weight: {Weight}, Initial: {Initial}, Name: {Name}, Is Student: {IsStudent}"); 

            Console.ReadLine();
        }
    }
}
