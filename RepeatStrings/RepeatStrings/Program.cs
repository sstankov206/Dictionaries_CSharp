/* Read an array from strings
 * Repeat each word N times, where N is the length of the word.
 * 
 * Examples:
 * 
 * INPUT:       hi abc add
 * OUTPUT:      hihiabcabcabcaddaddadd
 * 
 * Solution by me, sstankov.
 */

using System;
class Program
{
    static void Main()
    {
        //read an array from strings, split by space:
        string[] words = Console.ReadLine().Split();

        //iterate through the array and repeat each word
        //as many times as its length:

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words[i].Length; j++)
            {
                //print output:
                Console.Write(words[i]);
            }
        }
    }
}
