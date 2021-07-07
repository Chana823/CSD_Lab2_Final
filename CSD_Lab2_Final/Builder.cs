using System;
using System.Collections.Generic;
using System.Text;

namespace CSD_Lab2_Final

//Builder class contains a list of shapes and the user's input
{
    class Builder
    {
        public Point Point;
        public List<Shape> InputStringList;

        public Builder(string point, String inputString)
        {
            this.Point = PointBuilder(point);
            this.InputStringList = ShapeBuilder(inputString);
            this.Result();

        }

        public Point PointBuilder(string point)
        {
            string[] Array = point.Split(",");

            int x;
            int y;


            try
            {
                x = int.Parse(Array[0]);
            }
            catch (FormatException Error)
            {
                Console.WriteLine("Error: " + Error.Message + " Default value 0 will be passed for X");
                x = 0;
            }

            try
            {
                y = int.Parse(Array[1]);
            }
            catch (FormatException Error)
            {
                Console.WriteLine("Error: " + Error.Message + " Default value 0 will be passed for Y");
                y = 0;
            }

            return new Point(x, y);
        }


        public List<Shape> ShapeBuilder(string inputString)
        {
            string[] splitRow = inputString.Split(";"); //Split by ";" to get each row and put each row into the string array splitRow

            List<Shape> Shapes = new List<Shape>(); //new List to store the Shapes

            int shapePos, Xpos, Ypos, LENGTHpos, POINTSpos;

            shapePos = Xpos = Ypos = LENGTHpos = POINTSpos = 0;

            string[] splitFirstCol = splitRow[0].Split(",");


            for (int i = 0; i < splitFirstCol.Length; i++)
            {
                switch (splitFirstCol[i].ToUpper().Trim())
                {
                    case "SHAPE":
                        shapePos = i;
                        break;
                    case "X":
                        Xpos = i;
                        break;
                    case "Y":
                        Ypos = i;
                        break;
                    case "LENGTH":
                        LENGTHpos = i;
                        break;
                    case "POINTS":
                        POINTSpos = i;
                        break;
                }
            }

            for (int i = 1; i < splitRow.Length - 1; i++)
            {
                string[] splitCol = splitRow[i].Split(",");

                if (splitCol[shapePos] == "CIRCLE")
                {
                    Shapes.Add(new Circle(Int32.Parse(splitCol[Xpos]), Int32.Parse(splitCol[Ypos]), Int32.Parse(splitCol[LENGTHpos]), Int32.Parse(splitCol[POINTSpos])));

                }
                else if (splitCol[shapePos] == "SQUARE")
                {
                    Shapes.Add(new Square(Int32.Parse(splitCol[Xpos]), Int32.Parse(splitCol[Ypos]), Int32.Parse(splitCol[LENGTHpos]), Int32.Parse(splitCol[POINTSpos])));

                }
                else
                {
                    Console.WriteLine("Shape type not supported");
                }

            }

            return Shapes;
        }

        public List<Shape> Hp()
        {
            List<Shape> hits = new List<Shape>();

            foreach (Shape a in this.InputStringList)
            {
                if (a.IsInside(this.Point))
                {
                    hits.Add(a);
                }
            }
            return hits; //returns a list that hit by the point
        }

        public List<Shape> Mp()
        {
            List<Shape> missed = new List<Shape>();

            foreach (Shape a in this.InputStringList)
            {
                if (!a.IsInside(this.Point))
                {
                    missed.Add(a);
                }
            }
            return missed; //returns a list that missed by the point
        }

        public int PointScore()
        {
            List<Shape> hitObjectList = this.Hp();
            List<Shape> missedObjectList = this.Mp();

            double ShapeScoreHit = 0;
            double ShapeScoreMissed = 0;
            int pointScore;

            foreach (Shape a in hitObjectList)
            {
                ShapeScoreHit = ShapeScoreHit + (a.TypePoint() * a.Points) / a.ShapeArea();
            }

            foreach (Shape a in missedObjectList)
            {
                ShapeScoreMissed = ShapeScoreMissed + (a.TypePoint() * a.Points) / a.ShapeArea();
            }

            pointScore = Convert.ToInt32(ShapeScoreHit - 0.25 * ShapeScoreMissed);

            return pointScore;
        }

        public void Result()
        {
            Console.WriteLine($"Your score is {this.PointScore()}");
        }

    }
}
