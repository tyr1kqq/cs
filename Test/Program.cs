namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>() { "Вася", "Вова", "Петя", "Андрей" };

            var Test = names.Where(name => name.StartsWith("В")).ToArray();

            names.Remove("Вася");
            names.Remove("Вова");

            foreach (var name in Test)
            {
                Console.WriteLine(name);
            }
        }
    }
}