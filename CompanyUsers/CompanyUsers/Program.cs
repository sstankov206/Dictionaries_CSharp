/* Write a program that keeps information about companies and their employees.
 * You will be receiving a company name and an employee's id, until you receive
 * the command "End" command. Add each employee to the given company. Keep in 
 * mind that a company cannot have two employees with the same id. When you 
 * finish reading the data, order the companies by the name in ascending order. 
 * Print the company name and each employee's id in the following format:
 * 
 * {companyName}
 * --{id1}
 * --{id2}
 * --{idN}
 * 
 * Input / Constraints
 * •Until you receive the "End" command, you will be receiving input in the format:
 * "{companyName} -> {employeeId}".
 * •The input always will be valid.
 * 
 *Solution by me, sstankov
 */

using System;
class Program
{
    static void Main()
    {
        //create sorted dictionary to store names of companies in alphabetic order:
        var companies = new SortedDictionary<string, List<string>>();

        //while input ISN'T = "end" :
        while (true)
        {
            string input = Console.ReadLine(); //read input
            if (input == "End") //check if input == "end"
            {
                break;
            }
            //get company name via input, by splitting by arrow and grabbing the 1st index:
            string name = input.Split(" -> ")[0];
            //get the ID of the employee from input, by splitting by arrow and grabbing the 2nd index:
            string id = input.Split(" -> ")[1];

            //if company name is NOT found in the dictionary:
            if (companies.ContainsKey(name))
            {
                //add the company & the employee ID :
                companies.Add(name, new List<string>());
                companies[name].Add(id);
            }
            else //if company IS found in the dictionary:
            {
                //check if the ID is found in the list:
                List<string> ids = companies[name];
                if (!ids.Contains(id)) //if NOT found:
                {
                    companies[name].Add(id); //add the ID
                }
            }
        }

        //printing output:
        foreach (var pair in companies)
        {
            Console.WriteLine(pair.Key);
            foreach (string id in pair.Value)
            {
                Console.WriteLine(" -- " + id);
            }
        }
    }
}

