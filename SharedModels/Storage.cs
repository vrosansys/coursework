using System;
using System.Collections.Generic;

namespace SharedModels
{
    public static class Storage
    {
        private static List<Company> Company { get; set; }
        public static Random Rand { get; private set; }
        
        static Storage()
        {
            Company = new List<Company>();
            Rand = new Random();
        }
        
        public static void CreateRandomData()
        {
            Company.Clear();
            Company.AddRange(Rand.NextCompany());
        }
    }
}