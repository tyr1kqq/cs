namespace Linq.Unit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Список напитков в продаже
            string[] drinks = { "Вода", "Кока-кола", "Лимонад", "Вино" };
            // Алкогольные напитки
            string[] alcohol = { "Вино", "Пиво", "Сидр" };

            var NotAlcoDrink = drinks.Except(alcohol);

            foreach (var drink in NotAlcoDrink)
                Console.WriteLine(drink);

            Console.WriteLine();

            string[] cars = { "Волга", "Москвич", "Нива", "Газель" };
            string[] buses = { "Газель", "Икарус", "ЛиАЗ" };

            // Нахождение общих элементов в коллекции - .Intersect(); 
            var micro = cars.Intersect(buses);

            foreach (var car in micro)
                Console.WriteLine(car);

            Console.WriteLine();
            
            //объедениение коллекций , есть уникальность
            var vechicles = cars.Union(buses);

            foreach (var car in vechicles)
                Console.WriteLine(car);

            Console.WriteLine();

            // Объеденение , упускается уникальность
            var Vech = cars.Concat(buses);

            foreach(var car in Vech)
                Console.WriteLine(car);

            Console.WriteLine();

            // Удаление дубликатов 
            var Notduble = Vech.Distinct();

            foreach (var car in Notduble)
                Console.WriteLine(car);

            Console.WriteLine();

            Console.WriteLine(CountCommon("one" , "two"));

            static int CountCommon (string a , string b)
            {
                var amount = a.Intersect(b).Count();
                return amount;
            }
        }
    }
}