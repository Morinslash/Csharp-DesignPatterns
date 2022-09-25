namespace Decorator;

public interface IMailService
{
    bool SendMail(string message);
}

public class OnPremiseMailService : IMailService
{
    public bool SendMail(string message)
    {
        Console.WriteLine($"Message \"{message}\" sent via {nameof(OnPremiseMailService)}");
        return true;
    }
}

public class CloudMailService : IMailService
{
    public bool SendMail(string message)
    {
        Console.WriteLine($"Message \"{message}\" sent via {nameof(CloudMailService)}");
        return true;
    }
}