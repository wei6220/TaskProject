using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public class HammingWeightTask
    {
        /// <summary>
        /// Write a function that takes an unsigned integer and returns the number of '1' bits it has.
        /// For example:
        /// Input: 11
        /// Output: 3
        /// Explanation: Integer 11 has binary representation 00000000000000000000000000001011
        /// Input: 128
        /// Output: 1
        /// Explanation: Integer 128 has binary representation 00000000000000000000000010000000
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int HammingWeight(uint n)
        {
            //return Convert.ToString(n, 2).Count(e => e == '1');

            //11 /2 = 5 -- 1
            //5 / 2 = 2 -- 1
            //2 / 2 = 1 -- 0

            //128 / 2 = 64 --0
            //64 / 2 = 32 --0
            //32 / 2 = 16 --0
            //16 / 2 = 8 --0
            //8 / 2 = 4 --0
            //4 /2 = 2 --0
            //2 /2 = 1 --0

            int result = 0;
            while (n > 0)
            {
                if ((n % 2) > 0)
                    result++;
                n = n / 2;
            }
            return result;
        }
    }
}
