using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public class OtherTask
    {
        public List<string> GetPageList(int total, int cur, int interval)
        {
            var listc = new List<string>();
            var start = 1;
            if (total < interval)
            {
                for (int i = 0; i < total; i++)
                    listc.Add((start + i).ToString());
            }
            else
            {
                var list = new List<int>();
                var half = interval / 2;
                start = (cur - half) < 1 ? 1 : (cur - half);
                for (int i = 0; i < interval; i++)
                {
                    if ((start + i) > total)
                        list.Insert(0, (start + i) - interval);
                    else
                        list.Add(start + i);
                }

                foreach (int e in list.OrderBy(e => e))
                    listc.Add(e.ToString());
                if (list.Min() > 1)
                {
                    listc.Insert(0, "<");
                    listc.Insert(0, (list.Min() - 1).ToString());
                    listc.Insert(0, 1.ToString());
                }
                if (list.Max() < total)
                {
                    listc.Add(">");
                    listc.Add((list.Max() + 1).ToString());
                    listc.Add(total.ToString());
                }
            }
            return listc;
        }

        public bool isNumber()
        {
            var qq = long.TryParse("0928078953", out long phoneNumber);
            return false;
        }

    }
}
