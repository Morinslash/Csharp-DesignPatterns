using AbstractFactory;

Console.Title = "Abstract Factory";
var belgiumShoppingCartPurchaseFactory = new BelgiumShoppingCartPurchaseFactory();
var belgiumShoppingCart = new ShoppingCart(belgiumShoppingCartPurchaseFactory);
belgiumShoppingCart.CalculateCosts();

var franceShoppingCartPurchaseFactory = new FranceShoppingCartPurchaseFactory();
var franceShoppingCart = new ShoppingCart(franceShoppingCartPurchaseFactory);
franceShoppingCart.CalculateCosts();

Console.ReadKey();