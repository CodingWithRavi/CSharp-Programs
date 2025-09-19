using System;

class DataConversionProgram
{
    static void Main()
    {
        // String to Integer
        Console.Write("Enter a number (string): ");
        string strNum = Console.ReadLine();
        int intNum = Convert.ToInt32(strNum);
        Console.WriteLine("Converted to integer: " + intNum);

        // String to Double
        Console.Write("Enter a decimal number (string): ");
        string strDouble = Console.ReadLine();
        double doubleNum = Convert.ToDouble(strDouble);
        Console.WriteLine("Converted to double: " + doubleNum);

        // Integer to String
        string intToStr = intNum.ToString();
        Console.WriteLine("Integer converted back to string: " + intToStr);

        // String to DateTime
        Console.Write("Enter date (yyyy-mm-dd): ");
        string strDate = Console.ReadLine();
        DateTime date = Convert.ToDateTime(strDate);
        Console.WriteLine("Converted to DateTime: " + date.ToShortDateString());

        Console.WriteLine("\nData Conversion Completed!");
        Console.ReadKey();
    }
}
