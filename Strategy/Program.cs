﻿using Strategy;

Console.Title = "Strategy";

var order = new Order("Marvin Software", 5, "Visual Studio License");
order.ExportService = new CsvExportService();
order.Export();

order.ExportService = new JsonExportService();
order.Export();

// variation
order.Export(new XmlExportService());

Console.ReadKey();