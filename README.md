# Introduction to Programming

## :mortar_board: Intended learning outcomes

At the end of the session you will be able to:

-	Explain the function and utility of data types, variables, and operators.
-	Write a program using C# (a popular programming language).

## What is Programming?

Programming is a key part of software development. But it not the only part! We will spend a considerable amount of time on this course learning how to write programs. But it is important to remember that there is more to software development than programming (for example, we have already covered version control, and we will explore other aspects of software development in later weeks).

Equally, programming is valuable skill beyond software development. Take a look at the table below to see how programming is related to different roles in the UK Cyber Security Councils Careers Framework.

| Secure System Development | Digital Forensics | Secure Operations | Cyber Security Generalist |
|----------|----------|----------|----------|
| Programming will be a key part of your job role and is essential to developing software. | You will need to be able to read and understand code as a part of your investigations. | You will use scripting languages as a part of your job role (probably to automate things). | As a generalist you will be expected to have some knowledge of many areas, including programming! |

But what does the act of programming actually involve? Put briefly, programming is the act of writing instructions (code) for a computer to follow and solve problems on our behalf.

Much of modern society is underpinned by computers running these kinds of programs:

- Switching on a computer or using your phone.
- Browsing the Web and liking something on social media.
- Setting the timer on a microwave.
- Making a withdrawal from a cash machine or paying with a card directly.
- And much much more!

## Programming languages

We can't give computers instructions like we would give a human instructions. Natural languages like English are too ambiguous; even as humans we can interpret the meaning of natural language in different ways, so what chance does a computer have! Even language models, like ChatGPT, which are designed to handle natural language inputs demonstrate this point, and often misinterpret the meaning of natural language.

At the lowest level, computers operate on binary code (a sequence of 0s and 1s), which is unambiguous. However, writing programs in binary code would take a long time and simply wouldn't be practical. So we use programming languages that are easier for humans to write and that can be transformed into binary code to give instructions to computers instead.

There are lots of different programming languages, but don't worry! Programming languages have lots in common and learning a new programming language isn't comparable to learning a new natural language (E.g., Spanish).

In this course, we are going to focus on the C# programming language. C# is a very versatile language and can be used to develop web, mobile, and Internet of Things applications as well as games.

## Hello C#

To start learning C#, we are going to create our very first program in [learning activity #1: Hello C#](https://github.com/cyber-solutions-centre/intro-to-programming/tree/main/activities/1-hello-c-sharp). Complete the learning activity before continuing here, where we will dissect the program code.

### Program.cs

In the previous activity, we ran the following program:

```c#
class Program
{
    static void Main()
    {
        // Change the below line so that the program greets C# instead of the world (E.g., Hello, C#!)
        Console.WriteLine("Hello, World!");
    }
}
```

To fully understand this program, we will now break it down and examine parts of the code in further detail. Starting with:

```c#
class Program
{
    ...
}
```

In this part of the code the `class` keyword is being used to define a **class** named `Program`. The code between the `{}` constitutes the class. In C#, programs typically start executing instructions from a `Main` **method** inside a `Program` class:

```c#
static void Main()
{
    ...
}
```

The `void` keyword indicates the absence of a data type and means that we are not expecting the `Main` method to return any data. The empty `()` means that the method has no paramters, which means users of the method are unable to feed arguments/data into the method.

Don't worry about these first parts of the code too much for now! We will explore classes and methods in further detail next week. This week, we will be working inside the `Main` class, which currently contains:

```c#
// Change the below line so that the program greets C# instead of the world (E.g., Hello, C#!)
Console.WriteLine("Hello, World!");
```

The first line of this part begins with `//`. This indicates that the line is a **comment** and can be ignored by the program. Comments are for us, the people working on the program code.

The second line is the one resposible for the output we saw in the activity. The `Console` part of this line is another class. It contains methods that we can use to interact with the console/terminal (again, more on classes and methods next week). The `.` is an operator that indicates we are going inside the `Console` class (to access a method that it contains). In this case, the method being accessed is the `WriteLine` method, which can be used to write a **string** to the console/terminal. A string is a data type that can be used to represent text. In C#, strings are usually enclosed in quotes: `"like this!"`. In our program code, the string `"Hello, World!"` is being passed as an argument into the `WriteLine` method and ultimately printed to the terminal when the program runs.

