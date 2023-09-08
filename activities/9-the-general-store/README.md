# Learning activity #9: The General Store

In this activity you are going work on a program that is a bit more complex. It uses some C# features that we will look at in more detail next week.

That said, the program is far from perfect. There are many ways it could be improved to benefit the end user and to make the code easier to maintain.

Follow the steps below to complete the activity and begin improving this program. We will return to this program in next weeks lab.

Note that this is learning actvitiy #9, and it is assumed you have already created a local version of this repository in learning activity #1.

## 👣 Steps

1. Navigate to **activities/9-the-general-store/src** using the explorer and open the **Program.cs** file.

</br>

2. Examine the contents of the file. What do you think it will happen when we run this program?

</br>

3. Run the program. Remember, to do this, open a new terminal (`CTRL` + `SHIFT` + `'`), navigate to **activities/9-the-general-store/src** (`cd activities/9-the-general-store/src`), and enter: `dotnet run`. Is the result what you were expecting?

</br>

4. The program contains a logical error. In most cases, it will run fine without crashing or returning an error message, but it will operate incorrectly some of the time and fail silently. Examine the code again to see if you can find and fix this logical error.

</br>

<details>
    
<summary>Hint</summary>

---

When you ran the program in step 3, did you notice the warnings that were displayed?

The `warning CS0219: The variable 'presentPrice' is assigned but its value is never used` provides a hint as to what the logical error is.

---

</details>

