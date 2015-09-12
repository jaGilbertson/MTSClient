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

namespace MTS_Client_Simple
{
    partial class MTSGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MTSGUI));
            this.panel4 = new System.Windows.Forms.Panel();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pauseTimer = new System.Windows.Forms.Button();
            this.stopTimer = new System.Windows.Forms.Button();
            this.startTimer = new System.Windows.Forms.Button();
            this.reminingTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.secBox = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.misc3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.misc1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.misc2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.swapBtn = new System.Windows.Forms.Button();
            this.autoUp = new System.Windows.Forms.Button();
            this.roundBox = new System.Windows.Forms.TextBox();
            this.p2Name = new System.Windows.Forms.TextBox();
            this.boBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.p1Score = new System.Windows.Forms.TextBox();
            this.rndLbl = new System.Windows.Forms.Label();
            this.p1Name = new System.Windows.Forms.TextBox();
            this.p2Score = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.aboutBtn);
            this.panel4.Controls.Add(this.resetBtn);
            this.panel4.Controls.Add(this.updateBtn);
            this.panel4.Location = new System.Drawing.Point(600, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 105);
            this.panel4.TabIndex = 29;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(4, 68);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(110, 23);
            this.aboutBtn.TabIndex = 18;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(3, 40);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(111, 23);
            this.resetBtn.TabIndex = 17;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.updateBtn.Location = new System.Drawing.Point(4, 11);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(111, 23);
            this.updateBtn.TabIndex = 16;
            this.updateBtn.Text = "Update All";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pauseTimer);
            this.panel3.Controls.Add(this.stopTimer);
            this.panel3.Controls.Add(this.startTimer);
            this.panel3.Controls.Add(this.reminingTime);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lbl);
            this.panel3.Controls.Add(this.secBox);
            this.panel3.Controls.Add(this.minBox);
            this.panel3.Location = new System.Drawing.Point(412, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 105);
            this.panel3.TabIndex = 28;
            // 
            // pauseTimer
            // 
            this.pauseTimer.Location = new System.Drawing.Point(3, 55);
            this.pauseTimer.Name = "pauseTimer";
            this.pauseTimer.Size = new System.Drawing.Size(174, 23);
            this.pauseTimer.TabIndex = 14;
            this.pauseTimer.Text = "Pause Timer";
            this.pauseTimer.UseVisualStyleBackColor = true;
            this.pauseTimer.Click += new System.EventHandler(this.pauseTimer_Click);
            // 
            // stopTimer
            // 
            this.stopTimer.Location = new System.Drawing.Point(3, 79);
            this.stopTimer.Name = "stopTimer";
            this.stopTimer.Size = new System.Drawing.Size(174, 23);
            this.stopTimer.TabIndex = 15;
            this.stopTimer.Text = "Stop Timer";
            this.stopTimer.UseVisualStyleBackColor = true;
            this.stopTimer.Click += new System.EventHandler(this.stopTimer_Click);
            // 
            // startTimer
            // 
            this.startTimer.Location = new System.Drawing.Point(3, 30);
            this.startTimer.Name = "startTimer";
            this.startTimer.Size = new System.Drawing.Size(174, 23);
            this.startTimer.TabIndex = 13;
            this.startTimer.Text = "Start Timer";
            this.startTimer.UseVisualStyleBackColor = true;
            this.startTimer.Click += new System.EventHandler(this.startTimer_Click);
            // 
            // reminingTime
            // 
            this.reminingTime.AutoSize = true;
            this.reminingTime.Location = new System.Drawing.Point(128, 8);
            this.reminingTime.Name = "reminingTime";
            this.reminingTime.Size = new System.Drawing.Size(0, 13);
            this.reminingTime.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = ":";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(1, 8);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(30, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Time";
            // 
            // secBox
            // 
            this.secBox.Location = new System.Drawing.Point(83, 5);
            this.secBox.Name = "secBox";
            this.secBox.Size = new System.Drawing.Size(38, 20);
            this.secBox.TabIndex = 12;
            this.secBox.Text = "00";
            this.secBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(37, 5);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(36, 20);
            this.minBox.TabIndex = 11;
            this.minBox.Text = "00";
            this.minBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.misc3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.misc1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.misc2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(15, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 85);
            this.panel2.TabIndex = 26;
            // 
            // misc3
            // 
            this.misc3.Location = new System.Drawing.Point(46, 57);
            this.misc3.Name = "misc3";
            this.misc3.Size = new System.Drawing.Size(654, 20);
            this.misc3.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Misc 3";
            // 
            // misc1
            // 
            this.misc1.Location = new System.Drawing.Point(46, 3);
            this.misc1.Name = "misc1";
            this.misc1.Size = new System.Drawing.Size(654, 20);
            this.misc1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Misc 2";
            // 
            // misc2
            // 
            this.misc2.Location = new System.Drawing.Point(46, 30);
            this.misc2.Name = "misc2";
            this.misc2.Size = new System.Drawing.Size(654, 20);
            this.misc2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Misc 1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.swapBtn);
            this.panel1.Controls.Add(this.autoUp);
            this.panel1.Controls.Add(this.roundBox);
            this.panel1.Controls.Add(this.p2Name);
            this.panel1.Controls.Add(this.boBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.p1Score);
            this.panel1.Controls.Add(this.rndLbl);
            this.panel1.Controls.Add(this.p1Name);
            this.panel1.Controls.Add(this.p2Score);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(15, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 105);
            this.panel1.TabIndex = 25;
            // 
            // swapBtn
            // 
            this.swapBtn.Location = new System.Drawing.Point(64, 26);
            this.swapBtn.Name = "swapBtn";
            this.swapBtn.Size = new System.Drawing.Size(308, 23);
            this.swapBtn.TabIndex = 13;
            this.swapBtn.Text = "Swap";
            this.swapBtn.UseVisualStyleBackColor = true;
            this.swapBtn.Click += new System.EventHandler(this.swapBtn_Click);
            // 
            // autoUp
            // 
            this.autoUp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.autoUp.Location = new System.Drawing.Point(207, 77);
            this.autoUp.Name = "autoUp";
            this.autoUp.Size = new System.Drawing.Size(165, 23);
            this.autoUp.TabIndex = 7;
            this.autoUp.Text = "Auto Update Scores: OFF";
            this.autoUp.UseVisualStyleBackColor = true;
            this.autoUp.Click += new System.EventHandler(this.autoUp_Click);
            // 
            // roundBox
            // 
            this.roundBox.Location = new System.Drawing.Point(64, 77);
            this.roundBox.Name = "roundBox";
            this.roundBox.Size = new System.Drawing.Size(46, 20);
            this.roundBox.TabIndex = 5;
            this.roundBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p2Name
            // 
            this.p2Name.Location = new System.Drawing.Point(64, 51);
            this.p2Name.Name = "p2Name";
            this.p2Name.Size = new System.Drawing.Size(227, 20);
            this.p2Name.TabIndex = 3;
            // 
            // boBox
            // 
            this.boBox.Location = new System.Drawing.Point(143, 77);
            this.boBox.Name = "boBox";
            this.boBox.Size = new System.Drawing.Size(46, 20);
            this.boBox.TabIndex = 6;
            this.boBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "of";
            // 
            // p1Score
            // 
            this.p1Score.Location = new System.Drawing.Point(340, 3);
            this.p1Score.Name = "p1Score";
            this.p1Score.Size = new System.Drawing.Size(32, 20);
            this.p1Score.TabIndex = 2;
            this.p1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rndLbl
            // 
            this.rndLbl.AutoSize = true;
            this.rndLbl.Location = new System.Drawing.Point(19, 80);
            this.rndLbl.Name = "rndLbl";
            this.rndLbl.Size = new System.Drawing.Size(39, 13);
            this.rndLbl.TabIndex = 11;
            this.rndLbl.Text = "Round";
            // 
            // p1Name
            // 
            this.p1Name.Location = new System.Drawing.Point(64, 3);
            this.p1Name.Name = "p1Name";
            this.p1Name.Size = new System.Drawing.Size(227, 20);
            this.p1Name.TabIndex = 1;
            // 
            // p2Score
            // 
            this.p2Score.Location = new System.Drawing.Point(340, 51);
            this.p2Score.Name = "p2Score";
            this.p2Score.Size = new System.Drawing.Size(32, 20);
            this.p2Score.TabIndex = 4;
            this.p2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "vs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player A";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MTSGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 213);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(753, 252);
            this.Name = "MTSGUI";
            this.Text = "MTS Client Simple";
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button pauseTimer;
        private System.Windows.Forms.Button stopTimer;
        private System.Windows.Forms.Button startTimer;
        private System.Windows.Forms.Label reminingTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox secBox;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox misc3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox misc1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox misc2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button autoUp;
        private System.Windows.Forms.TextBox roundBox;
        private System.Windows.Forms.TextBox p2Name;
        private System.Windows.Forms.TextBox boBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox p1Score;
        private System.Windows.Forms.Label rndLbl;
        private System.Windows.Forms.TextBox p1Name;
        private System.Windows.Forms.TextBox p2Score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

        

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button swapBtn;
    }
}

