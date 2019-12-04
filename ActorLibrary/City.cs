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
        private string name;
        private bool destroyed = false;

        /// <summary>
        /// Contructor for the city class.
        /// </summary>
        /// <param name="area"></param>
        /// <param name="name"></param>
        public City(Rectangle area, string name)
        {
            this.displayArea = area;
            this.name = name;
        }

        /// <summary>
        /// Checks to see if the city got hit by a specific missile
        /// </summary>
        /// <param name="missile"></param>
        /// <returns></returns>
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

        //Getters and setters
        /// <summary>
        /// Returns the city name
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// Sets the city to destroyed or not
        /// </summary>
        /// <param name="destroyed"></param>
        public void setDestroyed(bool destroyed)
        {
            this.destroyed = destroyed;
        }

        /// <summary>
        /// Returns if the city has been destroyed
        /// </summary>
        /// <returns></returns>
        public bool isDestroyed()
        {
            return this.destroyed;
        }
    }
}
