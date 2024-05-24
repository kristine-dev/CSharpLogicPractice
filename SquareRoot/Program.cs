//Write a C# program that reads a number from the user and calculates its square root.
//Handle the exception if the number is negative.

Console.WriteLine("Input num to calculate square root: ");
string input = Console.ReadLine();
double result = 0;

try
{
    result = Math.Sqrt(Convert.ToInt32(input));
}

catch (Exception e)
{
    if (result < 0)
    {
        Console.WriteLine("Result is negative.");
    }
}