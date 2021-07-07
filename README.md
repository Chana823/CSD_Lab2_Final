# CSD_Lab2_Final

This is the lab 2 exercise of the contemporary software development module which is in the second semester of Master in Information Systems at Departmentment of Informatics 
and media at Uppsala University Sweden 2021.

The program consist of 5 classes except the main class namely Point, Shape, Circle, Square and Builder. Once the two input arguments has given to the command terminal, 
the entry point to the program, main method runs which contains a string array of arguments (args). The two string arguments (args[0],args[1]) will be passed to the newly 
created object Builder. The object is assigned to builder variable.

Builder Class - 
The Builder class contains the user input, the x, y points and the CSV string list. To give the value to Point variable I call the PointBuilder() method with the string point.
The first argument point input is given as a one string coordinates (“x, y”) and I split that to get a string array of x and y separately. It passes through try-catch blocks 
to throw exceptions when user input invalid data while the program has been executed. The ShapeBuilder() method takes the second argument CSV string list and returns a complete 
list of shapes and it will put it in the InputStringList.The Result() method output the final score to the terminal. The CSV data we receive have columns which are delimited by 
comma and rows by semi colon. First, it splits the rows by “;” to get each row and put each row in to the string array called splitRow. A new List called “Shapes” is created to 
store the list of shapes. The for-loop iterates through the splitRow array, starting at index 1 to skip the headers. Each iteration splits the row by "," giving us one attribute 
per index. It then check if the first index (i = 0) is equal to Circle or Square. Depending on that it creates either a Circle or a Square object using index 1-4 as inputs. For 
example splitCol[1] will contain the X input, splitCol[2] will have the Y-input, splitCol[3] the Length-input and so on. Parse method will convert the string inputs to int when 
creating new Shape objects. The Hp() method will return a list of hit points with the objects. Firstly a new list named as hits was created. For each shape in the InputStringList, 
which contains all the objects, If the method IsInside() returns true with the Point, then it will adds the shape to the hits list. The Mp() method will return a list of missed 
points with the objects. If IsInside() returns false, it counts as a missed point and will adds the shape to the missed list. The PointScore() method have two new lists namely 
hitObjectList and missedObjectList where it calls Hp() and Mp() methods and pass their return values to these two new lists. So hitObjectList will have all the hit objects and 
missedObjectList will have all the missed objects. The PointScore() method will iterates through those two lists and calculate the point score which has rounded to the nearest 
integer and output the score to the terminal through the Result() method.

Point Class - 
Point Class create point objects by taking the user input. It contains the Point constructor with two parameters take in namely xInputPoint and yInputPoint which shows 
how a point should look like.

Shape Class - 
The shape class is declared with an abstract modifier where it act as the base class for circle and square classes. There are three abstract methods declared as 
ShapeArea() which returns the Shape area, IsInside() which returns true or false based on hit point and missed point and lastly TypePoint() returns relevant type 
point according to the type of the shape (1 or 2).

Square Class - 
Square class inherits from the Shape abstract class. It has an attribute called OneSide which defines the one side of a square to calculate the length for the purpose of 
finding the area of a square. ShapeArea() returns the area of the square. The Square class overrides the three abstract methods declared in the Shape class and adds 
functionality to those. IsInside() returns true if the hit point is inside the square and returns false if it is outside of it. The following approach used to find whether 
the point is inside/outside of the square.
The given x, y input coordinates are in center point of each shape. To see if the point is inside it is necessary to map out the object. Firstly, take each side and divided 
by 2, It gets the length from the center to the outer point of the square. That way assume the point has to be inside/outside of these 4 points to be a hit or a miss.
TypePoint() returns the shape related type points. Square = 1.

Circle Class - 
Circle class also inherits from it’s parent class Shape and has an attribute called radius to use to find out the area of the circle. Radius is calculated with the 
standard radius of a circle formula “C/2π”. ShapeArea() returns the area of the circle and IsInside() returns true or false according to the point inside/outside the 
circle. The standard point formula is used to find out whether a point lies inside or outside the circle. TypePoint() returns the shape related type points. Circle = 2
