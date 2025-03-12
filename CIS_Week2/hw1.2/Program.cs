//Homework 2: Reverse a string
//● Develop a function that do reverse for the string. Function is:
//● string reverse_str(const string & str);
//○ Don’t try to change str content or you will get compilation error
using System;
System.Console.WriteLine("Enter a string to reverse: ");
string input = Console.ReadLine();
System.Console.WriteLine("Reversed string: " + reverse_str(input));

static string reverse_str(string str)
{
    char [] charArray = str.ToCharArray(); // basically i took the entered string and turned it into a char array
    Array.Reverse(charArray); // then i reversed the char array
    return new string (charArray); // then i returned the reversed char into a string
}
