using System.Globalization;

namespace Group_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
              new Car("Suzuki", "JP"),
              new Car("Toyota", "JP"),
              new Car("Opel", "DE"),
              new Car("Kamaz", "RUS"),
              new Car("Lada", "RUS"),
              new Car("Honda", "JP"),
            };

            var CarsByCountry = cars
            .GroupBy(car => car.CountryCode)
            .Select(group => new
            {
                Name = group.Key,
                Amount = group.Count()
            });
            
            }
        }
    }
}
