using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mo_phong_do_thi.Model
{
    public class p : IComparable
    {
        public int w;
        public int v;
        public int ID;

        public int CompareTo(object bz)
        {
            if (bz == null) return 1;
            p b = bz as p;
            if (w < b.w) return -1;
            if (w == b.w) return 0;
            return 1;
        }
    }
}
