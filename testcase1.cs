using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Remove_Element_leetcode_problem_2
{
    public class testcase1
    {
        public async Task TestcaseAsync()
        {
            await Task.Delay(1000);
            var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var val = 2;
            var k = 0;
            foreach (var num in nums)
            {
                if (num != val)
                {
                    nums[k] = num;
                    k++;
                }
            }
            Console.WriteLine(k);
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(nums));
        }
    }
}