## Data Types

Computers work with data. In the previous activity, without the data `"Hello, World!"` we would have had nothing to print and our program would have been useless.

For a computer to work with data it needs to know what type of data it is dealing with. Data will need to be handled in different ways depending on whether it is **numberic**, **alphanumeric**, or **logical**.

### Numeric types

Numeric data is useful for calculations. In C#, the most used numeric types are:

- **int**. This type is suitable for positive or negative whole numbers, like: 2, 2097, and -5.
- **double**. This type is suitable for storing real numbers, like: 0.23, 1.5, 2097.01.
- **decimal**. This type is suitable for storing real numbers, like: 0.23, 1.5, 2097.01. It offers a higher degree of precision than double and is useful and is most commonly used when handling financial data (E.g., an interest rate of 2.625%).

If you're interest in learning more about the different numeric types in C#, this page provides further detail: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types.

### Alphanumeric types

Alphanumeric data is useful because we don't always want to be working with numbers! For example, when a user enters a password, they will enter a string of letters, numbers, and other symbols for a computer program to check.

In C#, the most used alphanumeric type is the **string** type. We have already seen an example of a string: `"Hello, World!"`. Another example is: `"A string with letters, but also numbers: 1, 2, 3, 4, and 5"`. Notice how all the examples use `""` to enclose the text.

### Logical types

Logical or boolean (**bool**) types can be in one of two states and are useful for implementing decison making logic. In C#, these states are `True` and `False`.

## Variables

Computers store data in **variables**. We can give variables names and assign data of a given type to them. Like this:

```c#
int myInt = 2097;
```
Notice how in the above code we:

- Specify the type of data that will be stored in the variable, using the keyword `int` and give the variable a name (`myInt`) so that we can identify it. This is called the variable **declaration**.
- And use the equals operators to store data in the variable: `= 2097`. This is known as **assigment**.

