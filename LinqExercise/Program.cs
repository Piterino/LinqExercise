using System;
using System.Collections.Generic;
using System.Linq;
using LinqExercise.Lib;

namespace LinqExercise
{
    class Program
    {
        private static readonly List<Company> CompanyList = SampleData.LoadSampleData();

        static void Main(string[] args)
        {
            var companiesByValue = SortCompaniesByValue(CompanyList);
            PrintListOfCompanies(companiesByValue);
        }

        private static List<Company> SortCompaniesByValue(List<Company> companies)
        {
            List<Company> result = companies
                .Where(c => c.Value != null)
                .OrderBy(c => c.Value)
                .ToList();
            return result;
        }

        private static void PrintListOfCompanies(List<Company> companies)
        {
            var header = String.Format(
                "{0,-16}{1,-8}{2,0}\n",
                "Company", "Value", "Date"
                );
            Console.WriteLine(header);
            companies.ForEach(c =>
            {
                Console.WriteLine(string.Format(
                    "{0,-16}{1,-8}{2,0:dd/mm/yyyy}",
                    c.Name, c.GetVal(), c.Date
                    ));
            });
        }
    }

    static class CompanyExtensions
    {
        internal static string GetVal(this Company cmp)
        {
            return cmp.Value == null ? "NULL" : cmp.Value.ToString();
        }
    }
}
