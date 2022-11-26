using System.Threading.Channels;

namespace Observer;

public class TicketChange   
{
    public int Amount { get; set; }
    public int ArtistId { get; set; }

    public TicketChange(int amount, int artistId)
    {
        Amount = amount;
        ArtistId = artistId;
    }
}

/// <summary>
/// Subject
/// </summary>
public abstract class TicketChangeNotifier
{
    private List<ITicketChangeListener> _observers = new();

    public void AddObserver(ITicketChangeListener observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(ITicketChangeListener observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(TicketChange ticketChange)
    {
        foreach (var observer in _observers)
        {
            observer.ReceiveTicketChangeNotification(ticketChange);
        }
    }
}

/// <summary>
/// ConcreteSubject
/// </summary>
public class OrderService : TicketChangeNotifier
{
    public void CompleteTicketSale(int artistId, int amount)
    {
        Console.WriteLine($"{nameof(OrderService)} is changing its state.");
        Console.WriteLine($"{nameof(OrderService)} is notifying observers...");
        Notify(new(artistId, amount));
    }
}

/// <summary>
/// Observer
/// </summary>
public interface ITicketChangeListener
{
    void ReceiveTicketChangeNotification(TicketChange ticketChange);
}

/// <summary>
/// ConcreteObserver
/// </summary>
public class TicketResellerService : ITicketChangeListener
{
    public void ReceiveTicketChangeNotification(TicketChange ticketChange)
    {
        Console.WriteLine($"{nameof(TicketResellerService)} notified " +
                          $"of ticket change: artist {ticketChange.ArtistId}, amount " +
                          $"{ticketChange.Amount}");
    }
}

/// <summary>
/// ConcreteObserver
/// </summary>
public class TicketStockService : ITicketChangeListener
{
    public void ReceiveTicketChangeNotification(TicketChange ticketChange)
    {
        Console.WriteLine($"{nameof(TicketStockService)} notified " +
                          $"of ticket change: artist {ticketChange.ArtistId}, amount " +
                          $"{ticketChange.Amount}");
    }
}