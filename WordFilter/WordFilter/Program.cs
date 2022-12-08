/* ▪ Read a string array
 * ▪ Print only words, whose length is even
 * 
 * Examples:
 * 
 * INPUT:       kiwi orange banana apple
 * OUTPUT:      kiwi
 *              orange
 *              banana
 *
 * solution by me, sstankov.
 */


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //reading input:
        //Ex: kiwi orange banana
        string[] input = Console.ReadLine()
                        .Split()
                        .Where(word => word.Length % 2 == 0) //checks for even length of each word
                        .ToArray(); 

        //iterating thorugh each word in the array:
        foreach (string word in input)
        Console.WriteLine(word); //output
    } 
    
}


