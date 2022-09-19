using Newtonsoft.Json;

namespace Prototype;

public abstract class Person
{
    public abstract string Name { get; set; }
    public abstract Person Clone(bool deepClone = false);
}

public class Manager : Person
{
    public override string Name { get; set; }

    public Manager(string name)
    {
        Name = name;
    }

    public override Person Clone(bool deepClone = false)
    {
        if (!deepClone) return (Person)MemberwiseClone();
        var objectAsJson = JsonConvert.SerializeObject(this);
        return JsonConvert.DeserializeObject<Manager>(objectAsJson);
    }
}

public class Employee : Person
{
    public override string Name { get; set; }
    public Manager Manager { get; set; }

    public Employee(string name, Manager manager)
    {
        Name = name;
        Manager = manager;
    }

    public override Person Clone(bool deepClone = false)
    {
        if (!deepClone) return (Person)MemberwiseClone();
        var objectAsJson = JsonConvert.SerializeObject(this);
        return JsonConvert.DeserializeObject<Employee>(objectAsJson);
    }
}