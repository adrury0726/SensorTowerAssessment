using FuzzySharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvertiserCompanies
{
    public class FindSimilarities
    {
        private readonly List<string> _companyNames;
        private readonly double _threshold;

        public FindSimilarities(List<string> companyNames, double threshold)
        {
            _companyNames = companyNames ?? throw new ArgumentNullException(nameof(companyNames));
            _threshold = threshold;
        }

        //Adding async/await logic to improve performance due to large file size.
        public async Task FindAndPrintSimilarNamesAsync()
        {
            var tasks = new List<Task>();

            //Outer loop to iterate through each company
            for (int i = 0; i < _companyNames.Count; i++)
            {
                //Inner loop using a different lambda notation so that we don't compare companies with themselves
                for (int j = i + 1; j < _companyNames.Count; j++)
                {
                    // Capture i and j values in the lambda to avoid out of range issues from asynchronous execution
                    int currentI = i;
                    int currentJ = j;

                    var task = Task.Run(() =>
                    {
                        double similarity = Fuzz.Ratio(_companyNames[currentI], _companyNames[currentJ]) / 100.0;

                        // If the similarity is above the threshold, print the similar companies
                        if (similarity >= _threshold)
                        {
                            Console.WriteLine($"Similar: {_companyNames[currentI]} <=> {_companyNames[currentJ]} (Similarity: {similarity * 100}%)");
                        }
                    });

                    tasks.Add(task);
                }
            }

            await Task.WhenAll(tasks); // Waits for all tasks to be completed
        }
    }
}
