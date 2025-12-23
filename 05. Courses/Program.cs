using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> courses =
            new Dictionary<string, List<string>>();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] parts = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

            string courseName = parts[0];
            string studentName = parts[1];

            if (!courses.ContainsKey(courseName))
            {
                courses[courseName] = new List<string>();
            }

            courses[courseName].Add(studentName);
        }

        foreach (var course in courses)
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count}");

            foreach (var student in course.Value)
            {
                Console.WriteLine($"-- {student}");
            }
        }
    }
}