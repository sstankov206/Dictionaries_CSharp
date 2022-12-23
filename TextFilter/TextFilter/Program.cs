/*  You are given a text and a string of banned words
 *  ▪ Replace all banned words in the text with asterisks
 *  
 *  Examples:
 *  
 *  INPUT:  Linux, Windows
 *          It is not Linux, it is GNU/Linux. Linux is merely the kernel, while 
 *          GNU adds the functionality...
 *          
 *  OUTPUT: It is not *****, it is GNU/*****. ***** is merely the kernel, while
 *          GNU adds the functionality...  
 *          
 * Solution by me, sstankov.
 */

using System;
class Program
{
    static void Main()
    {
        //set words to censor:
        string[] words = Console.ReadLine()
            .Split(", ");
        //set text via input, from which words will be replaced with censored text:
        string text = Console.ReadLine();

        //iterate through the text:
        for (int i = 0; i < words.Length; i++)
        {
            //for reach corresponding word, replace the banned word with censored text:
            text = text.Replace(words[i],
                new string('*', words[i].Length));
        }
        //printing output:
        Console.WriteLine(text);
    }
}
