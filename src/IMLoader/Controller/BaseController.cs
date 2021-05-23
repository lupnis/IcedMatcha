using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMLoader.Controller
{
    class BaseController
    {
        public static long GetTimeSpec(string s)
        {
            int[] dayOfMonth = {31, 28,31,30,31,30,31,31,30,31,30,31};
            string timestr = s.Replace(" ", "").Replace("-", "").Replace(":", "").Replace("/", "");
            short yyyy = short.Parse(s.Substring(0, 4));
            
            if (yyyy % 400 == 0 || (yyyy % 4 == 0 && yyyy % 100 != 0))
            {
                yyyy *= 366;
                dayOfMonth[1]++;
            }
            else
            {
                yyyy *= 365;
            }

            long ret = yyyy * 24 * 60 * 60;

            for (short i=0;i< short.Parse(timestr.Substring(4, 2)); ++i)
            {
                ret += dayOfMonth[i]*24*60*60;
            }

            ret += (short.Parse(timestr.Substring(6, 2))-1) * 24 * 60 * 60;
            ret += short.Parse(timestr.Substring(8, 2)) * 60 * 60;
            ret += short.Parse(timestr.Substring(10, 2)) * 60;
            ret += short.Parse(timestr.Substring(12));
            return ret;
        }
    }
}
