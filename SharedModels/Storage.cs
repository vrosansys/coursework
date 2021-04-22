using System;
using System.Collections.Generic;

namespace SharedModels
{
    public static class Storage
    {
//        private static List<Company> Company { get; set; }
        public static readonly List<Company> AppData;
        private static Random Rand { get; set; }
        
        static Storage()
        {
            AppData = new List<Company>();
            Rand = new Random();
        }
        
        public static void CreateRandomData()
        {
            AppData.Clear();
            AppData.AddRange(Rand.NextCompanies(12,2));
        }
        
        public static void PrintCompaniesDataToConsole()
        {
            foreach (var data in AppData)
            {
                Console.WriteLine($"Company: {data.Name} has {data.EmployersNumber} Employers and {data.ProjectNumber} Projects with {data.Budget}$ Budget");
            }
        }
        
    }
}