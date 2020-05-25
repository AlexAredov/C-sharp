using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЕРЕВОД
{
    class Class1
    {
        int v;
        string s;
        public Class1(int v, string s)
        {
            this.v = v;
            this.s = s;
        }
        public string perevod()
        {
            int pr;
            int rez = 0;
            int sum = 0;
            int count = 0;
            if (v == 2)
            {
                return s;
            }
            else
            {
                for (int i = 0; Convert.ToInt32(s) != 0; i++)
                {
                    pr = Convert.ToInt32(s) % 10;
                    s = Convert.ToString(Convert.ToInt32(s) / 10);
                    rez += pr * Convert.ToInt32(Math.Pow(2, i));
                }
                if (rez > v)
                {
                    for (int j = 0; (float)rez / v > 1; j++)
                    {
                        pr = rez % v;
                        rez = rez / v;
                        sum += pr * (int)Math.Pow(10, j);
                        count = j;
                    }
                    sum += rez * (int)Math.Pow(10, count + 1);
                    rez = sum;
                }
                return Convert.ToString(rez);
            }
        }
    }
}
