Dictionary<string, (decimal Price, decimal Quantity)> products =
            new Dictionary<string, (decimal, decimal)>();

string input;
while ((input = Console.ReadLine()) != "buy")
{
    string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string name = parts[0];
    decimal price = decimal.Parse(parts[1]);
    decimal quantity = decimal.Parse(parts[2]);

    if (!products.ContainsKey(name))
    {
        products[name] = (price, quantity);
    }
    else
    {
        var current = products[name];
        products[name] = (price, current.Quantity + quantity);
    }
}

foreach (var product in products)
{
    decimal totalPrice = product.Value.Price * product.Value.Quantity;
    Console.WriteLine($"{product.Key} -> {totalPrice:F2}");
}