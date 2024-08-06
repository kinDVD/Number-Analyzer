/*Task: Use conditional statements to automate the decision-making process.

What will the application do? 
1 Point: The application prompts the user to enter an integer between 1 and 100 inclusive..
Display the associated result based on the integer range entered.  

Build Specifications:
1 Point: Use if/else statements to take different actions depending on user input.  
Given an integer entered by a user, perform the following conditional actions:
1 Point: If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60.”
1 Point: If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25.”
1 Point: If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive.”
1 Point: If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.”
1 Point: If the integer entered is odd and greater than 60, print the number entered and “Odd and greater than 60.”

Additional Requirements:
1 Point: For answering the Lab Summary when submitting to the LMS
-2 Points: if there are any syntax errors or if the program does not run (for example, in a Main method). 

Challenge:
1 Point: Set up the program to continue running with a prompt at the end to see if they want to stop. (hint: Loops)
1 Point: Ask for user information (ex. name) at the beginning of the application, and use it to refer to the user throughout the application.
1 Point: Add validation to guarantee that a user enters a positive integer between 1 and 100.
 */

Console.WriteLine("Welcome to Analyze This! -the Number Analyzer app!");
Console.WriteLine();

Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine();

Console.WriteLine($"Welcome {name}. Analyze This! is here to help you determine if a number is odd or even and how said number relates to 60.");
Console.WriteLine();

bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Please enter a number between 1 and 100.");
    int axies = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (axies % 2 == 0 && axies > 0)
    {
        if (axies <= 24 && axies >= 2)
        {
            Console.WriteLine("Even and less than 25.");
            Console.WriteLine();
        }
        if (axies > 26 && axies <= 60)
        {
            Console.WriteLine("Even and between 26 and 60 inclusive.");
            Console.WriteLine();
        }
        if (axies > 60)
        {
            Console.WriteLine("Even and greater than 60");
            Console.WriteLine();
        }
    }
    else if (axies % 2 != 0 && axies <= 100 && axies > 0)
    {
        if (axies <= 59)
        {
            Console.WriteLine("Odd and less than 60.");
            Console.WriteLine();
        }
        if (axies > 60)
        {
            Console.WriteLine("Odd and greater than 60.");
            Console.WriteLine();
        }
    }
    else if (axies > 100 || axies <= 0)
    {
        Console.WriteLine("Please enter a valid number.");
        Console.WriteLine();
    }

    bool answer = true;
    while (answer = true)
    {
        Console.WriteLine($"Would you like to enter another number, {name}? y/n");
        string again = Console.ReadLine();
        Console.WriteLine();

        if (again == "y")
        {
            runProgram = true;
            break;
        }
        else if (again == "n")
        {
            Console.WriteLine($"Goodbye {name}.");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid selection, you donk.");
            Console.WriteLine();
            continue;
        }
    }
}