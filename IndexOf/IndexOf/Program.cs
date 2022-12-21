/* Check how many times a given word is contained in a string of text.
 * 
 * Solution by me, sstankov.
 */

using System;
class Program
{
    static void Main()
    {
        //read input:

        string word = Console.ReadLine(); //this will be the word we're looking for
        string text = Console.ReadLine();

        //setting up the start index to be zero:
        int startIndex = 0;

        while (text.IndexOf(word, startIndex) > -1)
        {
            startIndex = text.IndexOf(word, startIndex) + 1;

            //print output:
            Console.WriteLine($"{word} found at {startIndex}");
        }
    }
}

