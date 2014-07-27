using System;

class Exceptions
{
    static void Main()
    {
        int number;

        try
        {
            Console.Write("\nEnter a number: ");
            number = int.Parse(Console.ReadLine());
        }
        catch (FormatException e)
        {
            Console.Write("\nError: {0}\n\n", e.Message);
			return;
        }
    }
}
