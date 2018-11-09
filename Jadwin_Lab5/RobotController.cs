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
        int modY = 8;
        int modX = 8;

        public RobotController()
        {
            InitializeComponent();
            robot.X = 0;
            robot.Y = 0;
            fill(modX, modY);
        }

        private void fill(int yCord, int xCord)
        {
            string arrow = Convert.ToChar(233).ToString();
            string[,] filler = new string[18, 18];

            robotBox.Text = "";

            for (int x = 0; x < filler.GetLength(0); x++)
            {
                for (int y = 0; y < filler.GetLength(1); y++)
                {
                    if (y == yCord && x == xCord)
                    {
                        filler[x, y] = arrow;
                    }
                    else
                    {
                        filler[x, y] = " ";
                    }
                }
            }

            for (int x = 0; x < filler.GetLength(0); x++)
            {
                for (int y = 0; y < filler.GetLength(1); y++)
                {
                    robotBox.Text += filler[x, y];
                }
            }
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

            switch (dir)
            {
                case 0:
                    if (robot.X % 10 == 0)
                    {
                        modY += 1;
                        fill(modY, modX);
                    }
                    break;
                case 1:
                    if (robot.X % 10 == 0)
                    {
                        modY -= 1;
                        fill(modY, modX);
                    }
                    break;
                case 2:
                    if (robot.Y % 10 == 0)
                    {
                        modX += 1;
                        fill(modY, modX);
                    }
                    break;
                case 3:
                    if (robot.Y % 10 == 0)
                    {
                        modX -= 1;
                        fill(modY, modX);
                    }
                    break;
            }
        }

        private void mv10_Click(object sender, EventArgs e)
        {
            robot.move(10);
            coord.Text = "{X=" + robot.X + ", Y=" + robot.Y + "}";

            switch (dir)
            {
                case 0:
                    modY -= 1;
                    Console.WriteLine("WORKING");
                    break;
                case 1:
                    modY += 1;
                    break;
                case 2:
                    modX -= 1;
                    break;
                case 3:
                    modX += 1;
                    break;
            }

            fill(modX, modY);
        }
    }
}
