string input = Console.ReadLine();

Dictionary<char, int> output = new Dictionary<char, int>();

char[] inputChars = input.ToCharArray();

for (int i = 0; i< inputChars.Length; i++)
{
    if (inputChars[i] != ' ')
    {
        if (!output.ContainsKey(inputChars[i]))
        {
            output[inputChars[i]] = 1;
        }
        else 
        {
            output[inputChars[i]]++;
        }
    }
}
foreach (var keyValuePair in output)
{
    Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");

}