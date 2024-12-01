using System.Linq;

namespace AdvertiserCompanies
{
    public class CompanyNormalize
    {
        public static string Normalize(string name)
        {
            return new string(name.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        }
    }
}
