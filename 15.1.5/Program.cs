namespace _15._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var softwareManufacturers = new List<string>()
            {
               "Microsoft", "Apple", "Oracle"
            };

            var hardwareManufacturers = new List<string>()
            {
                "Apple", "Samsung", "Intel"
            };

            var itCompanies = softwareManufacturers.Union(hardwareManufacturers);
        }
    }
}