/* Write a program that returns an encrypted version of the same text. Encrypt 
 * the text by shifting each character with three positions forward. For example 
 * A would be replaced by D, B would become E, and so on. Print theencrypted text.
 * 
 * Example:
 * 
 * INPUT:   Programming is cool!
 * OUTPUT:  Surjudpplqj#lv#frro$
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
        //store encrypted text:
        string encrypted = String.Empty;

        //iterate through the text:
        for (int i = 0; i < text.Length; i++)
        {
            //iterate through each index & shift/add 3:
            encrypted += (char)text[i] + 3;
        }

        //print output:
        Console.WriteLine(encrypted);
    }
}

