using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActorLibrary;

namespace MissileCommand
{
    /// <summary>
    /// Class which holds all logic and methods for the primary form.
    /// </summary>
    public partial class Form1 : Form
    {
        private Reticle reticle;
        private City city1;
        private City city2;
        private City city3;
        private City city4;
        private List<City> cityList;
        private List<Missile> missileList;

        /// <summary>
        /// Primary game form constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Executor.ButtonStartClicked += new Delegates.ButtonStartClickedEventHandler(Executor_ButtonStartClick);
        }

        /// <summary>
        /// Primary form load. Loads all the terrain and necessary classes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            
            reticle = new Reticle();
            city1 = new City(City1PictureBox.Bounds);
            city2 = new City(City2PictureBox.Bounds);
            city3 = new City(City3PictureBox.Bounds);
            city4 = new City(City4PictureBox.Bounds);

            cityList.Add(city1);
            cityList.Add(city2);
            cityList.Add(city3);
            cityList.Add(city4);

            if (!GameTimer.Enabled)
            {
                GameTimer.Start();
            }
            

        }

        /// <summary>
        /// On click for the start button. Starts the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Executor_ButtonStartClick(object sender, EventArgs e)
        {
            Console.Write("Here");
        }

        /// <summary>
        /// A timer which controls teh game tick. Set to ~60FPS (16ms)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Tick");
        }
 


        //private void Form1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Left:
        //            {

        //            }
        //        case Keys.Right:
        //            {

        //            }
        //        case Keys.Space:
        //            {

        //            }
        //    }
        //}
    }
}
