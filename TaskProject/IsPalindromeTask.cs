using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public class IsPalindromeTask
    {
        /// <summary>
        /// 判斷數字倒轉後的值是否仍相同
        /// 不可使用字串
        /// Input: 121 
        /// Output: true
        /// 
        /// Input: -121
        /// Output: false
        /// 
        /// Input: 10
        /// Output: false
        /// 
        /// </summary>
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            else if (x < 10)
                return true;

            var newX = 0;
            List<int> list = new List<int>();
            reverse(x, ref list);
            for (int i = 0; i < list.Count; i++)
                newX = newX + list[i] * (int)Math.Pow(10, i);

            return x == newX;
        }

        private static void reverse(int x, ref List<int> list)
        {
            var q = x / 10;
            var m = x % 10;
            list.Insert(0, m);
            if (q == 0)
                return;
            reverse(q, ref list);
        }
    }
}
