using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] parts = input.Split(" -> ");
            string companyName = parts[0];
            string employeeId = parts[1];

            if (!companies.ContainsKey(companyName))
            {
                companies[companyName] = new List<string>();
            }

            if (!companies[companyName].Contains(employeeId))
            {
                companies[companyName].Add(employeeId);
            }
        }

        foreach (var company in companies)
        {
            Console.WriteLine(company.Key);

            foreach (var employeeId in company.Value)
            {
                Console.WriteLine($"-- {employeeId}");
            }
        }
    }
}