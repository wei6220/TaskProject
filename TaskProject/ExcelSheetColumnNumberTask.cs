using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public class ExcelSheetColumnNumberTask
    {
        /// <summary>
        /// Given a column title as appear in an Excel sheet, return its corresponding column number.
        ///  For example:  
        ///     A -> 1   ,   B -> 2 ,    C -> 3
        ///     Z -> 26 AA -> 27  AB -> 28 
        ///     Case 1 Input "A" Output 1
        ///     Case 2 Input "AB Output 28
        ///     Case 3 Input "ZY" Output 701
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int TitleToNumber(string s)
        {
            int output = 0;
            int levelcnt = 0;
            var chars = s.ToCharArray().Reverse();
            chars.ToList().ForEach(c =>
            {
                output += (int)Math.Pow(26, levelcnt) * GetNum(c);
                levelcnt++;
            });
            return output;
        }

        private int GetNum(char s)
        {
            return (((int)s) - 64);
        }


       
    }
}
