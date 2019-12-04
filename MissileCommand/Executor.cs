using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MissileCommand.Delegates;

namespace MissileCommand
{
    class Executor
    {
        public static event ButtonStartClickedEventHandler ButtonStartClicked;
        public static event GameScreenClickedEventHandler GameScreenClicked;
    }
}
