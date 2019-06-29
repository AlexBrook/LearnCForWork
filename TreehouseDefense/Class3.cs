using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseDefense
{
    class Map
    {
       public readonly int width;
       public readonly int height;

       public Map(int Width, int Height) {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point) {
            bool inBounds = point.x >= 0 && point.x < width && point.y >= 0 && point.y < height;
            inBounds = !(point.x < 0 || point.x > width || point.y < 0 && point.y >= height);
            return inBounds;


        }
           
    }
}
