# Learning activity #3: Assignment mismatch

In this activity you are going to further build your understanding of variables and fix some errors.

Note that this is learning actvitiy #3, and it is assumed you have already created a local version of this repository in learning activity #1.

Follow the steps below to complete the activity and complete the extension if you have time.

## 👣 Steps

1. Navigate to **activities/3-assignment-mismatch/src** using the explorer and open the **Program.cs** file.

</br>

2. Examine the contents of the file. What do you think it will output when we run this program?

</br>

3. Run the program. Remember, to do this, open a new terminal (`CTRL` + `SHIFT` + `'`), navigate to **activities/3-assignment-mismatch/src** (`cd activities/3-assignment-mismatch/src`), and enter: `dotnet run`.

</br>

4. Examine the contents of the terminal. Is the output of the program what you were expecting?

    <details>
    
    <summary>What should you be seeing as the output?</summary>

    ---

    Error messages! Each should look something like this: `error CS0029: Cannot implicitly convert type 'string' to 'int'`.

    Don't worry! Getting errors like this is a normal part of programming. An by examining the messages we can figure out what the problem is.

    Take a moment to examine the error messages and think about how the errors could be resolved...

    ---

    </details>

</br>

5. Fix the program and confirm that your fix works using 'dotnet run'.

    <details>
    
    <summary>Hint #1</summary>

    ---

    Looking at the error message we can see that the the program is trying to (implictly) convert the values we have assigned to a different type (E.g., convert type 'string' to 'int').

    In this case, this is simply because the values are not being assigned to the correct variables. E.g., the string value should be assigned to the variable we set up to store that type of data using the `string` keyword: the `myString` variable.

    You might notice that for one of the mismatched assignements, the corresponding error message mentions that an explicit conversion exists... Learn more about this by having a go at the extension activity.

    ---

    </details>

    <details>
    
    <summary>Example solution</summary>

    ---

    Something like this will work:

    ```c#
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
            myInt = 99;
            myDouble = 100.123;
            myDecimal = 10.1M;
            myString = "This is another string.";
            myBool = true;
        
            // Output to terminal
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            Console.WriteLine(myDecimal);
            Console.WriteLine(myString);
            Console.WriteLine(myBool);
        }
    }
    ```

    ---

    </details>
