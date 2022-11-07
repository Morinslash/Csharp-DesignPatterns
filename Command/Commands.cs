namespace Command;

/// <summary>
/// Command
/// </summary>
public interface ICommand
{
    void Execute();
    bool CanExecute();

    void Undo();
}

/// <summary>
/// ConcreteCommand
/// </summary>
public class AddEmployeeToManagerList : ICommand
{
    private IEmployeeManagerRepository _employeeManagerRepository;
    private int _managerId;
    private Employee? _employee;

    public AddEmployeeToManagerList(IEmployeeManagerRepository employeeManagerRepository, int managerId, Employee? employee)
    {
        _employeeManagerRepository = employeeManagerRepository;
        _managerId = managerId;
        _employee = employee;
    }

    public void Execute()
    {
        if (_employee is null)
        {
            return;
        }
        _employeeManagerRepository.AddEmployee(_managerId, _employee);
    }

    public void Undo()
    {
        if (_employee is null)
        {
            return;
        }
        _employeeManagerRepository.RemoveEmployee(_managerId, _employee);
    }

    public bool CanExecute()
    {
        if (_employee is null)
        {
            return false;
        }
        if (_employeeManagerRepository.HasEmployee(_managerId, _employee.Id))
        {
            return false;
        }

        return true;
    }
}

