
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B231202375
{
    internal class Point2D
    {
        public double _x { set; get; } // an x variable is created for 2dPoint's x coordinate
        public double _y { set; get; } // a y variable is created for 2D Point's y coordinate

        public double r { set; get; } // radius variable represents the length between center point and vertex point
        public double Q { set; get; } // Q represents teta angle for polar coordinates
        public Point2D() { }  // default constructor with no paramaters is added
        public Point2D(float x, float y)  // constructor with initial values
        {
            _x = x; // entered x will be equal to the 2dPoint's x coordinate
            _y = y; // entered y will be equal to the 2dPoint's y coordinate
        }
        public void printCoordinates() // method for "printing" x and y point for the cooordinates of 2D point
        {
            Console.WriteLine("Coordinates of the 2D POINT is (" + _x + "," + _y + ")");
        }
        public void calculatePolarCoordinates()   // method for "calculating" Polar Coordinates of a 2D point.
        {
            r =Math.Sqrt( Math.Pow(_x, 2) + Math.Pow(_y, 2));  // r^2 = x^2 + y^2  
            Q = Math.Atan(_y / _x);                            //   Q = arctan(y/x)
            
        }
        public void calculateCartesianCordinates(float angle,float radius) // method for "calculating" Cartesian Coordinates of a 2D point.
        {
            // according to trigonometric identities, and relation between polar and cartesian coordinates, 
            // the "angle" is multiplied with Math.PI and divided by 180 to transform the angle to the radian.
            _x = radius * Math.Cos(Math.PI * angle / 180); 
            _y = radius * Math.Sin(Math.PI * angle / 180);
            // these 2 formula revealed to find x and y.
        }
        public void printPolarCoordinates() // method for "printing" Polar Coordinates" of a 2D point.
        {
            Console.WriteLine("Polar corrdinates P(" + r + "," + Q+")");
        }
    }
}
