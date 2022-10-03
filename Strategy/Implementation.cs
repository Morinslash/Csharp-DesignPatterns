namespace Strategy;

public interface IExportService
{
    void Export(Order order);
}

class JsonExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"Exporting {order.Name} to Json");
    }
}

class XmlExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"Exporting {order.Name} to XML");
    }
}

class CsvExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"Exporting {order.Name} to CSV");
    }
}

public class Order
{
    public string Customer { get; set; }
    public int Amount { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public IExportService?  ExportService { get; set; }
    public Order(string customer, int amount, string name)
    {
        Customer = customer;
        Amount = amount;
        Name = name;
    }

    public void Export() => ExportService?.Export(this);
    public void Export(IExportService exportService) => exportService.Export(this);
}