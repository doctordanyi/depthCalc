using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depthCalc.Util
{
    class MaxElement
    {
        public int location;
        public int disparity;
        public float value;

        public MaxElement(int location, float value)
        {
            this.location = location;
            this.value = value;
            disparity = 0;
        }

        public static int sortByValue(MaxElement a, MaxElement b)
        {
            if (a.value > b.value)
                return -1;
            if (a.value < b.value)
                return 1;
            return 0;
        }
    }
}
