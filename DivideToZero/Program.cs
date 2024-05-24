
class AverageCalculator
{
    public static void Main(string[] strings)
    {
        Console.Write("Input dividend and divisor by comma: ");
        string x = Console.ReadLine();
        string y = Console.ReadLine();

        Console.WriteLine(Divide(x, y));
    }

    private static decimal Divide(string  a, string b)
    {
        int aa = Convert.ToInt32(a);
        int bb = Convert.ToInt32(b);
        decimal result = 0M;

        try
        { 
            result = aa / bb;
            return result;
        }

        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
            return 0;
        } 
    }
}