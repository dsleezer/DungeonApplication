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
                if (MapX > 9)
                {
                    _mapX = 9;
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
                if (MapY > 8)
                {
                    _mapY = 8;
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
