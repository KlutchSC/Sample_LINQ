﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Sample_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Three Parts of a LINQ Query:
            //  1. Data source.
            var numbers = new [] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // 3. Query execution.
            foreach (var num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }

            // call .ToList or .ToArray to execute the query in one line
            List<int> numQuery2 = (from num in numbers
                                   where (num % 2) == 0
                                   select num).ToList();
        }
    }
}
