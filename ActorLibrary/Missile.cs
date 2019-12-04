using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ActorLibrary
{
    /// <summary>
    /// Class for the missile objects the player defends against
    /// </summary>
    public class Missile
    {
        //Class vars
        private Rectangle displayArea;
        private Rectangle canvas;
        private int size = 5;
        private int xVelocity;
        private int yVelocity;
        private int originX;
        private int originY;
        public bool hit = false;

        /// <summary>
        /// Constructor for the missile. Sets a random start position and semi-fixed velocity
        /// </summary>
        /// <param name="canvas"></param>
        public Missile(Rectangle canvas, Random rand, int level)
        {
            displayArea.Height = size;
            displayArea.Width = size;
            this.canvas = canvas;
            displayArea.X = rand.Next(50, canvas.Width - 50);
            displayArea.Y = 0;
            originX = displayArea.X;
            originY = displayArea.Y;

            //Make sure the missile can't go off the side of the screen
            if (displayArea.X < canvas.Width / 2)
            {
                this.xVelocity = rand.Next(0, 2);
            }
            else
            {
                this.xVelocity = rand.Next(-2, 0);
            }

            this.yVelocity = 3 + level;
            
            
        }

        /// <summary>
        /// Updates the missile's position
        /// </summary>
        public void Move()
        {
            displayArea.X += xVelocity;
            displayArea.Y += yVelocity;
        }

        /// <summary>
        /// Draws the missile
        /// </summary>
        /// <param name="graphics"></param>
        public void Draw(Graphics graphics)
        {
            graphics.FillRectangle(Brushes.White, displayArea);
            graphics.DrawLine(Pens.DarkRed, displayArea.X, displayArea.Y, originX, originY);
        }

        //Getters and setters
        /// <summary>
        /// Returns the bounds of the missile
        /// </summary>
        /// <returns></returns>
        public Rectangle getBounds()
        {
            return displayArea;
        }
    }
}
