using System;
using System.Collections.Generic;

namespace LinqExercise.Lib
{
    class SampleData
    {
        static List<Company> LoadSampleData()
        {
            return new List<Company> 
            { 
                new Company{ Name = "Apple",     Value = 15.50m, Date = new DateTime(2020, 07, 01) },
                new Company{ Name = "Microsoft", Value = 20,     Date = new DateTime(2020, 07, 01) },
                new Company{ Name = "Google",    Value = 30,     Date = new DateTime(2020, 07, 01) },
                new Company{ Name = "Nokia",     Value = 13.4m,  Date = new DateTime(2020, 07, 01) },
                new Company{ Name = "Microsoft", Value = 21,     Date = new DateTime(2020, 07, 02) },
                new Company{ Name = "Apple",     Value = 25,     Date = new DateTime(2020, 07, 02) },
                new Company{ Name = "Google",    Value = 14,     Date = new DateTime(2020, 07, 02) },
                new Company{ Name = "Google",    Value = 35,     Date = new DateTime(2020, 07, 03) },
                new Company{ Name = "Microsoft", Value = 35,     Date = new DateTime(2020, 07, 03) },
                new Company{ Name = "Nokia",     Value = 11,     Date = new DateTime(2020, 07, 03) },
                new Company{ Name = "IBM",       Value = 20,     Date = new DateTime(2020, 07, 04) },
                new Company{ Name = "William Hill", Value = 22,  Date = new DateTime(2020, 07, 04) },
                new Company{ Name = "Apple",     Value = 21,     Date = new DateTime(2020, 07, 04) },
                new Company{ Name = "Google",    Value = 30,     Date = new DateTime(2020, 07, 05) },
                new Company{ Name = "IBM",                       Date = new DateTime(2020, 07, 06) }
            };
        }
    }
}
