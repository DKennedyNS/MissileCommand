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

        public bool IsHit()
        {
            if(this.displayArea.IntersectsWith)
        }
    }

    /// <summary>
    /// Class for the missile objects
    /// </summary>
    public class Missile
    {
        public Missile()
        {

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
