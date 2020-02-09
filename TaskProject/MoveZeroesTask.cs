using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public class MoveZeroesTask
    {
        /// <summary>
        /// 將數字陣列裡所有0的元素移到最後面
        /// 不改變其他數字的排序
        /// 直接在該陣列物件完成操作,不可複製或建立新的陣列
        ///     Test Case:
        ///     Input: [0,12,0,1,3]
        ///     Output: [12,1,3,0,0]
        /// </summary>
        public int[] MoveZeroes(int[] nums)
        {
            //法一:先記非0的，再處理0的數
            //int j = 0; //非0的index
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] != 0)
            //    {
            //        nums[j] = nums[i];
            //        j++;
            //    }
            //}
            //for (int i = j; i < nums.Length; i++)
            //{
            //    nums[i] = 0;
            //}


            //法二:遇到非0的跟 目前0的idx對換
            for (int i = 0, idx = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int tmp = nums[idx];
                    nums[idx] = nums[i];
                    nums[i] = tmp;
                    idx++;
                }
            }
            return nums;

        }
    }
}
