using System;
namespace Method
{
    class Program
    {
        public static void Main (string[] args)
        {
            findTheNearestSquareRoot(500);
        }
        public static void findTheNearestSquareRoot(double number)
        {
            if (number % Math.Sqrt(number) == 0)
            {
                Console.WriteLine(Math.Sqrt(number)); 
            }
            else
            {
                Console.WriteLine(Math.Truncate(Math.Sqrt(number))); 
            }
           
            
        }
    }
}