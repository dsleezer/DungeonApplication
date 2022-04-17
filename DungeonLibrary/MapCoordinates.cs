using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class MapCoordinates
    {
        private int _mapX;
        private int _mapY;

        public int MapX
        {
            get { return _mapX; }
            set
            {
                if (value > 9)
                {
                    _mapX = 9;
                }
                else if (value < 1)
                {
                    _mapX = 1;
                }
                else
                {
                    _mapX = value;
                }
            }
        }
        public int MapY
        {
            get { return _mapY; }
            set
            {
                if (value > 7)
                {
                    _mapY = 7;
                }
                else if (value < 1)
                {
                    _mapY = 1;
                }
                else
                {
                    _mapY= value;
                }
            }
        }

        public MapCoordinates(int mapX, int mapY)
        {
            MapX = mapX;
            MapY = mapY;
        }
    }
}
