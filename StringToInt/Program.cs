string input = Console.ReadLine();

try
{
    int i = int.Parse(input);
}

catch (Exception e)
{
    Console.WriteLine("Cannot convert to int.");
}