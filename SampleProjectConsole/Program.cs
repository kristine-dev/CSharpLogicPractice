
Console.Write("Input file path: ");
string path = Console.ReadLine();

try 
{
    using (StreamReader sr = new StreamReader(path))
    {
        
    }
}

catch (Exception e)
{
    Console.Write("Wrong file path or file doesn't exists: " + e.Message);
}

Console.ReadLine();
