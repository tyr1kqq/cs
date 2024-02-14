using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Agregation.unit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            var result = numbers.Aggregate((x, y) => x - y);
            Console.WriteLine(result);

            Console.WriteLine("Factorial");
            int fac = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(fac));
        }

        static long Factorial(int number)
        {
            var numbers = new List<int>();

            for ( int i = 1; i < number; i++)
                numbers.Add(i);

            long result = numbers.Aggregate((x,y)=> x*y);
            return result;
        }
    }
}