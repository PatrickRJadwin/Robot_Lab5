/* * * * * * * * * * * * *
 * Name: Patrick Jadwin  *
 * Date: 11-12-2018      *
 * Class: CITC 2375      *
 * * * * * * * * * * * * */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public delegate void EventHandler();

namespace Jadwin_Lab5
{
    class Robot
    {
        // Text coordinates
        private int x;
        private int y;
        // Variables for wacky error checking
        private int temp;
        private int temp2;
        // Enum var
        private Direction dir;
        // Event for out of bounds
        private event EventHandler _outOfBounds;
        // Direction enum
        private enum Direction
        {
            North = 0,
            South = 1,
            East = 2,
            West = 3
        }

        // Constructor
        public Robot()
        {
            dir = Direction.North;
        }

        // Getter/Setter for Y
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        // Getter/Setter for X
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        // Move text coordinates
        public void move(int incAmount)
        {
            switch (dir)
            {
                case Direction.North:
                    temp = x;
                    x = incCheck(x, incAmount, true);
                    temp2 = x;
                    break;
                case Direction.South:
                    temp = x;
                    x = incCheck(x, incAmount, false);
                    temp2 = x;
                    break;
                case Direction.East:
                    temp = y;
                    y = incCheck(y, incAmount, true);
                    temp2 = x;
                    break;
                case Direction.West:
                    temp = y;
                    y = incCheck(y, incAmount, false);
                    temp2 = x;
                    break;
            }
        }

        // Check if able to increment or out of bounds
        public int incCheck(int num, int incAmount, bool op)
        {
            int ogNum = num;
            if (op == true)
            {
                num += incAmount;
            }
            if (op == false)
            {
                num -= incAmount;
            }
            if (num > 100 || num < -100)
            {
                _outOfBounds = new EventHandler(RaiseError);
                _outOfBounds.Invoke();
                return ogNum;
            }
            else
            {
                return num;
            }
        }

        // Set dir
        public void dirChange(int num)
        {
            dir = (Direction) num;
        }

        // Move robot
        public void rbtMove(int incAmt, int visX, int visY, Label lbl, Panel pnl)
        {
            if (temp != temp2)
            {
                switch (dir)
                {
                    case Direction.North:
                        lbl.Location = new Point(lbl.Location.X, lbl.Location.Y - incAmt);
                        pnl.Controls.Clear();
                        pnl.Controls.Add(lbl);
                        break;
                    case Direction.South:
                        lbl.Location = new Point(lbl.Location.X, lbl.Location.Y + incAmt);
                        pnl.Controls.Clear();
                        pnl.Controls.Add(lbl);
                        break;
                    case Direction.East:
                        lbl.Location = new Point(lbl.Location.X + incAmt, lbl.Location.Y);
                        pnl.Controls.Clear();
                        pnl.Controls.Add(lbl);
                        break;
                    case Direction.West:
                        lbl.Location = new Point(lbl.Location.X - incAmt, lbl.Location.Y);
                        pnl.Controls.Clear();
                        pnl.Controls.Add(lbl);
                        break;
                }
            }
        }

        // Event
        private static void RaiseError()
        {
            MessageBox.Show("Cannot go out of bounds", "Out of bounds");
        }
    }
}
