using System;

namespace FinalHandsOn3
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "A word is a speech sound or a combination of sounds, or its representation in writing, that symbolizes and communicates a meaning";
            string example2 = "A word is a speech sound or a combination of sounds, or its representation in writing, that symbolizes and communicates a meaning";
            Console.WriteLine(example.IndexOf("word")); //returns the first time what you put in occurs in the string
            Console.WriteLine(example.Substring(example.Length/2)); //returns a peice of the string that you determine
            Console.WriteLine(example.Contains("word")); //returns if your string contains what you enter
            Console.WriteLine(example.Equals(example2)); //sees if your strings are equal
            Console.WriteLine(example.CompareTo(example2)); //determines if two strings have the same value by returning an int
            Console.WriteLine(example.EndsWith("meaning")); //determines if what you enter is what the string ends with
            Console.WriteLine(example.Trim('A')); //removes trailing and leading spaces or a character that you enter
            Console.WriteLine(example.PadLeft(150,'*')); //adds specified number of characters or spaces on the left(the number you enter has to include the length of the string as well or nothing will happen)
            Console.WriteLine(example.PadRight(150,'*'));//adds specified number of characters or spaces on the right(the number you enter has to include the length of the string as well or nothing will happen)
            Console.WriteLine(example.Replace('a','7'));//replaces all instaces of something with something else
            Console.WriteLine(example.Remove(0,10)); //removes the designated part of the string
            Console.WriteLine(example.ToUpper()); //makes the string uppercase
            //none of them they return a new string
            //you can use Substring to get the character in a certain position
            Console.WriteLine(example.Substring(10,1));
            Console.WriteLine(example.Substring(25, 1));
        }
    }
}
