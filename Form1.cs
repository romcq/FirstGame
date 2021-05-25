using System;
using System.Drawing;
using System.Windows.Forms;

namespace FirstGame
{
    public partial class Form1 : Form
    {
        MapChanges map;
        Player player;
        Physics physics;


        public Label scoreLabel;
        public Label livesLabel;

        public Form1()
        {
            InitializeComponent();

            scoreLabel = new Label
            {
                Location = new Point((MapChanges.mapWidth) * 20 + 1, 50)
            };

            livesLabel = new Label
            {
                Location = new Point((MapChanges.mapWidth) * 20 + 1, 100)
            };

            Controls.Add(scoreLabel);
            Controls.Add(livesLabel);

            timer1.Tick += new EventHandler(Update);
            timer2.Tick += new EventHandler(AnimationUpdate);
            timer2.Interval = 100;

            KeyDown += new KeyEventHandler(InputCheck);

            Interactions();
        }

        private void AnimationUpdate(object sender, EventArgs e)
        {
            if (player.platformAnnimationFrame < 2)
            {
                player.platformAnnimationFrame++;
            }
            else
            {
                player.platformAnnimationFrame = 0;
            }
        }

        private void InputCheck(object sender, KeyEventArgs e)
        {
            map.map[player.platformY / 20, player.platformX / 20] = 0;
            map.map[player.platformY / 20, player.platformX / 20 + 1] = 0;
            map.map[player.platformY / 20, player.platformX / 20 + 2] = 0;
            switch (e.KeyCode)
            {
                case Keys.D:
                    if (player.platformX / 20 + 2 < MapChanges.mapWidth - 1)
                    {
                        player.platformX += 5;
                    }

                    break;
                case Keys.A:
                    if (player.platformX > 0)
                    {
                        player.platformX -= 5;
                    }

                    break;
            }
            map.map[player.platformY / 20, player.platformX / 20] = 9;
            map.map[player.platformY / 20, player.platformX / 20 + 1] = 99;
            map.map[player.platformY / 20, player.platformX / 20 + 2] = 999;
        }


        private void Update(object sender, EventArgs e)
        {
            if ((player.ballY / 20) + player.directionY > MapChanges.mapHeight - 1)
            {
                player.lives--;
                if (player.lives <= 0)
                {
                    Interactions();
                }
                else
                {
                    Actions();
                }
            }


            map.map[player.ballY / 20, player.ballX / 20] = 0;
            if (!physics.IsCollide(player, map, scoreLabel))
            {
                player.ballX += player.directionX * 4;
            }

            if (!physics.IsCollide(player, map, scoreLabel))
            {
                player.ballY += player.directionY * 4;
            }

            map.map[player.ballY / 20, player.ballX / 20] = 8;

            map.map[player.platformY / 20, player.platformX / 20] = 9;
            map.map[player.platformY / 20, player.platformX / 20 + 1] = 99;
            map.map[player.platformY / 20, player.platformX / 20 + 2] = 999;

            Invalidate();
        }

        public void GenerationOfPlatforms()
        {
            Random r = new Random();
            for (int i = 0; i < MapChanges.mapHeight / 3; i++)
            {
                for (int j = 0; j < MapChanges.mapWidth; j += 2)
                {
                    var currPlatform = r.Next(1, 5);
                    map.map[i, j] = currPlatform;
                    map.map[i, j + 1] = currPlatform + currPlatform * 10;
                }
            }
        }


        public void Actions()
        {
            timer1.Interval = 1;
            scoreLabel.Text = $"Score: {player.score}";
            livesLabel.Text = $"Lives: {player.lives}";
            map.map[player.platformY / 20, player.platformX / 20] = 9;
            map.map[player.platformY / 20, player.platformX / 20 + 1] = 99;
            map.map[player.platformY / 20, player.platformX / 20 + 2] = 999;
            map.map[player.ballY / 20, player.ballX / 20] = 0;

            player.ballY = 300;
            player.ballX = 300;

            map.map[player.ballY / 20, player.ballX / 20] = 8;

            player.directionX = 1;
            player.directionY = -1;


            timer1.Start();
        }

        public void Interactions()
        {
            map = new MapChanges();
            player = new Player();
            physics = new Physics();

            Width = (MapChanges.mapWidth + 5) * 20;
            Height = (MapChanges.mapHeight + 2) * 20;


            timer1.Interval = 1;

            player.score = 0;
            player.lives = 5;
            scoreLabel.Text = $"Score: {player.score}";
            livesLabel.Text = $"Lives: {player.lives}";
            for (int i = 0; i < MapChanges.mapHeight; i++)
            {
                for (int j = 0; j < MapChanges.mapWidth; j++)
                {
                    map.map[i, j] = 0;
                }
            }

            player.platformX = (MapChanges.mapWidth - 1) / 2 * 20;
            player.platformY = (MapChanges.mapHeight - 1) * 20;

            map.map[player.platformY / 20, player.platformX / 20] = 9;
            map.map[player.platformY / 20, player.platformX / 20 + 1] = 99;
            map.map[player.platformY / 20, player.platformX / 20 + 2] = 999;

            player.ballY = 300;
            player.ballX = 300;

            map.map[player.ballY / 20, player.ballX / 20] = 8;

            player.directionX = 1;
            player.directionY = -1;

            GenerationOfPlatforms();

            timer1.Start();
            timer2.Start();
        }



        private void Painting(object sender, PaintEventArgs e)
        {
            map.DrawArea(e.Graphics);
            map.DrawMap(e.Graphics, player);
        }
    }
}
