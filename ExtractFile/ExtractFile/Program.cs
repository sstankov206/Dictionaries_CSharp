/* Write a program that reads the path to a file and subtracts the file name 
 * and its extension.
 * 
 * Examples:
 * 
 * INPUT:       C:\Internal\training-internal\Template.pptx
 * OUTPUT:      File name: Template
 *              File extension: pptx
 *              
 *Solution by me, sstankov.
 */

using System;
class Program
{
    static void Main()
    {
        //reading input, split by "\" & remove empty space :
        var input = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);

        //set last element of the array to be the file's name, split by "."
        var file = input[input.Length - 1].Split('.'); //Ex: Template.pptx

        //printing output:
        Console.WriteLine($"File name: {file[0]}");
        Console.WriteLine($"File extension: {file[1]}");


    }
}

