class Program
{
    static void Main()
    {
        // Declaration
        int myInt;
        double myDouble;
        decimal myDecimal;
        string myString;
        bool myBool;

        // Assignment
        myInt = 27;
        myDouble = 27.53;
        myDecimal = 23.0M;
        myString = "This is a string.";
        myBool = false;

        // Assignment (again)
        // NOTE: These are all mismatched and will errors! Try entering dotnet run into the terminal to see them for yourself.
        // TODO: Have a go at fixing these assignment statements by assigning the new values to the appropriate variables.
        myInt = "This is another string.";
        myDouble = 10.1M;
        myDecimal = true;
        myString = 100.123;
        myBool = 99;
        
        // Output to terminal
        Console.WriteLine(myInt);
        Console.WriteLine(myDouble);
        Console.WriteLine(myDecimal);
        Console.WriteLine(myString);
        Console.WriteLine(myBool);
    }
}
