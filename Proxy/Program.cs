Console.Title = "Proxy";

// without proxy
Console.WriteLine("Constructing document.");
var myDocument = new Proxy.Document("MyDocument.pdf");
Console.WriteLine("Document constructed.");
myDocument.DisplayDocument();

Console.WriteLine();

Console.WriteLine("Constructing document proxy.");
var documentProxy = new Proxy.DocumentProxy("MyDocument.pdf");
Console.WriteLine("Document proxy constructed.");
documentProxy.DisplayDocument();

Console.WriteLine();

Console.WriteLine("Constructing protected document proxy.");
var protectedDocumentProxy = new Proxy.ProtectedDocumentProxy("MyDocument.pdf", "Viewer");
Console.WriteLine("Protected Document proxy constructed.");
protectedDocumentProxy.DisplayDocument();

Console.WriteLine("Constructing protected document proxy.");
var protectedDocumentProxy2 = new Proxy.ProtectedDocumentProxy("MyDocument.pdf", "NotViewer");
Console.WriteLine("Protected Document proxy constructed.");
protectedDocumentProxy2.DisplayDocument();


Console.ReadKey();