namespace Count.Unit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
              new Contact() { Name = "Андрей", Phone = 79994500508 },
              new Contact() { Name = "Сергей", Phone = 799990455 },
              new Contact() { Name = "Иван", Phone = 79999675334 },
              new Contact() { Name = "Игорь", Phone = 8884994 },
              new Contact() { Name = "Анна", Phone = 665565656 },
              new Contact() { Name = "Василий", Phone = 3434 }
            };

            var RightNumber = (from contact in contacts
                               let PhoneString = contact.Phone.ToString()
                               where !PhoneString.StartsWith('7') && PhoneString.Length != 11
                               select contact)
                               .Count();

            Console.WriteLine(RightNumber);
        }
    }
}