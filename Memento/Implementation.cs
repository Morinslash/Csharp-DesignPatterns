namespace Memento;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

class Manager : Employee
{
    public List<Employee> Employees = new();

    public Manager(int id, string name) : base(id, name)
    {
    }
}

/// <summary>
/// Invoker & Caretaker
/// </summary>
public class CommandManager
{
    private readonly Stack<AddEmployeeToManagerListMemento> _mementos = new Stack<AddEmployeeToManagerListMemento>();
    private AddEmployeeToManagerList? _command;

    public void Invoke(ICommand command)
    {
        if (_command is null)
        {
            _command = (AddEmployeeToManagerList)command;
        }
        if (command.CanExecute())
        {
            command.Execute();
            _mementos.Push(((AddEmployeeToManagerList)command).CreateMemento());
        }
    }

    public void Undo()
    {
        if (_mementos.Any())
        {
            _command?.RestoreMemento(_mementos.Pop());
            _command?.Undo();
        }
    }

    public void UndoAll()
    {
        while (_mementos.Any())
        {
            _command?.RestoreMemento(_mementos.Pop());
            _command?.Undo();
        }
    }
}