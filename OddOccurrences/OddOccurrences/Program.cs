/* Write a program that extracts all elements from a given
 * sequence of words that are present in it an odd number of
 * times (case-insensitive).
 * 
 * • Words are given on a single line, space separated.
 * • Print the result elements in lowercase, in their 
 *   order of appearance
 *   
 * Examples:
 * 
 * INPUT:       JAVA C# PHP PHP JAVA C java
 * OUTPUT:      java c# c
 * 
 * Solution must contain use of Dictionaries.
 * 
 * solution by me, sstankov.
 */

using System;

class Program
{
    static void Main()
    {
        //reading input, split by space:
        string[] words = Console.ReadLine().Split();

        //creating dictionary "counts" to count the occurrences of each word:
        Dictionary<string, int> counts = new Dictionary<string, int>();

        //iterate through the array and count each word:
        foreach (string word in words)
        {
            string wordInLowerCase = word.ToLower();
            if (counts.ContainsKey(wordInLowerCase)) //check if word already has occurred in array
            {
                counts[wordInLowerCase]++;
            }
            else
            {
                counts.Add(wordInLowerCase, 1);
            }
        }

        //iterate through the dictionary and print words that occur odd number of times:
        foreach (var count in counts)
        {
            if (count.Value % 2 != 0)
            {
                Console.Write(count.Key + " ");
            }
        }
    }
}

