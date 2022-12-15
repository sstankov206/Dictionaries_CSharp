/* Write a program that keeps information about students and their grades. 
 * You will receive n pair of rows. First you will receive the student's name, 
 * after that you will receive his grade. Check if the student already exists 
 * and if not, add him. Keep track of all grades for each student.When you 
 * finish reading the data, keep the students with average grade higher than
 * or equal to 4.50. Order the filtered students by average grade in 
 * descending order.Print the students and their average grade in the 
 * following format:
 * 
 * {name} –> {averageGrade}
 * 
 * Format the average grade to the 2nd decimal place
 * 
 * Examples:
 * 
 * INPUT:  5
 *         John
 *         5.5
 *         John
 *         4.5
 *         Alice
 *         6
 *         Alice 
 *         3
 *         George
 *         5
 *         
 * OUTPUT:  John -> 5.00
 *          George -> 5.00
 *          Alice -> 4.50  
 *          
 * Solution by me, sstankov
 */

using System;
class Program
{
    static void Main()
    {
        //create dictionary to store students and their grades:
        var studentGrades = new Dictionary<string, List<double>>();

        //determine number of students:
        int n = int.Parse(Console.ReadLine());

        //iterate through students:
        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();//set name for each student
            double grade = double.Parse(Console.ReadLine()); //set grade for each student

            //check if student is NOT found in the dictionary:
            if (!studentGrades.ContainsKey(name))
            {
                studentGrades.Add(name, new List<double>()); //add student to dictionary & create a list of their grades
                studentGrades[name].Add(grade); //add their grade to the list (for each corresponding student)
            }
            else //if student is found in the dictionary:
            {
                studentGrades[name].Add(grade); //add their grade
            }
        }

        //getting average grade from list of grades:
        var averageResults = new Dictionary<string, double>();
        foreach (var pair in studentGrades) //iterate from previous dictionary (list of names and grade):
        {

            //for each corresponding student from the previous dictionary, add their name and the average of their grades to the new dictionary:
            averageResults.Add(pair.Key, pair.Value.Average());
        }

        //filter only students with grade above 4.50    
        // and sort by grade in descending order:
        foreach (var pair in averageResults.Where(student => student.Value >= 4.50)
                                       .OrderByDescending(student => student.Value))
        {
            //print output:
            Console.WriteLine($"{pair.Key} -> {pair.Value:F2}");
        }
    }
}