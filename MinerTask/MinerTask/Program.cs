/* You will be given a sequence of strings, each on a new line. Every odd line
 * on the console is representing a resource (e.g. Gold, Silver, Copper, and
 * so on) and every even - quantity. Your task is to collect the resources and 
 * print them each on a new line.
 * 
 * Print the resources and their quantities in the following format:
 * {resource} –> {quantity}
 * The quantities will be in the range [1... 2 000 000 000]
 * 
 * Examples:
 * 
 * INPUT:   Gold
 *          155
 *          Silver
 *          10
 *          Copper
 *          17
 *          stop
 *          
 * OUTPUT:  Gold  -> 155
 *          Silver -> 10
 *          Copper -> 17
 *          
 * Solution by me, sstankov
 */

using System;
class Program
{
    static void Main()
    {
        //create dictionary to store resources and their quantities:
        Dictionary<string, int> resourceQuantity = new Dictionary<string, int>();

        while (true)
        {
            //read input:
            string resource = Console.ReadLine();
            //check if input equals "stop" :
            if (resource == "stop")
            {
                break;
            }
            //reading quantity set up via input:
            int quantity = int.Parse(Console.ReadLine());

            //if resource already exists:
            if (resourceQuantity.ContainsKey(resource))
            {
                //increase current quantity by adding newly given value:
                resourceQuantity[resource] += quantity;
            }
            else //if resource doesn't yet exist:
            {
                //add the resource and its quantity:
                resourceQuantity.Add(resource, quantity);
            }
        }
        //iterate through the dictionary:
        foreach (var pair in resourceQuantity)
        {
            //print output:
            Console.WriteLine(pair.Key + " -> " + pair.Value);
        }
    }
}
