# Learning activity #8: Equality Operators

In this activity you are going to solve a puzzle to demonstrate your understanding of logical operators.

Note that this is learning actvitiy #6, and it is assumed you have already created a local version of this repository in learning activity #1.

Follow the steps below to complete the activity and complete the extension if you have time.

## 👣 Steps

1. Navigate to **activities/8-equality-operators/src** using the explorer and open the **Program.cs** file.

</br>

2. Examine the contents of the file. What do you think it will output when we run this program?

</br>

3. Complete the program by following the instructions highlighted with `// TODO` comments.

</br>

4. Run the program to confirm that it works. Remember, to do this, open a new terminal (`CTRL` + `SHIFT` + `'`), navigate to **activities/8-equality-operators/src** (`cd activities/8-equality-operators/src`), and enter: `dotnet run`.

    <details>
    
    <summary>Example solution</summary>

    ---

    Something like this will work (but there are other solutions and multiple valid ways to complete the last statement in particular):

    ```c#
    // TODO: Use the == and != operators to make sure the correct information is output to the terminal.
    // The first three of statements have been completed for you below as an example.
    Console.WriteLine($"{x} does not equal {y}: {x != y}");

    Console.WriteLine($"{x} is equal to {y}: {x == y}");

    Console.WriteLine($"{aString} does not equal {bString}: {aString != bString}");

    Console.WriteLine($"{aString} is equivalent to {bString}: {aString == bString}"); // TODO: Complete this statement.

    Console.WriteLine($"{aBool} is equivalent to {bBool}: {aBool == bBool}"); // TODO: Complete this statement.

    Console.WriteLine($"{aNumber} is equivalent to {bNumber} and {cNumber}: {aNumber == bNumber && bNumber == cNumber}"); // TODO: Complete this statement.
    ```

    This should ouput:

    ```
    100 does not equal 50: True
    100 is equal to 50: False
    This is a string does not equal THIS IS A STRING: True
    This is a string is equivalent to THIS IS A STRING: False
    True is equivalent to False: False
    6 is equivalent to 6 and 6: True
    ```
    
    Take a moment to think about whether all of these are what you expected and note that:
    
    - `"This is a string"` does not equal `"THIS IS A STRING"`. The program doesn't appreciate the meaning of text, so the case of letters matters!
    - The `double` with a value of `6` is equivalent to the `int` variables with values of 6. This is because C# recognized we were comparing an `int` with a `double` and did an implicit conversion, making the `int` a `double` value. 

    ---

    </details>

