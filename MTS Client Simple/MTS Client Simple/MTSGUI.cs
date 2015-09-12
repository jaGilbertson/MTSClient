/*
 * Copyright (C) 2015 Jamie Gilbertson
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MTS_Client_Simple
{
    public partial class MTSGUI : Form
    {
        public MTSGUI()
        {
            InitializeComponent();
            timer1.Start();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MTSManager.writeAllFiles();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p1Name.Text = "";
            p2Name.Text = "";
            p1Score.Text = "";
            p2Score.Text = "";
            roundBox.Text = "";
            boBox.Text = "";
            misc1.Text = "";
            misc2.Text = "";
            misc3.Text = "";
            minBox.Text = "00";
            secBox.Text = "00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MTSManager.tick();
        }

        private void autoUp_Click(object sender, EventArgs e)
        {
            if (MTSManager.getAutoUpdate())
            {
                MTSManager.setAutoUpdate(false);
                autoUp.Text = "Auto Update Scores: OFF";
            }
            else
            {
                MTSManager.setAutoUpdate(true);
                autoUp.Text = "Auto Update Scores: ON";
            }
        }

        private void startTimer_Click(object sender, EventArgs e)
        {
            int temp;
            if (Int32.TryParse(minBox.Text, out temp))
            {
                if (Int32.TryParse(secBox.Text, out temp))
                {
                    if (temp < 60)
                    {
                        MTSManager.setCountdown(true);
                    }
                    else
                    {
                        MessageBox.Show("Seconds must be between 0 - 59");
                    }
                }
                else
                {
                    MessageBox.Show("Seconds entered is invalid");
                }
            }
            else
            {
                MessageBox.Show("Minutes entered is invalid");
            }
        }

        private void pauseTimer_Click(object sender, EventArgs e)
        {
            if (MTSManager.getPaused())
            {
                MTSManager.setPaused(false);
                pauseTimer.Text = "Pause";
            }
            else
            {
                MTSManager.setPaused(true);
                pauseTimer.Text = "Unpause";
            }
        }

        private void stopTimer_Click(object sender, EventArgs e)
        {
            MTSManager.setCountdown(false);
            minBox.Text = "00";
            secBox.Text = "00";
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Jamie Gilbertson\ndmechachomp@gmail.com\ntwitter.com/mechachomp");
        }

        public string getP1Name()
        {
            return p1Name.Text;
        }

        public string getP2Name()
        {
            return p2Name.Text;
        }

        public string getP1Score()
        {
            return p1Score.Text;
        }

        public string getP2Score()
        {
            return p2Score.Text;
        }

        public string getRound()
        {
            return roundBox.Text;
        }

        public string getMaxRound()
        {
            return boBox.Text;
        }

        public string getMisc1()
        {
            return misc1.Text;
        }

        public string getMisc2()
        {
            return misc2.Text;
        }

        public string getMisc3()
        {
            return misc3.Text;
        }

        public string getMinutes()
        {
            return minBox.Text;
        }

        public string getSeconds()
        {
            return secBox.Text;
        }

        public void setTimer(string seconds, string minutes)
        {
            minBox.Text = minutes;
            secBox.Text = seconds;
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            String temp;
            temp = p1Name.Text;
            p1Name.Text = p2Name.Text;
            p2Name.Text = temp;
            temp = p1Score.Text;
            p1Score.Text = p2Score.Text;
            p2Score.Text = temp;
            MTSManager.writeAllFiles();
        }
    }
}
