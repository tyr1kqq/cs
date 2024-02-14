namespace UnderTheHood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
              new Student {Name="Андрей", Age=23 },
              new Student {Name="Сергей", Age=27 },
              new Student {Name="Дмитрий", Age=29 }
            };

            var result = from st in students
                         where st.Age <27
                         select st;

            foreach (var student in result)
            {
                Console.WriteLine(student.Name);
            }

        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}