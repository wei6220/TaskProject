using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public class FindTheDifferenceTask
    {
        /// <summary>
        /// 找出兩字串中多的字元
        /// </summary>
        public char FindTheDifference(string s, string t)
        {
            if (s.Length > t.Length)
            {
                var temp = t;
                t = s;
                s = temp;
            }
            s.ToList().ForEach(i =>
            {
                if (t.IndexOf(i) > -1)
                    t = t.Remove(t.IndexOf(i), 1);
            });
            return t[0];
        }

        /// <summary>
        /// 找出兩字串中多的字元
        /// </summary>
        public char FindTheDifferenceBest(string s, string t)
        {
            return (char)Math.Abs(s.Sum(c => c) - t.Sum(c => c));
        }
    }
}
