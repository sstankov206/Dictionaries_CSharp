/*You are given two lines – the first one can be a really big number (0 to 1050).
 * The second one will be a single digit number (0 to 9). You must display the 
 * product of these numbers. 
 * Note: Do NOT use the BigInteger class
 * 
 * Examples:
 * 
 * INPUT:       9999
 *              9
 *              
 * OUTPUT:      89991
 * 
 * Solution by me, sstankov.
 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        //reading input:
        string reallyBigNumber = Console.ReadLine();
        int number = int.Parse(Console.ReadLine()); //multiplier

        //check if multiplier number is ZERO (0):
        if (number == 0)
        {
            Console.WriteLine(0);
            return;
        }

        //trim leading zeroes (Ex: 001234 => 1234 ):
        while (reallyBigNumber[0] == '0')
        {
            reallyBigNumber = reallyBigNumber.Substring(1);
        }

        //storing result:
        StringBuilder sb = new StringBuilder();
        int remainder = 0;

        //iterate through the input, backwards:
        for (int i = reallyBigNumber.Length - 1; i >= 0; i--)
        {
            //multiply each corresponding number by the multiplier:
            int result = int.Parse(reallyBigNumber[i].ToString()) * number + remainder;
            remainder = 0;

            //check if multiplication produces a remainder:
            if (result > 9)
            {
                remainder = result / 10; //takes the 1st number (carry the one)
                result = result % 10;
            }

            //append the result:
            sb.Append(result);

            //check if remainder is NOT = 0 (zero):
            if (remainder != 0)
            {
                sb.Append(remainder);
            }
        }

        //result is printed in reverse order
        //creating new StringBuilder variable to store result in correct order:
        StringBuilder finalResult = new StringBuilder();
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            finalResult.Append(sb[i]);
        }

        //printing output:
        Console.WriteLine(finalResult);
    }
}

