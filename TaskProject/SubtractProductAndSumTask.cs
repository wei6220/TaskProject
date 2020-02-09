using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public class SubtractProductAndSumTask
    {
        /// <summary>
        /// 計算數字各位數的乘積與總和之間的差
        /// 不可使用字串
        /// 
        /// Test Case:
        /// Input: n = 234
        /// Output: 15 = (2*3*4)-(2+3+4)
        /// 
        /// Input: n = 4421
        /// Output: 21 = (4*4*2*1)-(4+4+2+1)
        /// 
        /// </summary>
        public int SubtractProductAndSum(int n)
        {
            //List<int> list = new List<int>();
            //trannum(n, ref list);
            //var newX = 1;
            //var newY = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    newX *= list[i];
            //    newY += list[i];
            //}
            //return newX - newY;

            return trannum2(n, 1, 0);
        }

        private static int trannum2(int x, int y, int z)
        {
            var q = x / 10;
            var m = x % 10;
            if (q == 0)
                return y * m - (z + m);
            return trannum2(q, y *= m, z += m);
        }

        private static void trannum(int x, ref List<int> list)
        {
            var q = x / 10;
            var m = x % 10;
            list.Insert(0, m);
            if (q == 0)
                return;
            trannum(q, ref list);
        }

      

    }
}
