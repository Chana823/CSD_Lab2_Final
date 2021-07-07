using System;
using System.Collections.Generic;
using System.Text;

namespace CSD_Lab2_Final
{
    class Circle : Shape
    {
        readonly double radius;

        public Circle(int xCoord, int yCoord, int length, int points) : base(xCoord, yCoord, length, points)
        {
            this.radius = (this.Length) / (2 * 3.14);      //radius calculation = C/2π , π=3.14

        }
        public override double ShapeArea()      //returns Area of circle = πr^2
        {
            return 3.14 * (this.radius * this.radius);  
        }

        public override bool IsInside(Point p) //returns true if p is inside the circle.
        {
            return ((p.XPoint - this.XCoord) * (p.XPoint - this.XCoord)) +
                   ((p.YPoint - this.YCoord) * (p.YPoint - this.YCoord)) < (this.radius * this.radius);

        }
        public override int TypePoint() //shape related point, circle = 2
        {
            return 2;
        }

    }
}
