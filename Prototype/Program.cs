using Prototype;

Console.Title = "Prototype";

var manager = new Manager("Cindy");
var managerClone = (Manager)manager.Clone();
Console.WriteLine($"Manger was cloned: {managerClone.Name}");

var employee = new Employee("Kevin", manager);
var employeeClone = (Employee)employee.Clone(true);
Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");

managerClone.Name = "Karen";
Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");

Console.ReadKey();