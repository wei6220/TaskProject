using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{

    public class UniqueOccurrencesTask
    {
        /// <summary>
        /// 判斷陣列中每個數字出現的次數是否沒有重複
        /// 
        /// Test Case:
        ///        Input: arr = [1,1,1,2,2,3]
        ///        Output: true
        /// Input: arr = [1,2]
        ///        Output: false
        /// Input: arr = [-3,0,1,-3,1,1,1,-3,10,0]
        ///        Output: true
        /// Input: arr = [3,5,-2,-3,-6,-6]
        ///        Output: false
        ///        
        /// </summary>
        public bool UniqueOccurrences(int[] arr)
        {
            return arr.GroupBy(e => e).Count() == arr.GroupBy(e => e).Select(e => e.Count()).Distinct().Count();
        }

    }
}
