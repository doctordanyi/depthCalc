using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthCalc.Util
{
    class MaxElement: IComparable
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

        public int CompareTo(object obj)
        {
            MaxElement b = obj as MaxElement;
            return -value.CompareTo(b.value);
        }
    }
}
