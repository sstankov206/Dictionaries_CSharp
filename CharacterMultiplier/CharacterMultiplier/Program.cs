/* Create a method that takes two strings as arguments and returns the sum of 
 * their character codes multiplied
(multiply str1[0] with str2[0] and add to the total sum). Then continue with the
next two characters. If one of the strings is longer than the other, add the
remaining character codes to the total sum without multiplication.
 * 
 * Examples:
 * 
 * INPUT:    Gosho Pesho
 * OUTPUT:   53253
 * 
 * INPUT:    123 522
 * OUTPUT:   7647
 * 
 * Solution by me, sstankov
 */

using System;
class Program
{
    static void Main()
    {
        //read input, split by space and remove empty entries:
        var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        //invoke the CharMultiplier method, print output:
        Console.WriteLine(CharMultiplier(input[0], input[1]));
    }

    //create method that takes 2 strings as input, and returns integer as the output:
    static int CharMultiplier(string first, string second)
    {
        int sum = 0; //will store the sum at the end

        string longest = ""; //will store the longer string
        string shortest = ""; //will store the shorter string

        //check which is the longer string:
        if (first.Length > second.Length)
        {
            longest = first;
            shortest = second;
        }
        else
        {
            longest = second;
            shortest = first;
        }

        //iterate through the shorter string's length:
        for (int i = 0; i < shortest.Length; i++)
        {
            //add  the result of multiplied chars to the sum:
            sum += shortest[i] * longest[i];
        }

        //iterate through the remaining chars of the longer string:
        for (int i = shortest.Length; i < longest.Length; i++)
        {
            sum += longest[i]; //add remaining chars to the sum
        }

        return sum;
    }
}