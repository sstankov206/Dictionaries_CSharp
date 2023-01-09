/* Explosions are marked with '>'. Immediately after the mark, there will be an integer,
 * which signifies the strength of the explosion.
You should remove x characters (where x is the strength of the explosion),
starting after the punch character ('>').

If you find another explosion mark ('>') while you’re deleting characters, you
should add the strength to your previous explosion.
When all characters are processed, print the string without the deleted characters.
You should not delete the explosion character – '>', but you should delete the
integers, which represent the strength.

Input:
You will receive single line with the string.

Output:
Print what is left from the string after explosions.

Constraints:
• You will always receive a strength for the punches
• The path will consist only of letters from the Latin alphabet, integers and the char '>'
• The strength of the punches will be in the interval [0...9]

Examples:

INPUT:          pesho>2sis>1a>2akarate>4hexmaster
OUTPUT:         pesho>is>a>karate>master

Solution by me, sstankov.
*/

using System;
using System.Text;

class Program
{
    static void Main()
    {
        //reading input:
        string input = Console.ReadLine();

        //create StringBuilder to store chars to delete in the explosion:
        StringBuilder sb = new StringBuilder();

        //determine explosion's power by selecting the number after ">" symbol:
        int power = 0;

        //iterate through input:
        for (int i = 0; i < input.Length; i++)
        {
            //set current character:
            char current = input[i];

            if (current == '>') //where ">" signifies explosion:
            {
                //set the power of the explosion:
                power += int.Parse(input[i + 1].ToString());
                sb.Append(current);
            }
            else if (power == 0) //after the explosion, append current chars:
            {
                sb.Append(current);
            }
            else //else, decrease the power after the iteration:
            {
                power--;
            }
        }
        //printing output:
        Console.WriteLine(sb);
    }
}

