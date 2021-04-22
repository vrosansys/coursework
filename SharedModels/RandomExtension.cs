using System;

namespace SharedModels
{
    public static class RandomExtension
    {
        private static readonly string[] _companyNames;
        
        static RandomExtension()
        {
            _companyNames = new string[]
            {
                "Plarium", "Google", "Samsung", "LG", "Apple", "Nokia"
            };
            
        }
        
        public static Company NextCompany(this Random rand)
        {
            return new()
            {
                Name = _companyNames[rand.Next(0, _companyNames.Length)],
                Budget = rand.Next(10000, 1000000),
                EmployersNumber = rand.Next(50, 500),
                ProjectNumber = rand.Next(1, 20)
            };
        }
        
        public static Company[] NextCompanies(this Random rand, int maxCompanies,int minCompanies)
        {
            var company = new Company[rand.Next(minCompanies, maxCompanies)];
            for (int i = 0; i < company.Length; i++)
            {
                company[i] = rand.NextCompany();
            }

            return company;
        }
        
    }
}