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
        public Missile(Rectangle canvas, Random rand)
        {
            displayArea.Height = size;
            displayArea.Width = size;
            this.canvas = canvas;
            displayArea.X = rand.Next(50, canvas.Width - 50);
            displayArea.Y = 0;
            originX = displayArea.X;
            originY = displayArea.Y;
            if (displayArea.X < canvas.Width / 2)
            {
                this.xVelocity = rand.Next(1, 2);
            }
            else
            {
                this.xVelocity = rand.Next(-2, 1);
            }
            this.yVelocity = 5;
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