Before continuing, make sure your understand the essential data types explained above and practice using variables in [learning activity #2: Data Types & Variables](https://github.com/cyber-solutions-centre/intro-to-programming/tree/main/activities/2-types-and-variables).

A variable is a lot like a box with a label on it. We can change what we store in the box (i.e., the value of the variable), but there are limits on what we can store on the box also (i.e., the value must be a good fit and the correct type).

We can change the value of the `myInt` variable like this:

```c#
myInt = 99;
```

Notice how in the above code we do not declare the variable using the `int` keyword. This is because we have already done the declaration part, so the computer knows the type of the variable. We simply do the assignment part again to store a new value in the variable.

Complete [learning activity #3: Assignment Mismatch](https://github.com/cyber-solutions-centre/intro-to-programming/blob/main/activities/3-assignment-mismatch/README.md) to build your understanding of variables further and conclude this section.

## Operators and expressions

Being able to store data is great. But more often than not we want to be able to do things to the data. This is where **operators** come in.

C# has many operators that are supported by the built-in types we have just covered. In this section, we will look at the most important operators.

Note:

- The term **operand** is used when talking about the data or variable that an operator is acting on. So watch out for it in the following sections.
- The term **expression** refers to a sequence of operators and operands. In short, an expression does something! Exactly what depends on the operators and operands that make it up.

### Arithmetic operators (for numeric types)

Arithmetic operators can be applied to numeric types, including the `int`, `double`, and `decimal` types we have already covered.

You're probably somewhat familiar with the main arithmetic operators:

- `+`: This is the operator for addition.
- `-`: This is the operator for subtraction.
- `*`: This is the operator for multiplication.
- `/`: This is the operator for division.
- `%`: This is the remainder or modulo operator.

All of these operators are binary operators, which means they act on two operands. For example:

```c#
int x = 100;
int y = 50;

Console.WriteLine(x + y); // This will output 150.
Console.WriteLine(x - y); // This will output 50.
Console.WriteLine(x * y); // this will output 5000.
Console.WriteLine(x / y); // This will output 2.
Console.WriteLine(x % y); // This will output 0.
```

Experiment with this code yourself to confirm your understanding of the operators in [learning activity #4: Binary Arithmetic Operators.](https://github.com/cyber-solutions-centre/intro-to-programming/tree/main/activities/4-binary-arithmetic-operators).

Before moving on it is also worth noting that there are some unary (meaning they act on one operand) arithmetic operators that you're likely to come across:

- `++`: This is the increment operator. It can be used to increase a numeric value by 1.
- `--`: This is the decrement operator. It can be used to decrease a numeric value by 1.

For example:

```c#
// Declare and assign
int i = 5;
		
// Increment (and output)
i++;
Console.WriteLine(i); // This will output 6.
		
// Decrement (and output)
i--;
Console.WriteLine(i); // This will output 5.
```

### Comparison operators (for numeric types)

Comparison operators can be applied to numeric types, including the `int`, `double`, and `decimal` types we have already covered.

The main comparison operators for numeric types are as follows:

- `<`: This is the less than operator. It returns the `bool` value `true` if the value on the left is less than the value on the right, otherwise it returns `false`.
- `>`: This is the greater than operator. It returns the `bool` value `true` if the value on the left is greater than the value on the right, otherwise it returns `false`.
- `<=`: This is the less than or equal to operator. It returns the `bool` value `true` if the value on the left is less than or equal to the value on the right, otherwise it returns `false`.
- `>=`: This is the greater than or equal to operator. It returns the `bool` value `true` if the value on the left is greater than or equal to the value on the right, otherwise it returns `false`.

Complete [learning activity #5: Comparison Operators]() to build and demonstrate your understanding of comparison operators.

The `==` and `!=` operators can also be used to compare numeric types, but more on these shortly...

### Logical operators

Logical operators can be applied to the `bool` type and expressions that result in a `bool` type (E.g., `x < y`).

The main logical operators are as follows:

- `!`: This unary operator (NOT) computes the logical negation (or opposite) of an operand. If `bool isRunning = true`, then `!isRunning` will result in `false`.
- `&&`: This binary operator (AND) will return `true` only if both operands are `true`, otherwise it will return `false`.
- `||`: This binary operator (OR) will return `true` if either of the operands are `true`, only if both operands are `false` will it an expression evaluate to `false`.
- `^`: This binary operator (XOR) will return `true` if only one the operands is `true`, otherwise it will return `false`.

You might also come across `&` and `|` operators. These work in much the same way as the corresponding `&&` and `||` operators. The difference is that the `&&` and `||` operators only check the first value if necessary (E.g., if `x && y` and `x = false` there is no need to check the value of `y`). This is known as short circuiting and is generally advisable as it improves the efficiency of code.

Complete [learning activity #6: Logical Operators]() to build and demonstrate your understanding of logical operators.

### String interpolation

The `$` operator enables string interpolation, which is simply a way of incorporating values from variables or expressions into a `string`. Take a look at this example:

```c#
double a = 3;
double b = 4;

// The following will print the result of an interpolated string:
// Area of the right angle triangle with legs of 3 and 4 is 6.
Console.WriteLine($"Area of the right angle triangle with legs of {a} and {b} is {0.5 * a * b}");
```

Breaking this down:

- `$`: Modifies the behaviour of the string by enabling interpolation.
- `{a}`: Adds the value of a variable, `a`, into the interpolated string.
- `{b}`: Adds the value of a variable, `b`, into the interpolated string.
- `{0.5 * a * b}`: Adds the result of the expression into the interpolated string. The key point to note here is that the expression is evaluated before being included in the result string.

Complete [learning activity #6: String Interpolation]() to demonstrate your understanding of the `$` operator and string interpolation.

### Equality operators

The `==` and `!=` operators can be used to compare numeric types, but also the other types we have covered: `string` and `bool`.

The `==` operator checks for equality, returning `true` when the values to its left and right are equivalent (E.g., `1 == 1`), and returing `false` otherwise (E.g., 1 == 2).

The `!=` operator checks for a lack of equality, returning `true` when the values to its left and right are not equivalent (E.g., `3 != 4`), and returing `false` otherwise (E.g., 3 != 3).

Complete [learning activity #7: Equality Operators]() to demonstrate your understanding of these new operators see how they work when applied to different types.

## Finishing this session

Understanding the concepts covered in this session is vital as we will be building on them next week and making more advanced programs. To finish this session, take a look at [learning activity #8: The General Store].

Also, make sure to review the additional resources on the VLE as a part of your independent learning. 




