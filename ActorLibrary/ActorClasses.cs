using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ActorLibrary
{
   
    /// <summary>
    /// Class for the player's cities.
    /// </summary>
    public class City
    {
        private Rectangle displayArea;
        private Rectangle canvas;
        

        public City(Rectangle area)
        {
            this.displayArea = area;
        }

        public bool IsHit(Missile missile)
        {
            if (this.displayArea.IntersectsWith(missile.getBounds()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    /// <summary>
    /// Class for the missile objects
    /// </summary>
    public class Missile
    {
        private Rectangle displayArea;
        private Rectangle canvas;
        private int size = 5; 
        private int xVelocity;
        private int yVelocity;

        /// <summary>
        /// Constructor for the missiles. Sets a random start position and fixed velocity
        /// </summary>
        /// <param name="canvas"></param>
        public Missile(Rectangle canvas, Random rand)
        {
            displayArea.Height = size;
            displayArea.Width = size;
            this.canvas = canvas;
            displayArea.X = rand.Next(0, canvas.Width + 1);
            displayArea.Y = 0;
            this.xVelocity = rand.Next(-1, 2); //TODO: change these to increase as a factor of the level.
            this.yVelocity = 5;
            
        }

        public Rectangle getBounds()
        {
            return displayArea;
        }

        public void Move()
        {
            displayArea.X += xVelocity;
            displayArea.Y += yVelocity;
        }

        public void Draw(Graphics graphics)
        {        
            graphics.FillRectangle(Brushes.White, displayArea);
        }
    }

    /// <summary>
    /// Class for the flak explosions the player fires
    /// </summary>
    public class Flak
    {
        public Flak()
        {

        }
    }

    /// <summary>
    /// Aiming reticle the player uses to aim the flak
    /// </summary>
    public class Reticle
    {
        public Reticle()
        {

        }
    }

    /// <summary>
    /// The flak launcher the player uses.
    /// </summary>
    public class Launcher
    {
        public Launcher()
        {

        }
    }
}
