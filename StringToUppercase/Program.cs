Console.Write("Input string to convert to uppercase: ");

try 
{
    string x = Console.ReadLine();
    Console.WriteLine(x.ToUpper());
}

catch (NullReferenceException e)
{
    Console.WriteLine("Input is null.");
}


