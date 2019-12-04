using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissileCommand
{
    class Delegates
    {
        public delegate void ButtonStartClickedEventHandler(object sender, EventArgs e);
        public delegate void GameScreenClickedEventHandler(object sender, MouseEventArgs e);
    }
}
