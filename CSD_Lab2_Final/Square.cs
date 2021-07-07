using System;
using System.Collections.Generic;
using System.Text;

namespace CSD_Lab2_Final
{
    class Square: Shape //square class inherits from shape parent class
    {
        readonly double OneSide;
        public Square(int xCoord, int yCoord, int length, int points) : base(xCoord, yCoord,length,points)
        {
            this.OneSide = this.Length / 4; 
        }

        public override double ShapeArea() //Override the base class method    //calculate the area of square. breadth*height
        {
            return this.OneSide * this.OneSide;   
        }

        public override bool IsInside(Point p) //returns true if Point p inside the square and false if Point p outside the sqaure
        {
            //The given x,y input coordinates are in center point of each shape. To see if the point is inside it's necessary to map out the object.
            //Take each side and divided by 2. That way it gets the length from the center to the outer point of the square. 
            //That way, assume the point has to be inside/outside of these 4 points to be a hit or a miss.
            //a,b,c,d are each sides of sqaure
            
            double a = this.XCoord - OneSide / 2; //gives the left most x point
            double b = this.XCoord + OneSide / 2; //gives the right most x point
            double c = this.YCoord - OneSide / 2; //gives the down most y point
            double d = this.YCoord + OneSide / 2; //gives the up most y point

            return ((p.XPoint > a && p.XPoint < b) && (p.YPoint > c && p.YPoint < d)); //if this boolean statement is valid/invalid then it returns true/false

        }
        public override int TypePoint() //shape related specific point, square = 1
        {
            return 1;
        }


    }
}
