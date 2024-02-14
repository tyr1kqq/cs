namespace _15._1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");

            // читаем ввод
            var text = Console.ReadLine();

            // сохраняем список знаков препинания и символ пробела в коллекцию
            var punctuation = new List<char>() { ' ', ',', '.', ';', ':', '!', '?' };

            if(string.IsNullOrEmpty(text) )
            {
                Console.WriteLine("Text is null");
            }
            else
            {
                var nonPunctuation = text.Except(punctuation).ToArray();

                Console.WriteLine(nonPunctuation);
            }
        }
    }
}