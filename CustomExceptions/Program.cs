using System;
 
public class SymbolValidationException : Exception
{
    public SymbolValidationException(string message) //Eto po yung Custom Exception ko sir
        : base(message)
    {
    }
}
public class NegativeIntegerException : Exception //Another Custom Exception po sir
{
    public NegativeIntegerException(string message)
        : base(message)
    {
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--------------------Exercise 1--------------------");
        Exercise1();

        Console.WriteLine("\n--------------------Exercise 2--------------------");
        Exercise2();

        Console.WriteLine("Goodbye bye.");
    }

    static void Exercise1()
    {
        try
        {
            Console.Write("Enter an integer number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new NegativeIntegerException("Input is a negative integer.");
            }
            else
            {
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine($"Square root of {number} is {squareRoot:F2}");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }

    static void Exercise2()
    {
        Console.Write("Enter the starting number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending number: ");
        int end = int.Parse(Console.ReadLine());
     
        if (start > end)
        {
            Console.WriteLine("Starting number should be less than or equal to the ending number.");
            return;
        }

        for (int i = 1; i <= 10; i++)
        {
            try
            {
                int number = ReadNumber(start, end);
                Console.WriteLine($"Number {i}: {number}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ArgumentException: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                i--;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"FormatException: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                i--;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"OverflowException: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                i--;
            }
            catch (NegativeIntegerException ex)
            {
                Console.WriteLine($"NegativeIntegerException: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                i--;
            }
            catch (SymbolValidationException ex)
            {
                Console.WriteLine($"SymbolValidationException: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                i--;
            }
        }
    }
    
    static int ReadNumber(int start, int end)
    {
        Console.Write($"Enter a number in the range [{start}..{end}]: ");
        int number;

        try
        {
            string input = Console.ReadLine(); 

            if (input.Contains("@") || input.Contains("#") || input.Contains("$") || input.Contains("%")
                || input.Contains("^") || input.Contains("&") || input.Contains("*") || input.Contains("!"))
            {
                throw new SymbolValidationException("Symbols and special characters are not allowed.");
            }
            number = int.Parse(input);
            if  (number < 0)
            {
                throw new NegativeIntegerException("Invalid input: Negative values are not accepted.");
            }
            if (number < start || number > end)
            {
                throw new ArgumentException($"Number must be in the range [{start}..{end}] only.");
            }
        }
        catch (FormatException ex)
        {
            throw new FormatException("Invalid number.", ex);
        }
        catch (OverflowException ex)
        {
            throw new OverflowException("OverflowException: The number is too large.", ex);
        }

        return number;
    }
}
