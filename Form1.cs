﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace RocketScience
{
    public partial class Game : Form
    {
        Timer gameTimer = null;
        Timer rocketTimer = null;
        int horVelocity = 0;
        int rocketImageCounter = 0;

        public Game()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 10;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();

            rocketTimer = new Timer();
            rocketTimer.Interval = 50;
            rocketTimer.Tick += RocketTimer_Tick;
            rocketTimer.Start();

            this.KeyDown += Game_KeyDown;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            rocket.Left += horVelocity;
        }

        private void RocketTimer_Tick(object sender, EventArgs e)
        {
            string rocketImage = $"rocket_off_00{rocketImageCounter}";
            rocket.Image = (Image)Properties.Resources.ResourceManager.GetObject(rocketImage);
            rocketImageCounter += 1;
            if(rocketImageCounter > 3) rocketImageCounter = 0;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                horVelocity = -5;
            }
            else if(e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                horVelocity = +5;
            }
            else if(e.KeyCode == Keys.Space)
            {
                Bullet bullet = new Bullet();
                bullet.Left = rocket.Left + rocket.Width / 2;
                bullet.Top = rocket.Top;
                this.Controls.Add(bullet);
            }
        }




        private void Rocket_Click(object sender, EventArgs e)
        {

        }
    }


    class Bullet : PictureBox
    {
        Timer bulletTimer = null;
        int verVelocity = -5;


        public Bullet()
        {
            this.Width = 3;
            this.Height = 10;
            this.BackColor = Color.Red;

            InitializeBullet();
        }

        private void InitializeBullet()
        {
            bulletTimer = new Timer();
            bulletTimer.Interval = 10;
            bulletTimer.Tick += BulletTimer_Tick;
            bulletTimer.Start();
        }

        private void BulletTimer_Tick (object sender, EventArgs e)
        {
            this.Top += verVelocity; 
        }
    }
}
