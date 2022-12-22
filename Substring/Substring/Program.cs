/* ▪ You are given a text and a remove word
 * ▪ Remove all substrings that are equal to the remove word
 * 
 * Examples:
 * 
 * INPUT:       key
 *              keytextkey
 *              
 * OUTPUT:      text
 * 
 * Solution by me, sstankov.
 */

using System;
class Program
{
    static void Main()
    {
        //reading input:
        string word = Console.ReadLine(); //word to remove
        string text = Console.ReadLine(); //string of text to remove word from

        int index = text.IndexOf(word);
        while (index >= 0)
        {
            //remove the  keyword ("word"),
            //starting at index and deleting as many characters as the word's length:
            text = text.Remove(index, word.Length);
            index = text.IndexOf(word);
        }
        //printing output:
        Console.WriteLine(text);
    }
}

