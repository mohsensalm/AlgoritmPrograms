using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmPrograms
{
    public class Reactangle
    {

        public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
        {
            var rec1 = (ax2 - ax1) * (ay2 - ay1);
            var rec2 = (bx2 - bx1) * (by2 - by1);
            var comenArea = Math.Max(Math.Max(bx1, ax2) * Math.Max(by2, ay2), 0);
            var totalErea = (rec1 + rec2) - comenArea;
            return totalErea;
        }
    }
}
