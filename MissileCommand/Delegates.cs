using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissileCommand
{
    /// <summary>
    /// All event handler delegates for the program
    /// </summary>
    class Delegates
    {
        public delegate void ButtonStartClickedEventHandler(object sender, EventArgs e);
        public delegate void GameScreenClickedEventHandler(object sender, MouseEventArgs e);
        public delegate void ButtonResetClickedEventHandler(object sender, EventArgs e);
        public delegate void ButtonQuitClickedEventHandler(object sender, EventArgs e);
    }
}
