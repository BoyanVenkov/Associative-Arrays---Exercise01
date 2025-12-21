Dictionary<string, int> output = new Dictionary<string, int>();

while (true)
{
    string resource = Console.ReadLine();
    if (resource == "stop")
    {
        break;
    }
    int quantity = int.Parse(Console.ReadLine());
    if (!output.ContainsKey(resource))
    {
        output.Add(resource, quantity);
    }
    else
    {
        output[resource] += quantity;
    }
}
foreach (var keyValuePair in output)
{
    Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
}