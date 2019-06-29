using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseDefense
{
    class Map
    {
       public readonly int Width;
       public readonly int Height;

       public Map(int width, int height) {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point) {
            bool inBounds = point.x >= 0 && point.x < width && point.y >= 0 && point.y < height;
            
            return inBounds;


        }
           
    }
}
