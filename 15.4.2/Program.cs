namespace _15._4._2
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                var departments = new List<Department>()
                {
                  new Department() {Id = 1, Name = "Программирование"},
                  new Department() {Id = 2, Name = "Продажи"}
                };

                var employees = new List<Employee>()
                {
                  new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
                  new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
                  new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
                  new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
                };

                var depsWithEmployees = departments.GroupJoin(
                    employees, // первый набор данных
                    d => d.Id, // общее свойство второго набора
                    e => e.DepartmentId, // общее свойство первого набора
                    (d, emps) => new  // результат выборки
                    {
                        Name = d.Name,
                        Employees = emps.Select(e => e.Name)
                    });
                    
                foreach (var department in depsWithEmployees)
                {
                    Console.WriteLine("depart - " + department.Name);

                    foreach (var employee in department.Employees)
                    {
                        Console.WriteLine(employee);
                    }
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