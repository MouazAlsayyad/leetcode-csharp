using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___Hashing.ProductOfArrayExceptSelf
{
    internal static class SolutionProductOfArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            // int[] prefix = new int[nums.Length];
            // int[] postfix = new int[nums.Length];
            // int[] output = new int[nums.Length];
            // for (int i = 0; i<nums.Length;i++)
            // {
            //     prefix[i] = nums[i] * (i != 0 ? prefix[i - 1] : 1);
            //     postfix[i] = nums[i] * (i == nums.Length - 1 ? 1 : postfix[i + 1]);
            // }
               
               
            // for (int i = nums.Length - 1; i >= 0; i--)
            //     output[i] = (i == 0 ? 1 : prefix[i - 1]) * (i == nums.Length - 1 ? 1 : postfix[i+1]);
            // return output;


            int n = nums.Length;
            int[] output = new int[n];

            // Calculate prefix product
            output[0] = 1;
            for (int i = 1; i < n; i++)
            {
                output[i] = output[i - 1] * nums[i - 1];
            }

            // Calculate postfix product
            int postfix = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                output[i] *= postfix;
                postfix *= nums[i];
            }

            return output;
        }
    }
}
