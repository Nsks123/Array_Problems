using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string reversedString = ReverseEachWord(input);
        Console.WriteLine("Reversed String: " + reversedString);
        Console.ReadLine();
    }
    static string ReverseEachWord(string input)
    {
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = ReverseString(words[i]);
        }
        string reversedString = string.Join(" ", words);
        return reversedString;
        Console.ReadLine();
    }
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
        Console.ReadLine();

    }
}
