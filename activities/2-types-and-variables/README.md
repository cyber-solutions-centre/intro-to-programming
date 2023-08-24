# Learning activity #2: Data types & variables

In this activity we are going assign values into variables of different types and print these to the terminal.

Note that this is learning actvitiy #2, and it is assumed you have already created a local version of this repository in learning activity #1.

Follow the steps below to complete the activity and complete the extension if you have time.

## 👣 Steps

1. Navigate to **activities/2-types-and-variables/src** using the explorer and open the **Program.cs** file.

</br>

2. Examine the contents of the file. What do you think it will output when we run this program?

</br>

3. Run the program. Remember, to do this, open a new terminal (`CTRL` + `SHIFT` + `'`), navigate to **activities/2-types-and-variables/src** (`cd activities/1-hello-c-sharp/src`), and enter: `dotnet run`.

</br>

4. Examine the contents of the terminal. Is the output of the program what you were expecting?

    <details>
    
    <summary>What should you be seeing as the output?</summary>

    ---

    Error messages! Each should look something like this: `error CS0165: Use of unassigned local variable 'myInt'`.

    Don't worry! Getting errors like this is a normal part of programming. An by examining the messages we can figure out what the problem is.

    Take a moment to examine the error messages and think about how the errors could be resolved...

    ---

    </details>

</br>

5. Fix the program and confirm that your fix works using 'dotnet run'.

    <details>
    
    <summary>Hint #1</summary>

    ---

    Looking at the error message we can see that the issue is an **unassigned local variable**. In fact, it looks like all of our variables are unassigned.

    Assigning values to the variables (of the appropriate type) should fix the error message...

    ---

    </details>

    <details>
    
    <summary>Hint #2</summary>

    ---

    We can assign a value to a variable using `=`. So for the `myInt` variable we could change the line to something like: `int myInt = 1;` and this would fix the issue.

    However, we need to do this for all the variables, and we need to make sure we are assigning the correct types.

    If you are getting another error it probably means one the values you have assigned is not of the correct type.

    For example, you might be seeing an error like: `Literal of type double cannot be implicitly converted to type 'decimal'; use an 'M' suffix to create a
    literal of this type`. This error suggests we have mistakenly assigned a value with type **double** into a variable expecting type **decimal**. The error also provides a solution, for the variable expecting a decimal value, we need to use the `M` suffix, so changing the code to something like `decimal myDecimal = 0.1M` should work better.

    Have a go at fixing any remaining errors before revealing the answer.

    ---

    </details>

    <details>
    
    <summary>Example solution</summary>

    ---

    Something like this will work:

    ```c#
    // Declare and assign variables (note, you need to do the assignment as a part of this activity)
    int myInt = 1;
    double myDouble = 1.23;
    decimal myDecimal = 0.1M;
    string myString = "hello";
    bool myBool = true;
        
    // Print the variables to the terminal
    Console.WriteLine(myInt);
    Console.WriteLine(myDouble);
    Console.WriteLine(myDecimal);
    Console.WriteLine(myString);
    Console.WriteLine(myBool);
    ```

    The values themselves aren't that important in this case. The important thing is that the assigned values are of the expected type.

    ---

    </details>