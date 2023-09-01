class Program
{
    static void Main()
    {
        int x = 100;
        int y = 50;

        string aString = "This is a string";
        string bString = "THIS IS A STRING";

        bool aBool = true;
        bool bBool = false;

        int aNumber = 6;
        int bNumber = 6;
        double cNumber = 6;

        // TODO: Use the == and != operators to make sure the correct information is output to the terminal.
        // The first three of statements have been completed for you below as an example.
        Console.WriteLine($"{x} does not equal {y}: {x != y}");

        Console.WriteLine($"{x} is equal to {y}: {x == y}");

        Console.WriteLine($"{aString} does not equal {bString}: {aString != bString}");

        Console.WriteLine($"{aString} is equivalent to {bString}: {aString == bString}"); // TODO: Complete this statement.

        Console.WriteLine($"{aBool} is equivalent to {bBool}: {aBool == bBool}"); // TODO: Complete this statement.

        Console.WriteLine($"{aNumber} is equivalent to {bNumber} and {cNumber}: {aNumber == bNumber && bNumber == cNumber}"); // TODO: Complete this statement.
    }
}

