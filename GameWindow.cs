using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnhancedSnake
{
    public partial class GameWindow : Form
    {
        private List<Snake_and_food> Snake = new List<Snake_and_food>();
        private List<Snake_and_food> foods = new List<Snake_and_food>();

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        int numFood = Settings.numOfFood;

        Random rand = new Random();

        bool goLeft, goRight, goUp, goDown;

        public GameWindow()
        {
            InitializeComponent();
            DoubleBuffered = true;
            new Limiters();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Limiters.Directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Limiters.Directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Limiters.Directions != "down")
            {
                goUp = true;
            }
            if(e.KeyCode == Keys.Down && Limiters.Directions != "up")
            {
                goDown = true;
            }
        }


        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft)
            {
                Limiters.Directions = "left";
            }
            if (goRight)
            {
                Limiters.Directions = "right";
            }
            if (goUp)
            {
                Limiters.Directions = "up";
            }
            if (goDown)
            {
                Limiters.Directions = "down";
            }

            for(int i=Snake.Count - 1; i>=0; i--)
            {
                if (i == 0)
                {
                    switch (Limiters.Directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                    }

                    for(int j=0; j<numFood; j++)
                    {
                        if(Snake[i].X == foods[j].X && Snake[i].Y == foods[j].Y)
                        {
                            foods.RemoveAt(j);
                            EatFood();
                        }
                    }

                    for(int k = 1; k < Snake.Count; k++)
                    {
                        if(Snake[i].X == Snake[k].X && Snake[i].Y == Snake[k].Y)
                        {
                            GameOver();
                        }
                    }

                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            if(Snake[0].X < 0 || Snake[0].X > maxWidth || Snake[0].Y < 0 || Snake[0].Y > maxHeight)
            {
                GameOver();
            }
            picCanvas.Invalidate();
        }

        private void RestartGame()
        {
            maxWidth = picCanvas.Width / Limiters.Width - 1;
            maxHeight = picCanvas.Height / Limiters.Height - 1;

            Snake.Clear();

            Snake_and_food head = new Snake_and_food { X = 435, Y = 323 };
            Snake.Add(head);

            for (int i = 0; i<5; i++)
            {
                Snake_and_food body = new Snake_and_food();
                Snake.Add(body);
            }

            for(int i = 0; i<numFood; i++)
            {
                Snake_and_food food = new Snake_and_food { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
                foods.Add(food);
            }
            GameTimer.Start();
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColor;

            for(int i=0; i<Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColor = Brushes.Red;
                }
                else
                {
                    snakeColor = Brushes.Green;
                }

                canvas.FillEllipse(snakeColor, new Rectangle(
                    Snake[i].X * Limiters.Width,
                    Snake[i].Y * Limiters.Height,
                    Limiters.Width, Limiters.Height
                    ));
            }
            for(int i=0; i<foods.Count; i++)
            {
                canvas.FillEllipse(Brushes.Blue, new Rectangle(
                    foods[i].X * Limiters.Width,
                    foods[i].Y * Limiters.Height,
                    Limiters.Width, Limiters.Height
                    ));
            }
        }

        private void EatFood()
        {
            score += 1;
            txtScore.Text = "Score: " + score;

            Snake_and_food body = new Snake_and_food
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(body);

            Snake_and_food food = new Snake_and_food { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            foods.Add(food);
        }

        private void GameOver()
        {
            GameTimer.Stop();

            if(score > highScore)
            {
                highScore = score;

                txtHighScore.Text = "High Score: " + Environment.NewLine + highScore;
            }
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
