using Observer;

Console.Title = "Observer";

TicketStockService ticketStockService = new();
TicketResellerService ticketResellerService = new();
OrderService orderService = new();

orderService.AddObserver(ticketStockService);
orderService.AddObserver(ticketResellerService);

orderService.CompleteTicketSale(1,2);

Console.ReadKey();
