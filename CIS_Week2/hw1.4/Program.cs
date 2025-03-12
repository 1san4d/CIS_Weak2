/*Homework 4: Is Palindrome Array
● Read N, then N integers for an Array. Call a function with the array to check if
the array is palindrome or note
○ We already coded it before
○ Just copy code and rearrange to call function with array*/
using System;
using System.Reflection.Metadata.Ecma335;
System.Console.Write("Enter how many numbers you gonna enter: ");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter numbers to see if they are Palindrome: ");
int [] numbers = new int [n];
for (int i = 0; i < n; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
checkPalindrome(numbers);
static void checkPalindrome(int[] arr)
{
    bool isPalindrome = true;
    for (int i = 0; i < arr.Length / 2; i++) // 1 2 1 2 3 2 1 2 1 five loops
    {
        if (arr[i] != arr[arr.Length - 1 - i])
        {
            isPalindrome = false;
            break;
        }
    }
    if (isPalindrome)
    {
        Console.WriteLine("The array is a palindrome.");
    }
    else
    {
        Console.WriteLine("The array is not a palindrome.");
    }
}
Console.ReadLine();