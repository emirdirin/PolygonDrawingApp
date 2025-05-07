
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B231202375
{
    internal class Polygon
    {
        public Point2D _center { set; get; } // 2D center is created from Point2D class for polygon.
        public Point2D[] vertexPoints;       // an array is created for vertex points of the polygon.
        public double _length { set; get; }  // _length represents the length of an edge of the polygon.
        public  double _radius { set; get; } // _radius represents the distance from the center point to a vertex point.
        public double _angle { set; get; } // _angle represents 
        public float xPoint { set; get; } // xPoint represents x coordinate of a 2D point.
        public float yPoint { set; get; } // yPoint represents y coordinate of a 2D point.
        public int _numberofEdges { set; get; } // _numberofEdges represents edge number of the polygon.
        public Polygon() { } //  a default constructor with no parameters is created.

        public Polygon(Point2D center,  int radius) // a constructor with an object from "Point2D" class and an integer for radius.
        {
            _center = center; // entered 2DPoint center is assigned to the _center.
            _radius = radius; // entered radius value is assigned to the _radius.
        }

        public void CalculateEdgeCoordinates(ListBox verticesPointListBox) // method for calculating edge coordinates of the polygon.
        {  // a listbox is initialized to write the edge coordinates in the listbox.

            // the length of one side of the polygon based on its radius and number of edges.
            // according to sin formula, radius/90 = opposite edge length/sin(PI/n)
            _length = _radius * (2 * Math.Sin(Math.PI / _numberofEdges)); 

            Random random = new Random(); //a new "random" object is created from "Random" class.
           
            //random number betwen[0, 359] is assigned to be used while defining first vertex point randomly.
            double randomAngle = random.Next(0, 360); 

            verticesPointListBox.Items.Clear(); // clear the listbox for each operation.

            // the index of the "vertexPoints" array is equalized to the _numberofEdges
            vertexPoints = new Point2D[_numberofEdges]; 


            for (int i = 0; i < _numberofEdges; i++) //for loop for finding each vertex point according to edge number of the polygon
            { 
// finding one central interior angle of the polygon and multiply it by "i" to pass to the next vertex point as "i" increases
                double angle = randomAngle + (360 / _numberofEdges * i); // also, "randomAngle(starting angle)" is added. 
                                               
                //(Math.PI * angle / 180) operation is used for converting angle to the radian.
                xPoint = (float)(_center._x + (_radius * Math.Cos(Math.PI * angle / 180))); // cosQ=x/radius.
                yPoint = (float)(_center._y + (_radius * Math.Sin(Math.PI * angle / 180))); // sinQ=y/radius.
                //(Math.PI * angle / 180) operation is used to converting angle to the radian.

                Point2D vertex = new Point2D(xPoint, yPoint);  // to initialize an object for vertexPoints' coordinates,
                vertexPoints[i] = vertex;                        // => to avoid from null object error.
               
                // adding each vertex points' coordinates as an item of listbox.  
                verticesPointListBox.Items.Add("(" + xPoint.ToString("F0") + "," + yPoint.ToString("F0") + ")");
                // "ToString("F0")" is used for writing float numbers only with their part before dot(like an integer).

            } //return result;
        }
        
        public void rotatePolygon(ListBox listofPoints,int rotationAngle) // method for rotating polygon and then calculate each vertex point again. 
        {
            
            listofPoints.Items.Clear();// clear the listbox for each operation.
            int angleofRotation = -rotationAngle; // entered value is multiplied by minus because the rotation will be clockwise.
            
           
            for (int i = 0; i < _numberofEdges; i++) // for loop for calculating vertex points after rotation.
            {
                // calculating new coordinates of vertex points with(length of x coordinate)  trigonometric formula for rotating about a fixed center point.    (length of y coordinate)
                // x  = centerX + (x−centerX)⋅cos(θ) − (y−centerY)⋅sin(θ)
                // y = centerY + + (y−centerY)⋅cos(θ) + (x−centerX)⋅sin(θ) 
                float xPointRotated = (float)_center._x + (float)((vertexPoints[i]._x - _center._x) * Math.Cos(Math.PI * angleofRotation / 180)) - (float)((vertexPoints[i]._y - _center._y) * Math.Sin(Math.PI * angleofRotation / 180));
                float yPointRotated = (float)_center._y + (float)((vertexPoints[i]._y - _center._y) * Math.Cos(Math.PI * angleofRotation / 180)) + (float)((vertexPoints[i]._x-_center._x) * Math.Sin(Math.PI * angleofRotation / 180));
                
                vertexPoints[i]._x = xPointRotated; // new x coordinate is assigned to the "vertexPoints" array.
                vertexPoints[i]._y = yPointRotated; // new y coordinate is assigned to the "vertexPoints" array.

                // adding each vertex points' new coordinates after rotation as an item of listbox. 
                listofPoints.Items.Add("(" + xPointRotated.ToString("F0") + "," + yPointRotated.ToString("F0") + ")");
                
            }

        }
        public void drawPolygonGraph(PictureBox graphArea) // method for drawing the graph of polygon into the picturebox.
        { // !!! (in this part, i used and search web sites to learn what is necessary for drawing graph and how to apply them.)
           
            graphArea.Refresh(); // clear the picturebox for each operation.
            Graphics drawPolygon = graphArea.CreateGraphics(); // a "drawPolygon" object is created for drawing the polygon's graph.


            double centerX = graphArea.Width / 2; // centerX represents the center of the pictureBox.(will be used for X-axis)
            double centerY = graphArea.Height / 2; // centerY represents the center of the pictureBox.(will be used for Y-axis)
            int axisLength = Math.Min(graphArea.Width, graphArea.Height) / 2;

            // drawing X-axis     // color pen is black
            drawPolygon.DrawLine(Pens.Black, new Point(0, Convert.ToInt32(centerY)), new Point(graphArea.Width, Convert.ToInt32(centerY)));
            // drawing Y-axis     // color pen is black
            drawPolygon.DrawLine(Pens.Black, new Point(Convert.ToInt32(centerX), 0), new Point(Convert.ToInt32(centerX), graphArea.Height));

            int centerPointSize = 6; // it represents the size of the center point that will be filled.
            // to make the center point visible, it will be filled with blue color.
            drawPolygon.FillEllipse(Brushes.Blue, (float)(centerX + _center._x * 15), (float)(centerY - _center._y * 15), centerPointSize, centerPointSize);

            for (int i = 0; i < _numberofEdges; i++)
            {
                int vertexPointSize = 4; // it represents the size of the vertex point that will be filled.
                //  to make each vertex point visible, it will be filled with red color. 
                drawPolygon.FillEllipse(Brushes.Red, (float)(centerX + vertexPoints[i]._x * 15), (float)(centerY - vertexPoints[i]._y * 15), vertexPointSize, vertexPointSize);
                // for bigger scale, the vertex points are multiplied by 15.
            }
            Pen pen = new Pen(Color.Black, 2); // a new pen object is created to be used while drawing the lines between vertex points.
            for (int i = 0; i < _numberofEdges - 1; i++)
            {
      // two points are created from Point class (which is used while drawing), so that there will be a line drawn from one to another .
                Point firstPoint = new Point((int)(centerX + vertexPoints[i]._x * 15), (int)(centerY - vertexPoints[i]._y * 15));
                Point lastPoint = new Point((int)(centerX + vertexPoints[i + 1]._x * 15), (int)(centerY - vertexPoints[i + 1]._y * 15));
                // because in GUI Coordinate System, Y axis increases downwards, there is a substraction for y point.

                drawPolygon.DrawLine(pen, firstPoint, lastPoint); // a line will be drawn from one point to another.
            }
          
            // because it is also needed to be drawn a line from the last point to first point,new 2 points are created from "Point" class;
            // and the same operations above are applied.
            Point firstPointOfPolygon = new Point((int)(centerX + vertexPoints[0]._x * 15), (int)(centerY - vertexPoints[0]._y * 15));
            Point endPointOfPolygon = new Point((int)(centerX + vertexPoints[_numberofEdges - 1]._x * 15), (int)(centerY - vertexPoints[_numberofEdges - 1]._y * 15));

            // a line will be drawn from the end point to the first point of the polygon.
            drawPolygon.DrawLine(pen, endPointOfPolygon, firstPointOfPolygon);

        }

    }
}
