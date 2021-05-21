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
            return Convert.ToInt64(s.Replace(" ", "").Replace("-", "").Replace(":", "").Replace("/", ""));
        }
    }
}
