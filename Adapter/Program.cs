using Adapter;
using CityAdapter = ClassAdapter.CityAdapter;

Console.Title = "Adapter";

//Object Adapter example
Adapter.ICityAdapter adapter = new Adapter.CityAdapter();
var city = adapter.GetCity();

Console.WriteLine($"{city.FullName}, {city.Inhabitants}");

// Class Adapter example
ClassAdapter.ICityAdapter classAdapter = new ClassAdapter.CityAdapter();
var classCity = classAdapter.GetCity();
Console.WriteLine($"{classCity.FullName}, {classCity.Inhabitants}");

Console.ReadKey();

