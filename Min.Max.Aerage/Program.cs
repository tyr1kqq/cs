namespace Min.Max.Aerage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] { 1, 7, 45, 23 };

            int maxNums = nums.Max();
            int minNums = nums.Min();
            double aver = nums.Average();

            Console.WriteLine(maxNums + " " + minNums + " " + aver);
        }
    }
}