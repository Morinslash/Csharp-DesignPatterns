using Decorator;

Console.Title = "Decorator";

var cloudMailService = new CloudMailService();
cloudMailService.SendMail("Hi there.");

var onPremiseMailService = new OnPremiseMailService();
onPremiseMailService.SendMail("Hi here.");

var statisticsDecorator = new StatisticsDecorator(cloudMailService);
statisticsDecorator.SendMail($"Hi there via {nameof(statisticsDecorator)} wrapper");

var messageDatabaseDecorator = new MessageDatabaseDecorator(onPremiseMailService);
messageDatabaseDecorator.SendMail($"Hi here via {nameof(messageDatabaseDecorator)} wrapper, message 1.");
messageDatabaseDecorator.SendMail($"Hi here via {nameof(messageDatabaseDecorator)} wrapper, message 2.");

foreach (var message in messageDatabaseDecorator.SentMessages)
{
    Console.WriteLine($"Stored message: \"{message}\"");
}

Console.ReadKey();