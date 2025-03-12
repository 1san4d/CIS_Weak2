/*Homework 3: Calculator
● Develop a function that allows user to do the following (menu options):
○ Add 2 numbers
○ Subtract 2 numbers
○ Multiply 2 numbers
○ Divide 2 numbers
○ End the program
● Consider the following functions:
○ Function to read 2 double numbers - by reference
○ 4 functions, one for each operation. Don’t divide by zero!
○ Function to display the menu of the 5 options - read number and return it.
■ User should enter number from 1 to 5. If not, display error message
■ If exit, end the program by printing how many operations were done
*/
using System;
static void OperationsDisplay(){
    Console.WriteLine("1. Add 2 numbers");
    Console.WriteLine("2. Subtract 2 numbers");
    Console.WriteLine("3. Multiply 2 numbers");
    Console.WriteLine("4. Divide 2 numbers");
    Console.WriteLine("5. End the program");
}
OperationsDisplay();
static void ReadNumbers(out double num1, out double num2){ // Function to read 2 double numbers
    Console.WriteLine("Enter the first number: "); 
    num1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter the second number: ");
    num2 = double.Parse(Console.ReadLine());
} 
static void AddNumbers(ref double num1, ref double num2){ // Function to add 2 numbers
    double sum = num1 + num2;
    Console.WriteLine("The sum of the two numbers is: " + sum);
}
static void SubtractNumbers(ref double num1, ref double num2){ // Function to subtract 2 numbers
    double difference = num1 - num2;
    Console.WriteLine("The difference of the two numbers is: " + difference);
}
static void MultiplyNumbers(ref double num1, ref double num2){ // Function to multiply 2 numbers
    double product = num1 * num2;
    Console.WriteLine("The product of the two numbers is: " + product);
}
static void DivideNumbers(ref double num1, ref double num2){ // Function to divide 2 numbers
    if(num2 == 0){
        Console.WriteLine("Cannot divide by zero");
    }
    else{
        double quotient = num1 / num2;
        Console.WriteLine("The quotient of the two numbers is: " + quotient);
    }
}
int count = 0;
while (true)
{
    Console.WriteLine("Enter a number from 1 to 5: ");
    int choice = int.Parse(Console.ReadLine());
    if (choice == 1)
    {
        double num1, num2;
        ReadNumbers(out num1, out num2);
        AddNumbers(ref num1, ref num2);
        count++;
    }
    else if (choice == 2)
    {
        double num1, num2;
        ReadNumbers(out num1, out num2);
        SubtractNumbers(ref num1, ref num2);
        count++;
    }
    else if (choice == 3)
    {
        double num1, num2;
        ReadNumbers(out num1, out num2);
        MultiplyNumbers(ref num1, ref num2);
        count++;
    }
    else if (choice == 4)
    {
        double num1, num2;
        ReadNumbers(out num1, out num2);
        DivideNumbers(ref num1, ref num2);
        count++;
    }
    else if (choice == 5)
    {
        Console.WriteLine("The number of operations done is: " + count);
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number from 1 to 5.");
    }
}
Console.ReadLine();