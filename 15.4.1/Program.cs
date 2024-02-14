using System.Runtime.InteropServices;

namespace _15._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>()
            {
               new Department() {Id = 1, Name = "Программирование"},
               new Department() {Id = 2, Name = "Продажи"},
               new Department() {Id = 3, Name = "No department"}
            };


            var employees = new List<Employee>()
            {
                  new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
                  new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
                  new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
                  new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };

            var SortedList = from emp in employees
                             join dep in departments on emp.DepartmentId equals dep.Id
                             select new
                             {
                                 EmployeeName = emp.Name,
                                 DepName = dep.Name
                             };

            foreach (var item in SortedList)
            {
                Console.WriteLine(item.EmployeeName + "in departament" + item.DepName);
            }






        }
    }
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Employee
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}