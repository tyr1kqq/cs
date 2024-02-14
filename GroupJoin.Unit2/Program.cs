namespace GroupJoin.Unit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
            new Car() { Model  = "SX4", Manufacturer = "Suzuki"},
            new Car() { Model  = "Grand Vitara", Manufacturer = "Suzuki"},
            new Car() { Model  = "Jimny", Manufacturer = "Suzuki"},
            new Car() { Model  = "Land Cruiser Prado", Manufacturer = "Toyota"},
            new Car() { Model  = "Camry", Manufacturer = "Toyota"},
            new Car() { Model  = "Polo", Manufacturer = "Volkswagen"},
            new Car() { Model  = "Passat", Manufacturer = "Volkswagen"},
            };

            // Список автопроизводителей
            var manufacturers = new List<Manufacturer>()
            {
              new Manufacturer() { Country = "Japan", Name = "Suzuki" },
              new Manufacturer() { Country = "Japan", Name = "Toyota" },
              new Manufacturer() { Country = "Germany", Name = "Volkswagen" },
            };

            // Выборка + группировка
            var result = manufacturers.GroupJoin(
               cars, // первый набор данных
               m => m.Name, // общее свойство второго набора
               car => car.Manufacturer, // общее свойство первого набора
               (m, crs) => new  // результат выборки
               {
                   Name = m.Name,
                   Country = m.Country,
                   Cars = crs.Select(c => c.Model)
               });

            foreach (var team in result)
            {
                Console.WriteLine("team " + team.Name);

                foreach (var item in team.Cars)
                    Console.WriteLine(item);
            }

        }
    }

    public class Car
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
    }

    // Завод - изготовитель
    public class Manufacturer
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}