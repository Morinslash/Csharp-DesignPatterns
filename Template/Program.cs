using Template;

Console.Title = "Template";


ExchangeMailParse exchangeMailParse = new();
Console.WriteLine(exchangeMailParse.ParseMailBody("abc-dfg"));
Console.WriteLine();

ApacheMailParser apacheMailParser = new();
Console.WriteLine(apacheMailParser.ParseMailBody("123-321"));
Console.WriteLine();

EudoraMailParser eudoraMailParser = new();
Console.WriteLine(eudoraMailParser.ParseMailBody("abc-123"));

Console.ReadKey();