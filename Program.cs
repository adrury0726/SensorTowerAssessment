using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvertiserCompanies
{
    internal class Program
    {
        //Using Task in order to try and optimize execution speed
        static async Task Main(string[] args)
        {
            List<string> companyNames = FileReader.LoadAndNormalizeCompanyNames();

            Console.WriteLine($"Loaded {companyNames.Count} company names.");

            double similarityThreshold = 0.90; //Range is from 0.0-1.0. 0.0 being no similarities and 1.0 being exact match. 
            FindSimilarities finder = new FindSimilarities(companyNames, similarityThreshold);

            await finder.FindAndPrintSimilarNamesAsync();
        }
    }
}
