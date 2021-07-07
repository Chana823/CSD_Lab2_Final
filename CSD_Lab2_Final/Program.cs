using System;

namespace CSD_Lab2_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            
                   
            var builder = new Builder(args[0], args[1]);

        }
    }
}



//Two test input arguments: 
//"1,0" "SHAPE,X,Y,LENGTH,POINTS;CIRCLE,3,1,13,100;CIRCLE,1,-1,15,200;SQUARE,-1,0,20,300;SQUARE,-3,2,8,400;"

// If switch the column order (Arbitrary column order) here, it gives the same output 6