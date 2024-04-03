using System;

class Program
{
    static void Main()
    {
        ForLoop();

    }


    public static void FormatSpecifier(){
        double amount = 123.45889;
        string name = "Alice";

        // ! Currency format
        string formattedCurrency = string.Format("Hello, {0}! Your balance is {1:C}.", name, amount);
        Console.WriteLine(formattedCurrency);

        // ! Float types: rounds off
        Console.WriteLine("Formatted amount: {0:N3}", amount);

        // ! Fixed-point format with 2 decimal places
        string formattedFixedPoint = string.Format("Formatted amount: {0:F2}", amount);
        Console.WriteLine(formattedFixedPoint);

        // ! Scientific notation
        string formattedScientific = string.Format("Scientific notation: {0:E}", amount);
        Console.WriteLine(formattedScientific);

        // ! Hexadecimal representation
        int hexValue = 255;
        string formattedHex = string.Format("Hex value: {0:X}", hexValue);
        Console.WriteLine(formattedHex);
    }

    public static void EscapeSequences(){
        string name = "Ace \b\"Penaflorida\": \\";
        string carriageReturn = "Carriage Return: \rOverwritenn Textss";

        Console.WriteLine(carriageReturn);
        Console.WriteLine(name);


    }

    public static void ForLoop(){
        for(int i = 1; i <= 10; i++){
            for(int j = 1; j <= 10; j++){
                Console.WriteLine($"{i} * {j} = {i*j}");
            }
            Console.WriteLine();
        }
    }

}
