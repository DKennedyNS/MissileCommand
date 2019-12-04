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
    public class Flak : IDisposable
    {
        //Class vars
        private Rectangle rect;
        Stopwatch stopwatch= new Stopwatch();
        #region IDisposable Support
        private bool disposedValue = false;

        /// <summary>
        /// Constructor for the flak object. Takes a click location from the GameScreen.
        /// </summary>
        /// <param name="location"></param>
        public Flak(Point location)
        {
            stopwatch.Start();
            rect.X = location.X;
            rect.Y = location.Y;
            rect.Height = 3;
            rect.Width = 3;
        }

        /// <summary>
        /// Draw method for the flak object.
        /// </summary>
        /// <param name="graphics"></param>
        public void Draw(Graphics graphics)
        {
            int elapsed = (int)stopwatch.ElapsedMilliseconds;
            if(elapsed < 500)
            {
                graphics.DrawEllipse(Pens.Crimson, rect);
                graphics.FillEllipse(Brushes.DarkOrange, rect);

                rect.Inflate(elapsed / 150, elapsed / 150);
            }
            else
            {
                Dispose();
            }
        }

        /// <summary>
        /// Checks to see if a given missile was destroyed by  the flak.
        /// </summary>
        /// <param name="missile"></param>
        /// <returns></returns>
        public bool IsHit(Missile missile)
        {
            if (this.rect.IntersectsWith(missile.getBounds()))
            {
                return true;                
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks to see if this flak is flagged for disposal, so it can be removed from the flakList
        /// </summary>
        /// <returns></returns>
        public bool isDisposed()
        {
            return this.disposedValue;
        }

        /// <summary>
        /// Implementation of the IDisposable interface. Used to make sure a bunch of flak doesn't crash things.
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    stopwatch.Stop();                                      
                }
                
                disposedValue = true;
            }
        }

        /// <summary>
        /// Implementation of the IDisposable interface. Just sets a flag to make sure disposal doesn't repeat.
        /// </summary>
        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
        }
        #endregion
    }
}
