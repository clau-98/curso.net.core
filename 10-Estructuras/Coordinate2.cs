using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Estructuras
{
    internal class Coordinate2
    {
        private int _x, _y;
        public event Action<int> CoordinatesChange;
        public int x
        {
            get
            {
                return _x;
            }
            set
            {
                this._x = value;
                CoordinatesChange(this._x);
            }
        }
        public int y
        {
            get
            {
                return _y;
            }
            set
            {
                this._y = value;
                CoordinatesChange(this._y);
            }
        }
    }
}

