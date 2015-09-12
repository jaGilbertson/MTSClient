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
using System.Linq;
using System.Windows.Forms;

namespace MTS_Client_Simple
{
    static class MTSManager
    {
        static private MTSGUI gui;
        static private bool autoUpdate = false, countDown = false, paused = false;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            gui = new MTSGUI();
            Application.Run(gui);
            writeAllFiles();
        }

        static public void writeAllFiles()
        {
            System.IO.File.WriteAllText(@"playerA.txt", gui.getP1Name());
            System.IO.File.WriteAllText(@"playerB.txt", gui.getP2Name());
            System.IO.File.WriteAllText(@"playerAScore.txt", gui.getP1Score());
            System.IO.File.WriteAllText(@"playerBScore.txt", gui.getP2Score());
            System.IO.File.WriteAllText(@"currentRound.txt", gui.getRound());
            System.IO.File.WriteAllText(@"totalRounds.txt", gui.getMaxRound());
            System.IO.File.WriteAllText(@"misc1.txt", gui.getMisc1());
            System.IO.File.WriteAllText(@"misc2.txt", gui.getMisc2());
            System.IO.File.WriteAllText(@"misc3.txt", gui.getMisc3());
        }

        static public void tick()
        {
            System.IO.File.WriteAllText(@"timer.txt", "");
            if (countDown)
            {
                string minuteString;
                string secondString;
                int minutes = Int32.Parse(gui.getMinutes());
                int seconds = Int32.Parse(gui.getSeconds());
                if (!paused)
                {
                    if (seconds == 0)
                    {
                        if (minutes > 0)
                        {
                            minutes--;
                            seconds = 59;
                        }
                        else
                        {
                            countDown = false;
                        }
                    }
                    else
                    {
                        seconds--;
                    }

                    if (minutes < 10)
                    {
                        minuteString = "0" + minutes;
                    }
                    else
                    {
                        minuteString = "" + minutes;
                    }

                    if (seconds < 10)
                    {
                        secondString = "0" + seconds;
                    }
                    else
                    {
                        secondString = "" + seconds;
                    }
                    gui.setTimer(secondString, minuteString);
                    System.IO.File.WriteAllText(@"timer.txt", minuteString + ":" + secondString);
                }
            }

            if (autoUpdate)
            {
                System.IO.File.WriteAllText(@"playerAScore.txt", gui.getP1Score());
                System.IO.File.WriteAllText(@"playerBScore.txt", gui.getP2Score());
            }
        }

        static public void setCountdown(bool check){
            countDown = check;
        }

        static public bool getCountdown()
        {
            return countDown;
        }

        static public void setAutoUpdate(bool check)
        {
            autoUpdate = check;
        }

        static public bool getAutoUpdate()
        {
            return autoUpdate;
        }

        static public void setPaused(bool check)
        {
            paused = check;
        }

        static public bool getPaused()
        {
            return paused;
        }
    }
}
