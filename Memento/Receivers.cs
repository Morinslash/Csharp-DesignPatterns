namespace Memento;

/// <summary>
/// Receiver (interface)
/// </summary>
public interface IEmployeeManagerRepository
{
    void AddEmployee(int managerId, Employee employee);
    void RemoveEmployee(int managerId, Employee employee);
    bool HasEmployee(int managerId, int employeeId);
    void WriteDataStore();
}

class EmployeeManagerRepository : IEmployeeManagerRepository
{
    private readonly List<Manager> _managers = new() { new Manager(1, "Katie"), new Manager(2, "Geoff") };
    public void AddEmployee(int managerId, Employee employee)
    {
        _managers.First(m=> m.Id == managerId).Employees.Add(employee);
    }

    public void RemoveEmployee(int managerId, Employee employee)
    {
        _managers.First(m=> m.Id == managerId).Employees.Remove(employee);
    }

    public bool HasEmployee(int managerId, int employeeId) => _managers.First(m=> m.Id == managerId).Employees.Any(e => e.Id ==employeeId);

    public void WriteDataStore()
    {
        foreach (var manager in _managers)
        {
            Console.WriteLine($"Manager {manager.Id}, {manager.Name}");
            if (manager.Employees.Any())
            {
                manager.Employees.ForEach(e => Console.WriteLine($"\t Employee {e.Id}, {e.Name}"));
            }
            else
            {
                Console.WriteLine($"\t No employees");
            }
        }
    }
}