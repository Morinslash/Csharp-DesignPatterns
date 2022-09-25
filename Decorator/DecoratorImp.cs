namespace Decorator;

public abstract class MailServiceDecoratorBase : IMailService
{
    private readonly IMailService _mailService;

    public MailServiceDecoratorBase(IMailService mailService)
    {
        _mailService = mailService;
    }

    public virtual bool SendMail(string message) => _mailService.SendMail(message);
}

public class StatisticsDecorator : MailServiceDecoratorBase
{
    public StatisticsDecorator(IMailService mailService) : base(mailService)
    {
    }

    public override bool SendMail(string message)
    {
        Console.WriteLine($"Collecting statistics in {nameof(StatisticsDecorator)}");
        return base.SendMail(message);
    }
}

public class MessageDatabaseDecorator : MailServiceDecoratorBase
{
    public List<string> SentMessages { get; private set; } = new();
    public MessageDatabaseDecorator(IMailService mailService) : base(mailService)
    {
    }

    public override bool SendMail(string message)
    {
        if (!base.SendMail(message)) return false;
        SentMessages.Add(message);
        return true;
    }

}