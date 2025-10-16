using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap02
{
    public class Cube
    {
        private double _length, _width, _height;

        /// <summary>
        /// 立方體
        /// </summary>
        /// <param name="length">長</param>
        /// <param name="width">寬</param>
        /// <param name="height">高</param>
        public Cube(double length, double width, double height)
        {
            _length = length;
            _width = width;
            _height = height;
        }

        /// <summary>
        /// 體積
        /// </summary>
        /// <returns></returns>
        public double Volume()
        {
            return _length * _width * _height;
        }
        /// <summary>
        /// 表面積
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            return 2 * (_length * _width + _length * _height + _width * _height);
        }
    }
}
