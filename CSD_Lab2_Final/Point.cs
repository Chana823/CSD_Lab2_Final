using System;
using System.Collections.Generic;
using System.Text;

//Creating point objects

namespace CSD_Lab2_Final
{
    public class Point
    {
        public int XPoint;
        public int YPoint;

        //Constructor to initialize the objects, which shows how the point look like.
        public Point(int xInputPoint, int yInputPoint)
        {
            this.XPoint = xInputPoint;
            this.YPoint = yInputPoint;
        }
    }
}
