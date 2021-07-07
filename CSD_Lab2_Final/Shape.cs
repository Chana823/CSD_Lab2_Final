using System;
using System.Collections.Generic;
using System.Text;

namespace CSD_Lab2_Final
{
    public abstract class Shape             //Abstract parent class of circle and sqaure
    {
        
        public int XCoord; //X-axis coordinate of shape
        public int YCoord; //Y-axis coordinate of shape
        public int Length; //perimeter of square/circumference of the circle
        public int Points; //points on the shape
        

        public Shape (int xCoord, int yCoord, int length, int points)
        { 
            this.XCoord = xCoord;
            this.YCoord = yCoord;
            this.Length = length;
            this.Points = points;
        }


        public abstract double ShapeArea();

        public abstract bool IsInside(Point p);

        public abstract int TypePoint();

    }
}
