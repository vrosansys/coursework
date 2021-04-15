using System;

namespace SharedModels
{
    public static class RandomExtension
    {
        private static string[] CompanyNames;
        
        static RandomExtension()
        {
            CompanyNames = new string[]
            {
                "Plarium", "Google", "Samsung", "LG", "Apple", "Nokia"
            };
            
        }
        
        public static Company NewCompany(this Random rand)
        {
            return new()
            {
                Name = CompanyNames[rand.Next(0, CompanyNames.Length)],
                Budget = rand.Next(10000, 1000000),
                EmployersNumber = rand.Next(50, 500),
                ProjectNumber = rand.Next(1, 20)
            };
        }
        
        public static Company[] NextCompany(this Random rand)
        {
            var company = new Company[rand.Next(2, 12)];
            for (int i = 0; i < company.Length; i++)
            {
                company[i] = rand.NewCompany();
            }

            return company;
        }
        
    }
}