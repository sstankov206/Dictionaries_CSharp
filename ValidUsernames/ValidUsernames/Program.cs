/* Write a program that reads user names on a single line (joined by ", ")
 * and prints all valid usernames.

A valid username is:
• Has length between 3 and 16 characters
• Contains only letters, numbers, hyphens and underscores

Examples:

INPUT:      Jeff, john45, ab, cd, peter-ivanov, @smith
OUTPUT:     Jeff
            John45
            peter-ivanov

Solution by me, sstankov
*/

using System;
class Program
{
    static void Main()
    {
        //read input, splitting by comma & space & removing empty space:
        var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

        //create list to store valid usernames:
        var validUsernames = new List<string>();

        //iterate through array of usernames/input:
        for (int i = 0; i < input.Length; i++)
        {
            string current = input[i];
            //check if current username is valid:
            if (current.Length >= 3 && current.Length <= 16) //checks for valid length
            {
                bool isValid = true;
                //iterate through the current username:
                for (int j = 0; j < current.Length; j++)
                {
                    //check if username is NOT made up of letters & digits:
                    if (!(char.IsLetterOrDigit(current[j]) || current[j] == '-' || current[j] == '_'))
                    {
                        isValid = false;
                    }
                }
                //if username IS valid:
                if (isValid)
                {
                    validUsernames.Add(current); //add to list of valid usernames
                }
            }
        }

        //printing output:
        Console.WriteLine(String.Join(Environment.NewLine, validUsernames)); ;
    }
}
