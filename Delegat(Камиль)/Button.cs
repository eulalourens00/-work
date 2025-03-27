using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegat_Камиль_
{
    internal class Clicked
    {
        public void Message() { Console.WriteLine("CLICKED! ! !"); }
    }
    internal class ButtonCL
    {
        public delegate void Clicker();
        public event Clicker ClickButton;

        public void ClickMouse(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            { ClickButton?.Invoke(); }
        }
    }
}
