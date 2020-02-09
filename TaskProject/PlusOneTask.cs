using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public class PlusOneTask
    {
        /// <summary>
        /// 給一包含非數整數的陣列，其中每一個值代表該位數的值，對這個陣列加1。
        /// 
        /// Test Case:
        ///     Input: [1,2,3]
        ///     Output: [1,2,4]
        /// 
        /// Test Case:
        ///     Input: [4,3,2,1]
        ///     Output: [4,3,2,2]
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public int[] PlusOne(int[] inputs)
        {
            var list = new List<int>();
            int plusNum = 1;
            inputs.Reverse().ToList().ForEach(e =>
            {
                var sum = e + plusNum;
                list.Insert(0, sum % 10);
                plusNum = sum / 10;
            });
            if (plusNum > 0)
                list.Insert(0, plusNum);
            return list.ToArray();
        }
    
    }
}
