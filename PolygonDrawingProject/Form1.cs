


using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Windows.Forms;

namespace B231202375
{
    public partial class Form1 : Form
    {
        // a "center" object is created from Point2D class.(to be used as the center point of the polygon)
        Point2D center = new Point2D(); 

        // a "polygon" object is created from Polygon class.
        Polygon polygon = new Polygon();
 
        public Form1()
        {
            InitializeComponent();
        }
        private void centerPointxText_TextChanged(object sender, EventArgs e)
        {
            // "centerPointxText" is a textbox created to assign a value to the x point of the "center point" coordinate.
        }

        private void centerPointyText_TextChanged(object sender, EventArgs e)
        {
            // "centerPointyText" is a textbox created to assign a value to the y point of the "center point" coordinate.
        }

        private void lengthText_TextChanged(object sender, EventArgs e)
        {
            // "lengthText" is a textbox created to assign a value to the length of an edge of the "polygon"
        }

        private void edgeNumberText_TextChanged(object sender, EventArgs e)
        {
            // "edgeNumberText" is a textbox created to determine the edge number of the "polygon".
        }

        private void verticesPointListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // "verticesPointListBox" is a listbox created for listing vertex points of the "polygon" in an order.


        }
        private void randomValueButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); // a new "rnd" object is created from "Random" class. 

            // random number betwen [0,3] is assigned for the x point of the center point coordinate .
            centerPointxText.Text = Convert.ToString(rnd.Next(0, 4));

            // random number betwen [0,3] is assigned for the y point of the center point coordinate .
            centerPointyText.Text = Convert.ToString(rnd.Next(0, 4));

            // random number betwen [3,9] is assigned for the length of an edge of the "polygon".
            lengthText.Text = Convert.ToString(rnd.Next(3, 10));

            // random number betwen [3,10] is assigned for the edge number of the "polygon".
            edgeNumberText.Text = Convert.ToString(rnd.Next(3, 11));

            // random number betwen [0,359] is assigned for rotation angle.
            rotationAngleText.Text = Convert.ToString(rnd.Next(0, 360));


        }
        private void drawGraphButton_Click(object sender, EventArgs e)
        {
            
            center._x = Convert.ToInt32(centerPointxText.Text);
            // x point of the center point coordinate is equalized to the value written into "centerPointxText" textbox.
           
            center._y = Convert.ToInt32(centerPointyText.Text);
            // y point of the center point coordinate is equalized to the value written into "centerPointyText" textbox.
            
            // a radius variable is defined to be used while creating "polygon" object.
            int radius = (int)(Convert.ToInt32(lengthText.Text) / (2 * Math.Sin(Math.PI / Convert.ToInt32(edgeNumberText.Text))));
          // strings are turned into integer //"length of an edge of "polygon"                    // edge number of "polygon"
            
            polygon = new Polygon(center, radius); // a Polygon class object is created with its center and radius.

            polygon._numberofEdges = Convert.ToInt32(edgeNumberText.Text);
            // edge number of the polygon is equalized to the value written into "edgeNumberText" textbox.


            polygon.CalculateEdgeCoordinates(verticesPointListBox);
        // calculating edge coordinates method is applied for "polygon" object to determine its vertex points' coordinates.
            
            polygon.drawPolygonGraph(graphPictureBox);
        // drawing method is applied for "polygon" object, so polygon's graph is drawn.

        }

        private void rotationAngleText_TextChanged(object sender, EventArgs e)
        {

        }

        private void rotateShapeButton_Click(object sender, EventArgs e)
        {
            if (polygon._center==null) { } // if "polygon's center" is not assigned with a value, 
          // it means that " drawGraphButton" is not clicked yet, and so there is no graph drawn in the "graphPictureBox".
                                 // As a result, if no drawn graph exist in "graphPictureBox", do nothing.

            // else, meaning a graph is drawn in "graphPictureBox", make operations below:
            else
            {      
                polygon.rotatePolygon(verticesPointListBox, Convert.ToInt32(rotationAngleText.Text));
                // rotation method is applied for "polygon" object, so polygon is rotated(by using "vertex points" and "rotation angle".
                
                polygon.drawPolygonGraph(graphPictureBox);
                // drawing method is applied for "polygon" object, so polygon's graph is drawn into the "graphPictureBox"
            }

        }

        private void graphArea_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
