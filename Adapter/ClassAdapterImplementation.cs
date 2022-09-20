namespace ClassAdapter;

/// <summary>
/// External Representation
/// </summary>
public class CityFromExternalSystem
{
    public string Name { get; private set; }
    public string NickName { get; private set; }
    public int Inhabitants { get; private set; }

    public CityFromExternalSystem(string name, string nickName, int inhabitants)
    {
        Name = name;
        NickName = nickName;
        Inhabitants = inhabitants;
    }
}

/// <summary>
/// Adaptee
/// </summary>
public class ExternalSystem
{
    public CityFromExternalSystem GetCity( ) => new CityFromExternalSystem("Antwerp", "'t Stad", 500000);
}
/// <summary>
/// Client
/// </summary>
public class City
{
    public string FullName { get; private set; }
    public long Inhabitants { get; private set; }

    public City(string fullName, long inhabitants)
    {
        FullName = fullName;
        Inhabitants = inhabitants;
    }
}

/// <summary>
/// Target
/// </summary>
public interface ICityAdapter
{
    City GetCity();
}

/// <summary>
/// Adapter
/// </summary>
class CityAdapter : Adapter.ExternalSystem, ICityAdapter
{
    public City GetCity()
    {
        var cityFromExternalSystem = base.GetCity();
        return new City($"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}",
            cityFromExternalSystem.Inhabitants);
    }
}