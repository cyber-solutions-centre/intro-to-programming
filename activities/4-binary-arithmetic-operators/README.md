# Learning activity #4: Binary Arithmetic Operators

In this activity you are going to solve a puzzle to demonstrate your understanding of binary arithmetic operators.

Note that this is learning actvitiy #4, and it is assumed you have already created a local version of this repository in learning activity #1.

Follow the steps below to complete the activity and complete the extension if you have time.

## 👣 Steps

1. Navigate to **activities/4-binary-arithmetic-operators/src** using the explorer and open the **Program.cs** file.

</br>

2. Examine the contents of the file. What do you think it will output when we run this program?

</br>

3. Run the program. Remember, to do this, open a new terminal (`CTRL` + `SHIFT` + `'`), navigate to **activities/4-binary-arithmetic-operators/src** (`cd activities/4-binary-arithmetic-operators/src`), and enter: `dotnet run`.

</br>

4. Examine the contents of the terminal. Is the output of the program what you were expecting?

    <details>
    
    <summary>What should you be seeing as the output?</summary>

    ---

    With `x = 100` and `y = 50` the following should be output:

    ```
    150
    50  
    5000
    2   
    0
    ```

    ---

    </details>

</br>

5. Change the values of a `x` and `y` to produce the following output (and confirm that your change works using 'dotnet run'.):

    ```
    9
    1
    20
    1.25
    1
    ```

    <details>
    
    <summary>Hint #1</summary>

    ---

    This might be a bit trickier than expected...

    Setting `x = 5` and `y = 4` seems like a good start. However, the fourth line output by this might not be what you expect as you'll get 1 instead of 1.25. (have a go at making this change and running the code if you haven't already).

    The reason for this is that we are applying the `/` operator to two operands of type `int`. So the computer thinks we want an `int` result to be output and rounds the answer down to the nearest integer.

    In this case, we want the floating-point number resulting from `5 / 4`. Explore the documentation to see if you can find a way of doing this before revealing the answer: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators.

    ---

    </details>

    <details>
    
    <summary>Example solution</summary>

    ---

    Something like this will work (there are other solutions, but this preserves the `int` type of `x` and `y`):

    ```c#
    class Program
    {
        static void Main()
        {
            int x = 5;
            int y = 4;

            Console.WriteLine(x + y); // After the change this line should output: 9.
            Console.WriteLine(x - y); // After the change this line should output: 1.
            Console.WriteLine(x * y); // After the change this line should output: 20.
            Console.WriteLine((double)x / y); // After the change this line should output: 1.25.
            Console.WriteLine(x % y); // After the change this line should output: 1.
        }
    }
    ```

    ---

    </details>