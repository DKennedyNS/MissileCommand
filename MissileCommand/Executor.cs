using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MissileCommand.Delegates;

namespace MissileCommand
{
    /// <summary>
    /// All event handler executors for the program
    /// </summary>
    class Executor
    {
        public static event ButtonStartClickedEventHandler ButtonStartClicked;
        public static event GameScreenClickedEventHandler GameScreenClicked;
        public static event ButtonResetClickedEventHandler ButtonResetClicked;
        public static event ButtonQuitClickedEventHandler ButtonQuitClicked;
    }
}
