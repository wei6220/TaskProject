using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public class MyPowTask
    {
        /// <summary>
        /// 計算x的n次方
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public double MyPow(double x, int n)
        {
            if (n == 0)
                return 1;
            if (x == 1)
                return 1;
            if (x == -1)
                return (n % 2 == 0) ? 1 : -1;

            double rv = x;
            if (n > 0)
            {
                rv = x;
                for (int i = 0; i < n - 1; i++)
                {
                    if (rv == 0) break;
                    rv = rv * x;
                }
            }
            else
            {
                rv = (1 / x);
                for (int i = 0; i > (n + 1); i--)
                {
                    if (rv == 0) break;
                    rv = rv * (1 / x);
                }
            }
            return rv;
        }

    }
}
