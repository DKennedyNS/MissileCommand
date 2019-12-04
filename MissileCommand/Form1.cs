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
        private City city1;
        private City city2;
        private City city3;
        private City city4;
        private List<City> cityList = new List<City>();
        private List<Missile> missileList = new List<Missile>();
        private List<Flak> flakList = new List<Flak>();
        private readonly Random rand = new Random();
        private int round = 0;
        private int level = 1;
        private bool run = false;
       

        /// <summary>
        /// Primary game form constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Executor.ButtonStartClicked += new Delegates.ButtonStartClickedEventHandler(Executor_ButtonStartClick);
            Executor.GameScreenClicked += new Delegates.GameScreenClickedEventHandler(Executor_GameScreenClick);
        }

        /// <summary>
        /// Primary form load. Loads all the terrain and necessary classes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {        
            DoubleBuffered = true;

            //Build cities and add to the list
            city1 = new City(City1PictureBox.Bounds, "city1");
            city2 = new City(City2PictureBox.Bounds, "city2");
            city3 = new City(City3PictureBox.Bounds, "city3");
            city4 = new City(City4PictureBox.Bounds, "city4");
            cityList.Add(city1);
            cityList.Add(city2);
            cityList.Add(city3);
            cityList.Add(city4);
          
        }

        /// <summary>
        /// Create a series of missiles on the game screen
        /// </summary>
        private void makeMissiles()
        {   
            if(round < 4)
            {
                for (int j = 0; j <= 5; j++)
                {
                    missileList.Add(new Missile(GameScreen.DisplayRectangle, rand));
                }
            }
            else
            {
                level++;
            }
        }

        /// <summary>
        /// Paint the current form. Called on load and redraw
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            foreach (Missile missile in missileList)
            {
                missile.Draw(e.Graphics);
            }

            foreach (Flak flak in flakList)
            {
                flak.Draw(e.Graphics);
            }

        }

        /// <summary>
        /// On click for the start button. Starts the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Executor_ButtonStartClick(object sender, EventArgs e)
        {
            if (!run)
            {
                run = true;
                makeMissiles();

                if (!GameTimer.Enabled)
                {
                    GameTimer.Start();
                }
            }
        }

        private void Executor_GameScreenClick(object sender, MouseEventArgs e)
        {
            Point point = e.Location;
            Console.WriteLine(point);
            flakList.Add(new Flak(point));
        }

        /// <summary>
        /// A timer which controls teh game tick. Set to ~60FPS (16ms)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Tick");

            //If we still have missles up, go through each and update position.
            //Go through each city and see if the missile hit it, if so remove the city.
            if (missileList.Count != 0 && round < 4 && cityList.Count != 0)
            {
                foreach (Missile missile in missileList)
                {
                    missile.Move();
                    foreach (City city in cityList)
                    {
                        if (city.IsHit(missile))
                        {
                            missile.hit = true;
                            switch (city.getName())
                            {
                                case "city1":
                                    {
                                        City1PictureBox.Visible = false;
                                        city.setDestroyed(true);
                                        break;
                                    }
                                case "city2":
                                    {
                                        City2PictureBox.Visible = false;
                                        city.setDestroyed(true);
                                        break;
                                    }
                                case "city3":
                                    {
                                        City3PictureBox.Visible = false;
                                        city.setDestroyed(true);
                                        break;
                                    }
                                case "city4":
                                    {
                                        City4PictureBox.Visible = false;
                                        city.setDestroyed(true);
                                        break;
                                    }                                    
                            }
                        }
                    }
                }

                //Go through the city list and remove the destroyed ones.
                foreach (var city in cityList.ToList())
                {
                    if (city.isDestroyed())
                    {
                        cityList.Remove(city);
                    }
                }

                // If the player still has cities, go through the missile list and remove the destroyed ones.
                foreach (var missile in missileList.ToList())
                {
                    if(cityList.Count == 0)
                    {
                        missileList.Clear();
                    }
                    else if (missile.getBounds().Top > 620 || missile.hit == true)
                    {
                        missileList.Remove(missile);
                    }
                }

                //Force the screen to redraw
                Invalidate();
                Update();
            }
            else
            {
                round++;
                makeMissiles();
            }

        }          
    }
}
