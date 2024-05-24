//Write a C# program that creates a method that reads a date from the user in the
//format "dd/mm/yyyy" and converts it to a DateTime object. Handle an exception if the
//input format is invalid.

Console.WriteLine("Input date on this format - 'dd/mm/yyyy'");
string strDate = Console.ReadLine();

try
{
    DateTime dt = Convert.ToDateTime(strDate);
}

catch 
{
    Console.WriteLine("Date format is invalid.");
}


