using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depthCalc.Util
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
                blockWidth = value;
            }
        }

        public MatchResultContainer(int height, int width)
        {
            data = new List<MaxElement>[height, width];
            this.height = height;
            this.width = width;
        }

        public List<MaxElement> this[int row, int col]
        {
            get
            {
                return data[row, col];
            }
            set
            {
                data[row, col] = value;
            }
        }

        public int getBlockBaseIndex(int col, BlockPinType blockPinType = BlockPinType.PinToLeftEdge)
        {
            switch (blockPinType)
            {
                case BlockPinType.PinToLeftEdge:
                    if ((col + blockWidth) > Width)
                        return Width - blockWidth;
                    return col;
                case BlockPinType.PinToCenter:
                    if (col < (blockWidth / 2))
                        return 0;
                    if ((col + blockWidth / 2) > Width)
                        return Width - blockWidth;
                    return col - blockWidth / 2;
                case BlockPinType.PinToRightEdge:
                    if (col < blockWidth)
                        return 0;
                    return col - blockWidth;
                default:
                    throw new Exception("Invalid block pin type");
            }
        }
    }

}
