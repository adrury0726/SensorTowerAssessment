using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdvertiserCompanies
{
    public class FileReader
    {
        public static List<string> LoadAndNormalizeCompanyNames()
        {
            //I'd rather do a dynamic way of reading the file path, but just going to hardcode for now.

            string filePath = @"C:\Users\Aaron Drury\OneDrive\Desktop\AssessmentProject\AdvertiserCompanies\TextFiles\AdvertiserCompanies.txt";

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file at {filePath} was not found.");
            }

            //This is going to read all company names, normalize them, then return the list of names
            return File.ReadAllLines(filePath).Select(CompanyNormalize.Normalize).ToList();
        }
    }
}
