using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    /// <summary>
    /// 費式數列
    /// </summary>
    public class FibonacciNumberTask
    {
        /// <summary>
        /// 數列: 1,1,2,3,5,8,13,....
        /// 規則說明: 1隻兔子1個月生產1隻，且新兔子從第2個月才會開始生產
        /// 則
        /// 0 => 1  初始1隻
        /// 1 => 1  緩衝1個月
        /// 2 => 2  1舊,1新 
        /// 3 => 3  1舊,1緩衝,1新
        /// 4 => 5  2舊,1緩衝,2新
        /// 5 => 8  3舊,2緩衝,3新
        /// ...
        ///  
        /// 邏輯:
        /// 第三列開始，數值為前兩數相加
        /// 
        /// </summary>
        /// <param name="month">月數</param>
        /// <returns></returns>
        public int FibonacciNumber(int n)
        {
            if (n < 2)
                return 1;
            else
                return FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
        }
    }
}
