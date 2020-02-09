using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public class RemoveDuplicatesTask
    {
        /// <summary>
        /// 刪除字串裡所有相鄰的相同字元
        ///         Test Case:
        ///         Input: "abbaca"
        ///         Output: "ca"
        /// </summary>
        public string RemoveDuplicates(string S)
        {
            bool isDupli = false;
            List<char> listC = new List<char>();
            foreach (char c in S)
            {
                if (listC.Count != 0 && listC.Last() == c)
                {
                    isDupli = true;
                    listC.RemoveAt(listC.Count - 1);
                    continue;
                }
                listC.Add(c);
            }
            return isDupli ? RemoveDuplicates(string.Concat(listC)) : string.Concat(listC);
        }
       
    }
}
