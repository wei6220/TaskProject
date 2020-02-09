using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public class IsHappyTask
    {
        /// <summary>
        /// 確定數字是否happy number
        /// 定義:將數字替換為其各數字的平方和，並重複該過程，直到數字等於1就是happy number
        /// Input: 19
        /// Output: true
        /// Explanation:
        /// 1^2 + 9^2 = 82
        /// 8^2 + 2^2 = 68
        /// 6^2 + 8^2 = 100
        /// 1^2 + 0^2 + 0^2 = 1
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsHappy(int n, List<int> log = null)
        {
            int rv = 0;
            foreach (var s in n.ToString())
            {
                rv += Convert.ToInt16(s.ToString()) * Convert.ToInt16(s.ToString());
            }

            log = log ?? new List<int>();
            if (log.Contains(rv))
                return false;
            log.Add(rv);
            return (rv == 1) ? true : IsHappy(rv, log);
        }
    }
}
