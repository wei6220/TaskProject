using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public class GetSumTask
    {
        /// <summary>
        /// 計算兩個整數的總和
        /// </summary>
        public int GetSum(int a, int b)
        {
            return new List<int> { a, b }.Sum();
        }

        public int GetSum2(int a, int b)
        {
            var q1 = a & b;
            var q2 = a ^ b;
            return (q1 > 0) ? GetSum2(q1 << 1, q2) : q2;
        }
    }
}
