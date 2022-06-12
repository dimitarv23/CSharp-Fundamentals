using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmdArgs = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = cmdArgs[0];
                string employeeID = cmdArgs[1];

                if (companies.ContainsKey(companyName))
                {
                    if (!companies[companyName].Any(e => e == employeeID))
                    {
                        companies[companyName].Add(employeeID);
                    }
                }
                else
                {
                    companies.Add(companyName, new List<string>() { employeeID });
                }

                input = Console.ReadLine();
            }

            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
