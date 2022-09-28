using Facade;

Console.Title = "Facade";

var discountFacade = new DiscountFacade();
Console.WriteLine($"Discount percentage for customer with id 1: {discountFacade.CalculateDiscountPercentage(1)}");
Console.WriteLine($"Discount percentage for customer with id 10: {discountFacade.CalculateDiscountPercentage(10)}");

Console.ReadKey();