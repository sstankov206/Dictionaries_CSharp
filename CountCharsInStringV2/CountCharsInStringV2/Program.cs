/* Write a program that counts all characters in a string except for space (' ').
 * Print all the occurrences in the following format:
 * {char} -> {occurrences}
 * 
 * Examples:
 * 
 * INPUT:       text
 * OUTPUT:      t -> 2
 *              e -> 1
 *              x -> 1
 *              
 * INPUT:       text text text
 * OUTPUT:      t -> 6
 *              e -> 3
 *              x -> 3
 *              
 * Solution by me, sstankov.
 */

using System;
class Program
{
    static void Main()
    {
        //read input:
        string text = Console.ReadLine();

        //create dictionary to store the characters/letters and their occurrences:
        Dictionary<char, int> charsCount = new Dictionary<char, int>();

        //iterate through the string of text:
        for (int i = 0; i < text.Length; i++)
        {
            //access each character the corresponding index:
            char symbol = text[i];

            //check if character equals empty/blank space:
            if (symbol == ' ')
            {
                continue;
            }

            //check if the letter has already occurred in the dictionary:
            if (charsCount.ContainsKey(symbol))
            {
                //increase number of its occurrences:
                charsCount[symbol]++;
            }
            else //if the letter has NOT occurred already:
            {
                charsCount.Add(symbol, 1); //set the letter's occurrence to 1
            }
        }

        //printing output:
        foreach (var pair in charsCount)
        {
            Console.WriteLine(pair.Key + " -> " + pair.Value);
        }
    }
}
