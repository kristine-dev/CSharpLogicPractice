// See https://aka.ms/new-console-template for more information
Console.Write("Input integers 0 to 1000: ");
string input = Console.ReadLine();

int num = Convert.ToInt32(input);

if (num < 0 || num > 1000)
{
    throw new Exception("Input cannot be less than 0 or greater than 1000");
}

Console.ReadLine();