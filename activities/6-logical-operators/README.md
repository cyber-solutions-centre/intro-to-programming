# Learning activity #6: Logical Operators

In this activity you are going to solve a puzzle to demonstrate your understanding of logical operators.

Note that this is learning actvitiy #6, and it is assumed you have already created a local version of this repository in learning activity #1.

Follow the steps below to complete the activity and complete the extension if you have time.

## 👣 Steps

1. Navigate to **activities/6-logical-operators/src** using the explorer and open the **Program.cs** file.

</br>

2. Examine the contents of the file. What do you think it will output when we run this program?

</br>

3. Complete the program by following the instructions highlighted with `// TODO` comments.

</br>

4. Run the program to confirm that it works. Remember, to do this, open a new terminal (`CTRL` + `SHIFT` + `'`), navigate to **activities/6-logical-operators/src** (`cd activities/6-logical-operators/src`), and enter: `dotnet run`.

    <details>
    
    <summary>Example solution</summary>

    ---

    Something like this will work (but there are other solutions):

    ```c#
    // TODO: Using the above variables, the logical && operator, and the > comparison operator, create an expression that evaluates to true and output this to the terminal.
    bool result1 = (largerNumber > smallerNumber && isChecked);
    Console.WriteLine(result1);

    // TODO: Using result1 and a logical operand create an expression that evaluates to false and output this to the terminal.
    bool result2 = !result1;
    Console.WriteLine(result2);
    ```

    Be sure to ask if you don't understand any parts of the solution.

    ---

    </details>

