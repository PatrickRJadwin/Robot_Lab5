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
        int dir;
        Robot robot = new Robot();

        public RobotController()
        {
            InitializeComponent();
            robot.X = 0;
            robot.Y = 0;
        }

        private void north_Click(object sender, EventArgs e)
        {
            dir = 0;
            robot.dirChange(dir);
        }

        private void south_Click(object sender, EventArgs e)
        {
            dir = 1;
            robot.dirChange(dir);
        }

        private void east_Click(object sender, EventArgs e)
        {
            dir = 2;
            robot.dirChange(dir);
        }

        private void west_Click(object sender, EventArgs e)
        {
            dir = 3;
            robot.dirChange(dir);
        }

        private void mv1_Click(object sender, EventArgs e)
        {
            robot.move(1);
            coord.Text = "{X=" + robot.X + ", Y=" + robot.Y + "}";
        }

        private void mv10_Click(object sender, EventArgs e)
        {
            robot.move(10);
            coord.Text = "{X=" + robot.X + ", Y=" + robot.Y + "}";
        }
    }
}
