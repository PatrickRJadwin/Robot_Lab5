using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public delegate void EventHandler();

namespace Jadwin_Lab5
{
    class Robot
    {
        private int x;
        private int y;
        private Direction dir;
        private event EventHandler _oob;
        private enum Direction
        {
            North = 0,
            South = 1,
            East = 2,
            West = 3
        }
        public Robot()
        {
            dir = Direction.North;
        }
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
        public void move(int incAmount)
        {
            switch (dir)
            {
                case Direction.North:
                    x = incCheck(x, incAmount, true);
                    break;
                case Direction.South:
                    x = incCheck(x, incAmount, false);
                    break;
                case Direction.East:
                    y = incCheck(y, incAmount, true);
                    break;
                case Direction.West:
                    y = incCheck(y, incAmount, false);
                    break;
            }
        }
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
                _oob += new EventHandler(RaiseError);
                _oob.Invoke();
                return ogNum;
            }
            else
            {
                return num;
            }
        }
        public void dirChange(int num)
        {
            dir = (Direction) num;
        }
        private static void RaiseError()
        {
            MessageBox.Show("Cannot go out of bounds", "Out of bounds");
        }
    }
}
