using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Estructuras
{
    struct Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }


        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
        public void setOrigin()
        {
            this.x = 1;
            this.y = 1;
        }

        public static Coordinate getOrigin()
        {
            Coordinate newPoint = new Coordinate();
            return newPoint;
        }
    }

}