# Introduction to Programming

## :mortar_board: Intended learning outcomes

At the end of the session you will be able to:

-	Explain the function and utility of variables, conditional statements, and loops.
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

There are lots of different programming languages, but don't worry! Programming languages have lots in common and learning a new programming language isn't comprable to learning a new natural language (E.g., Spanish).

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

Complete [learning activity #3: Assignment Mismatch]() to build your understanding of variables further and conclude this section.





