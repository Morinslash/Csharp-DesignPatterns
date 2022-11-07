namespace Command;

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
/// Invoker
/// </summary>
public class CommandManager
{
    private readonly Stack<ICommand> _commands = new Stack<ICommand>();

    public void Invoke(ICommand command)
    {
        if (command.CanExecute())
        {
            command.Execute();
            _commands.Push(command);
        }
    }

    public void Undo()
    {
        if (_commands.Any())
        {
            _commands.Pop()?.Undo();
        }
    }

    public void UndoAll()
    {
        while (_commands.Any())
        {
            _commands.Pop()?.Undo();
        }
    }
}