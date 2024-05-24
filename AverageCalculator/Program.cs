
class AverageCalculator
{
    public static void Main(string[] strings)
    {
        Console.Write("Input integers separated by comma: ");
        string intArr = Console.ReadLine();

        if (intArr == null) 
        {
            return;
        }

        Console.WriteLine(GetAverage(intArr));
    }

    private static decimal GetAverage(string inputs)
    {
        int[] input = inputs.Select(i => Convert.ToInt32(i)).ToArray();

        decimal result = 0M; 
        int inputCount = input.Length;
        
        foreach (int i in input)
        {
            result = result + i;
        }

        result = result / inputCount;

        return result;
    }
}