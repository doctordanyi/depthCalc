using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depthCalc
{
    class MatchResultContainer
    {
        public enum BlockPinType
        {
            PinToLeftEdge,
            PinToCenter,
            PinToRightEdge
        }

        private List<MaxElement>[,] data;
        private int height;
        private int width;
        private int blockWidth;

        public int Height
        {
            get
            {
                return height;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int BlockWidth
        {
            get
            {
                return blockWidth;
            }
            set
            {
                if (BlockWidth > Width)
                    throw new Exception("Block width greater than image width");
                blockWidth = BlockWidth;
            }
        }

        public MatchResultContainer(int width, int height)
        {
            data = new List<MaxElement>[width, height];
            this.height = height;
            this.width = width;
        }

        public List<MaxElement> this[int x, int y]
        {
            get
            {
                return data[x, y];
            }
            set
            {
                data[x, y] = value;
            }
        }

        public int getBlockBaseIndex(int y, BlockPinType blockPinType = BlockPinType.PinToLeftEdge)
        {
            switch (blockPinType)
            {
                case BlockPinType.PinToLeftEdge:
                    if ((y + blockWidth) > Width)
                        return Width - blockWidth;
                    return y;
                case BlockPinType.PinToCenter:
                    if (y < (blockWidth / 2))
                        return 0;
                    if ((y + blockWidth / 2) > Width)
                        return Width - blockWidth;
                    return y - blockWidth / 2;
                case BlockPinType.PinToRightEdge:
                    if (y < blockWidth)
                        return 0;
                    return y - blockWidth;
                default:
                    throw new Exception("Invalid block pin type");
            }
        }
    }

    class MaxElement
    {
        public int location;
        public float value;

        public MaxElement(int location, float value)
        {
            this.location = location;
            this.value = value;
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
