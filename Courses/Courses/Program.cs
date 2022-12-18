/* Write a program that keeps information about courses. 
 * Each course has a name and registered students. You will be receiving a course
 * name and a student name, until you receive the command "end". Check if such 
 * course already exists, and if not, add the course. Register the user into the 
 * course. When you receive the command "end", print the courses with their names 
 * and total registered users, ordered by the count of registered users in 
 * descending order. For each contest print the registered users ordered by name
 * in ascending order.
 * 
 * Input:
 * • Until the "end" command is received, you will be receiving input in the format:
 * "{courseName} : {studentName}".
 * • The product data is always delimited by " : "
 * 
 * Output:
 * • Print the information about each course in the following the format:
 * "{courseName}: {registeredStudents}"
 * • Print the information about each student, in the following the format:
 * "--{studentName}"
 * 
 * Solution by me, sstankov
 */

using System;
class Program
{
    static void Main()
    {
        //create dictionary to store the courses and students:
        var courses = new Dictionary<string, List<string>>();

        //read input:
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                break; //if input = "end", break the cycle
            }

            //get course name from input, by splitting w/ semi-colon & taking 1st index:
            string courseName = input.Split(" : ")[0];
            //get student name from input, by splitting w/ semi-colon & taking 2nd index:
            string studentName = input.Split(" : ")[1];

            //if course is NOT found in dictionary:
            if (!courses.ContainsKey(courseName))
            {
                //add the course & student:
                courses.Add(courseName, new List<string>());
                courses[courseName].Add(studentName);
            }
            else //if course IS found in dictionary:
            {
                //add new values for new students to the list within the course (key):
                courses[courseName].Add(studentName);
            }

            //iterate through the dictionary by courses w/ # of students in descending order:
            foreach (var pair in courses
                .OrderByDescending(course => course.Value.Count))
            {
                //print output:
                Console.WriteLine(pair.Key + " : " + pair.Value.Count);
                List<string> students = pair.Value;
                students.Sort(); //sort list of students by alphabetic order

                //print output of list of students per course:
                foreach (string student in students)
                {
                    Console.WriteLine("-- " + student);
                }
            }
        }
    }
}

