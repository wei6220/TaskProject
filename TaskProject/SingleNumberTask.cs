using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public class SingleNumberTask
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            List<int> listC = new List<int>();
            nums.ToList().ForEach(e =>
            {
                if (listC.Contains(e))
                {
                    listC.Remove(e);
                    return;
                }
                listC.Add(e);
            });
            return listC[0];

            //var qq = nums.ToList().GroupBy(e => e).FirstOrDefault(e => e.Count() == 1).Key;
            //return qq;




        }
    }
}
