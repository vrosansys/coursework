using System;
using System.Collections.Generic;

namespace SharedModels
{
    public static class AppData
    {
        public static readonly List<Company> Companies;
        private static Random Rand { get; set; }
        
        static AppData()
        {
            Companies = new List<Company>();
            Rand = new Random();
        }
        
        public static void CreateRandomData()
        {
            Companies.Clear();
            Companies.AddRange(Rand.NextCompanies(12,2));
        }
        
        public static void PrintCompaniesDataToConsole()
        {
            foreach (var data in Companies)
            {
                Console.WriteLine($"Company: {data.Name} has {data.EmployersNumber} Employers and {data.ProjectNumber} Projects with {data.Budget}$ Budget");
            }
        }
        
    }
}