using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // Query Expression.
            IEnumerable<int> scoreQuery = //query variable
                from score in scores //required
                where score > 80 // optional
                orderby score descending // optional
                select score; //must end with select or group

            // Execute the query to produce the results
            //foreach (int testScore in scoreQuery)
            //{
            //    Console.WriteLine(testScore);
            //}
            IEnumerator enumerator = scoreQuery.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
                // Perform logic on the item
            }

          
        }
    }
}
