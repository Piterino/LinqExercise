using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using LinqExercise.Lib;

namespace LinqExercise
{
    class Program
    {
        private static readonly List<Company> CompanyList = SampleData.LoadSampleData();

        static void Main(string[] args)
        {
            //var companiesByValue = SortCompaniesByValue(CompanyList);
            //PrintListOfCompanies(companiesByValue);

            PrintListOfCompaniesSortedByTotalValue(CompanyList);
        }



        private static void PrintListOfCompaniesSortedByTotalValue(List<Company> companies)
        {
            IEnumerable<IGrouping<string, Company>> groupedCompanies = companies
                .GroupBy(c => c.Name)
                .OrderByDescending(c => c.Sum(d => d.Value));
            foreach (IGrouping<string, Company> company in groupedCompanies)
            {
                Console.WriteLine("{0,-12} : {1,-8} : {2,0}\n", company.Key, "Total value", company.Sum(c => c.Value));
                foreach (var day in company)
                {
                    Console.WriteLine(
                        "{0,-12:dd/mm/yyyy} : {1,-8} : {2,0}",
                        day.Date, "Value", day.GetVal()
                        );
                }
                Console.WriteLine();
            }
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
