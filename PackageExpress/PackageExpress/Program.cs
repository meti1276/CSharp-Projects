using System;

namespace PackageExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express!");
            Console.WriteLine("Please enter weight");
            int weight=Convert.ToInt32(Console.ReadLine());
            if (weight >50 )
            {
             Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
            }
            else
            {

            }
        }
    }
}
