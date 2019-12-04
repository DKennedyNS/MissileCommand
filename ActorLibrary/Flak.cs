using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace ActorLibrary
{
    /// <summary>
    /// Class for the flak explosions the player fires
    /// </summary>
    public class Flak 
    {
        private Rectangle rect;
        Stopwatch stopwatch= new Stopwatch();      

        public Flak(Point location)
        {
            stopwatch.Start();
            rect.X = location.X;
            rect.Y = location.Y;
            rect.Height = 2;
            rect.Width = 2;
        }

        public void Draw(Graphics graphics)
        {
            int elapsed = (int)stopwatch.ElapsedMilliseconds;
            if(elapsed < 500)
            {
                graphics.DrawEllipse(Pens.Crimson, rect);
                graphics.FillEllipse(Brushes.DarkOrange, rect);

                rect.Inflate(elapsed / 200, elapsed / 200);
            }
        }
    }
}
