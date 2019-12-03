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
        private List<City> cityList = new List<City>();
        private List<Missile> missileList = new List<Missile>();
        private readonly Random rand = new Random();
       

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
            DoubleBuffered = true;
            reticle = new Reticle();

            //Build cities and add to the list
            city1 = new City(City1PictureBox.Bounds);
            city2 = new City(City2PictureBox.Bounds);
            city3 = new City(City3PictureBox.Bounds);
            city4 = new City(City4PictureBox.Bounds);
            cityList.Add(city1);
            cityList.Add(city2);
            cityList.Add(city3);
            cityList.Add(city4);

            makeMissiles();

            if (!GameTimer.Enabled)
            {
                GameTimer.Start();
            }           
        }

        private void makeMissiles()
        {
            for (int j = 0; j <= 5; j++)
            {
                missileList.Add(new Missile(GameScreen.DisplayRectangle, rand));
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            foreach (Missile missile in missileList)
            {
                missile.Draw(e.Graphics);
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

            foreach (Missile missile in missileList)
            {
                missile.Move();                
            }
            Invalidate();
            Update();
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
