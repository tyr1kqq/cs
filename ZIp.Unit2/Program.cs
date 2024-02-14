namespace ZIp.Unit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  объявляем две коллекции
            var letters = new string[] { "A", "B", "C", "D", "E" };
            var numbers = new int[] { 1, 2, 3 };

            // проводим "упаковку" элементов, сопоставляя попарно
            var zip = letters.Zip(numbers, (l , n) => l + n.ToString());

            foreach ( var item in zip )
            {
                Console.WriteLine(item);
            }
        }
    }
}