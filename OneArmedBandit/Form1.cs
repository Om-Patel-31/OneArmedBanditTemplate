﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // random number generator
        Random rangen = new Random();

        // int value for score initialized to 10
        int score = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            // get random values for each reel (store each in separate int variable)
            int reel1 = rangen.Next(1, 4);
            int reel2 = rangen.Next(1, 4);
            int reel3 = rangen.Next(1, 4);

            for (int i = 0; i < 10; i++)
            {
                //this image here, this there and this there. refresh and then wait for sometime. show random images randomly.do this ten times
                // Generate random values for each reel during animation
                int animReel1 = rangen.Next(1, 4);
                int animReel2 = rangen.Next(1, 4);
                int animReel3 = rangen.Next(1, 4);

                // Set the random images for the animation
                switch (animReel1)
                {
                    case 1:
                        pictureBox1.BackgroundImage = Properties.Resources.cherry_100x125;
                        break;
                    case 2:
                        pictureBox1.BackgroundImage = Properties.Resources.diamond_100x125;
                        break;
                    case 3:
                        pictureBox1.BackgroundImage = Properties.Resources._7_100x125;
                        break;
                }

                switch (animReel2)
                {
                    case 1:
                        pictureBox2.BackgroundImage = Properties.Resources.cherry_100x125;
                        break;
                    case 2:
                        pictureBox2.BackgroundImage = Properties.Resources.diamond_100x125;
                        break;
                    case 3:
                        pictureBox2.BackgroundImage = Properties.Resources._7_100x125;
                        break;
                }

                switch (animReel3)
                {
                    case 1:
                        pictureBox3.BackgroundImage = Properties.Resources.cherry_100x125;
                        break;
                    case 2:
                        pictureBox3.BackgroundImage = Properties.Resources.diamond_100x125;
                        break;
                    case 3:
                        pictureBox3.BackgroundImage = Properties.Resources._7_100x125;
                        break;
                }

                // Refresh the form to update the images
                pictureBox1.Refresh();
                pictureBox2.Refresh();
                pictureBox3.Refresh();

                // Pause for a short time to simulate animation
                System.Threading.Thread.Sleep(100);
            }

            // check value of reel 1 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch (reel1)
            {
                case 1:
                    pictureBox1.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 2:
                    pictureBox1.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
                case 3:
                    pictureBox1.BackgroundImage = Properties.Resources._7_100x125;
                    break;
            }

            // check value of reel 2 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch (reel2)
            {
                case 1:
                    pictureBox1.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 2:
                    pictureBox1.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
                case 3:
                    pictureBox1.BackgroundImage = Properties.Resources._7_100x125;
                    break;
            }

            // check value of reel 3 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch (reel3)
            {
                case 1:
                    pictureBox3.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 2:
                    pictureBox3.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
                case 3:
                    pictureBox3.BackgroundImage = Properties.Resources._7_100x125;
                    break;
            }

            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score.         
            if (reel1 == reel2 && reel2 == reel3 && reel3 == reel1)
            {
                outputLabel.Text = "Winner";
                score += 3;
                scoreDisplay.Text = $"{score}";
            }
            else
            {
                outputLabel.Text = "Play Again";
                score -= 1;
                scoreDisplay.Text = $"{score}";
            }

            // if score has reached 0 display "lose" message and set button enabled property to false
            if (score == 0)
            {
                outputLabel.Text = "Lose";
                spinButton.Enabled = false;
            }

            // display updated score
            scoreDisplay.Text = $"{score}";
        }
    }
}
