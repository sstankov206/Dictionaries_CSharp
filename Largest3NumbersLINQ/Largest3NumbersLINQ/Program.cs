/* Read a list of integers and print the largest 3 of them. If there are less 
 * than 3, print all of them.
 * Print them in descending order.
 * 
 * Examples:
 * 
 * INPUT:       10 30 15 20 50 5
 * OUTPUT:      50 30 20
 * 
 * INPUT:       20 30
 * OUTPUT:      30 20
 * 
 * MUST order the array using a LINQ query!
 * 
 * Solution by me, sstankov.
 */

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //reading an array of integers from input, order them by descending:
        int[] input = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .OrderByDescending(x=>x)
                             .ToArray();

        //print the largest 3 numbers, if there are less than 3, print all:
        int count = input.Length >= 3 ? 3 : input.Length;
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{input[i]} "); //output
        }
        
    }

}
