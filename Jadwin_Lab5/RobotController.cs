/* * * * * * * * * * * * *
 * Name: Patrick Jadwin  *
 * Date: 11-12-2018      *
 * Class: CITC 2375      *
 * * * * * * * * * * * * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jadwin_Lab5
{
    public partial class RobotController : Form
    {
        // Arrows
        private string arrowUp = Convert.ToChar(233).ToString();
        private string arrowDown = Convert.ToChar(234).ToString();
        private string arrowEast = Convert.ToChar(232).ToString();
        private string arrowWest = Convert.ToChar(231).ToString();
        // Robot class
        Robot robot = new Robot();
        // New label
        Label lbl = new Label();
        // Visible X and Y
        int visX = 100;
        int visY = 100;

        // Constructor
        public RobotController()
        {
            InitializeComponent();
            // Set text coords
            robot.X = 0;
            robot.Y = 0;
            fill();
        }

        // Init the arrow
        private void fill()
        {
            lbl.Text = arrowUp;
            lbl.Font = new Font("Wingdings", 8);
            rbtPanel.Controls.Add(lbl);
            lbl.Location = new Point(visX, visY);
        }

        private void north_Click(object sender, EventArgs e)
        {
            // Method to change direction
            chngDir(arrowUp, 0);
        }

        private void south_Click(object sender, EventArgs e)
        {
            chngDir(arrowDown, 1);
        }

        private void east_Click(object sender, EventArgs e)
        {
            chngDir(arrowEast, 2);
        }

        private void west_Click(object sender, EventArgs e)
        {
            chngDir(arrowWest, 3);
        }

        private void chngDir(string arrow, int num)
        {
            // Reset label
            lbl.Text = arrow;
            // Set direction
            robot.dirChange(num);
        }

        // Move 1
        private void mv1_Click(object sender, EventArgs e)
        {
            // Move text coordinates
            robot.move(1);
            // Move robot
            robot.rbtMove(1, visX, visY, lbl, rbtPanel);
            // Change text coordinate
            coord.Text = "{X=" + robot.X + ", Y=" + robot.Y + "}";
        }

        // Move 10
        private void mv10_Click(object sender, EventArgs e)
        {
            robot.move(10);
            robot.rbtMove(10, visX, visY, lbl, rbtPanel);
            coord.Text = "{X=" + robot.X + ", Y=" + robot.Y + "}";
        }
    }
}
