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
        private int score;
        private bool gameOver = false;
        private bool levelEnd = false;
       

        /// <summary>
        /// Primary game form constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Executor.ButtonStartClicked += new Delegates.ButtonStartClickedEventHandler(Executor_ButtonStartClick);
            Executor.GameScreenClicked += new Delegates.GameScreenClickedEventHandler(Executor_GameScreenClick);

            //Build cities
            city1 = new City(City1PictureBox.Bounds, "city1");
            city2 = new City(City2PictureBox.Bounds, "city2");
            city3 = new City(City3PictureBox.Bounds, "city3");
            city4 = new City(City4PictureBox.Bounds, "city4");
            //Add cities to the list        
            cityList.Add(city1);
            cityList.Add(city2);
            cityList.Add(city3);
            cityList.Add(city4);
        }

        /// <summary>
        /// Primary form load. Loads all the terrain and necessary classes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {        
            DoubleBuffered = true;

            LevelText.Text = "Level: " + level;
     
            LevelEndScreen.Visible = false;
            LevelEndScoreText.Visible = false;
            LevelEndText.Visible = false;
            ContinueText.Visible = false;
          
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
                score += 500;
                LevelEnd();
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

            ScoreText.Text = "Score: " + score;

        }

        private void LevelEnd()
        {
            GameTimer.Stop();
            levelEnd = true;
            LevelEndScreen.Visible = true;
            LevelEndScoreText.Text = "Score: " + score;
            LevelEndScoreText.Visible = true;
       
            if (!gameOver)
            {
                LevelEndText.Text = "Level " + level + " Complete!";
                ContinueText.Visible = true;
            }
            else
            {
                LevelEndText.Text = "Game Over!";
            }
            LevelEndText.Visible = true;
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
                ContinueText.Visible = false;
                run = true;
                makeMissiles();

                if (!GameTimer.Enabled)
                {
                    GameTimer.Start();
                }
            }
            else if(levelEnd)
            {
                level++;
                round = 0;
                Form1_Load(sender, e);
                levelEnd = false;
                GameTimer.Start();
            }
        }

        /// <summary>
        /// Spawn flak where the user clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Executor_GameScreenClick(object sender, MouseEventArgs e)
        {
            flakList.Add(new Flak(e.Location));
        }

        /// <summary>
        /// A timer which controls teh game tick. Set to ~60FPS (16ms)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Tick");

            //If we still have missiles up, go through each and update position.
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

                    //Go through the flakList and see if any missiles got hit
                    foreach(Flak flak in flakList)
                    {
                        if (flak.IsHit(missile))
                        {
                            score += 1000;
                            missile.hit = true;
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

                if(cityList.Count() == 0)
                {
                    gameOver = true;
                    LevelEnd();
                    missileList.Clear();
                    flakList.Clear();
                }
                else
                {
                    // If the player still has cities, go through the missile list and remove the destroyed ones.
                    foreach (var missile in missileList.ToList())
                    {
                        if (missile.getBounds().Top > 620 || missile.hit == true)
                        {
                            missileList.Remove(missile);
                        }
                    }

                    foreach (Flak flak in flakList.ToList())
                    {
                        if (flak.isDisposed())
                        {
                            flakList.Remove(flak);
                        }
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
