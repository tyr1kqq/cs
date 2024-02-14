namespace Задание_15._2._8
{
    internal class Program
    {
        public static List<int> numbers = new List<int>();
        static void Main(string[] args)
        {
            int inputNum;
        while (true)
            {
                Console.WriteLine("Enter number");
                var input = Console.ReadLine();
                    
                 var isInteger = Int32.TryParse(input , out inputNum );

                if (!isInteger )
                {
                    Console.WriteLine("Wrong");
                }
                else
                {
                    numbers.Add(inputNum);

                    Console.WriteLine("Your List"); 

                    foreach ( var number in numbers )
                        Console.Write(number + "  ");

                    Console.WriteLine("Number" + inputNum + "add to List");
                    Console.WriteLine("Всего в списке" +  " " + numbers.Count + " чисел");
                    Console.WriteLine("Sum - " + numbers.Sum());
                    Console.WriteLine("Max - " + numbers.Max());
                    Console.WriteLine("Min -" + numbers.Min());
                    Console.WriteLine("Average - " + numbers.Average());
                }
                Console.ReadKey();
                Console.Clear();


            }
        }
    }
}