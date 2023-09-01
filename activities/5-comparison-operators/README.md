# Learning activity #4: Binary Arithmetic Operators

In this activity you are going to solve a puzzle to demonstrate your understanding of comparison operators.

Note that this is learning actvitiy #5, and it is assumed you have already created a local version of this repository in learning activity #1.

Follow the steps below to complete the activity and complete the extension if you have time.

## 👣 Steps

1. Navigate to **activities/5-comparison-operators/src** using the explorer and open the **Program.cs** file.

</br>

2. Examine the contents of the file. What do you think it will output when we run this program?

</br>

3. Run the program. Remember, to do this, open a new terminal (`CTRL` + `SHIFT` + `'`), navigate to **activities/5-comparison-operators/src** (`cd activities/5-comparison-operators/src`), and enter: `dotnet run`.

</br>

4. Examine the contents of the terminal. Is the output of the program what you were expecting?

    <details>
    
    <summary>What should you be seeing as the output?</summary>

    ---

    This time you should get some warnings:

    ```
    warning CS0219: The variable 'x' is assigned but its value is never used
    warning CS0219: The variable 'y' is assigned but its value is never used
    ```

    Warnings are different from error messages. A program will work and execute when warnings are present. However, it is still worth taking note of warnings as they may highlight a mistake.

    In this case, we get warnings because the our variables `x` and `y` have not been used. We have declared and assigned them but we haven't yet done anything meaningful with them. Luckily, we will be addressing this in the next step.

    ---

    </details>

</br>

5. Write statements to output `True` and `False` to the terminal using the `x` and `y` variables along with comparison operators of your choosing (and confirm that your change works using 'dotnet run'.).

    <details>
    
    <summary>Hint #1</summary>

    ---

    To output to the terminal use `Console.WriteLine`. The comparison operators we have covered are: `<`, `>`, `<=`, and `>=`.

    ---

    </details>

    <details>
    
    <summary>Example solution</summary>

    ---

    Something like this will work (but there are other solutions):

    ```c#
    class Program
    {
        static void Main()
        {
            int x = 100;
            int y = 50;

            Console.WriteLine(x > y);
            Console.WriteLine(x < y);
        }
    }
    ```

    ---

    </details>