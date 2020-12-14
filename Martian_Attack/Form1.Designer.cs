
namespace Martian_Attack
{
    partial class Form1
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
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.PipeUpTwo = new System.Windows.Forms.PictureBox();
            this.PipeDownOne = new System.Windows.Forms.PictureBox();
            this.PipeDownTwo = new System.Windows.Forms.PictureBox();
            this.PipeUpOne = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPlayer = new System.Windows.Forms.PictureBox();
            this.Star4 = new System.Windows.Forms.PictureBox();
            this.Star2 = new System.Windows.Forms.PictureBox();
            this.Star1 = new System.Windows.Forms.PictureBox();
            this.Star10 = new System.Windows.Forms.PictureBox();
            this.Star3 = new System.Windows.Forms.PictureBox();
            this.Star5 = new System.Windows.Forms.PictureBox();
            this.Star6 = new System.Windows.Forms.PictureBox();
            this.Star7 = new System.Windows.Forms.PictureBox();
            this.Star9 = new System.Windows.Forms.PictureBox();
            this.Star8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PipeUpTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDownOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDownTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeUpOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star8)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Ravie", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(0, 5);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(168, 36);
            this.ScoreLabel.TabIndex = 11;
            this.ScoreLabel.Text = "Score: 0";
            this.ScoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // PipeUpTwo
            // 
            this.PipeUpTwo.Image = global::Martian_Attack.Properties.Resources.Pipe;
            this.PipeUpTwo.Location = new System.Drawing.Point(650, 258);
            this.PipeUpTwo.Name = "PipeUpTwo";
            this.PipeUpTwo.Size = new System.Drawing.Size(59, 192);
            this.PipeUpTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PipeUpTwo.TabIndex = 16;
            this.PipeUpTwo.TabStop = false;
            // 
            // PipeDownOne
            // 
            this.PipeDownOne.Image = global::Martian_Attack.Properties.Resources.Pipe;
            this.PipeDownOne.Location = new System.Drawing.Point(396, 0);
            this.PipeDownOne.Name = "PipeDownOne";
            this.PipeDownOne.Size = new System.Drawing.Size(56, 141);
            this.PipeDownOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PipeDownOne.TabIndex = 15;
            this.PipeDownOne.TabStop = false;
            // 
            // PipeDownTwo
            // 
            this.PipeDownTwo.Image = global::Martian_Attack.Properties.Resources.Pipe;
            this.PipeDownTwo.Location = new System.Drawing.Point(562, 0);
            this.PipeDownTwo.Name = "PipeDownTwo";
            this.PipeDownTwo.Size = new System.Drawing.Size(53, 141);
            this.PipeDownTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PipeDownTwo.TabIndex = 14;
            this.PipeDownTwo.TabStop = false;
            // 
            // PipeUpOne
            // 
            this.PipeUpOne.Image = global::Martian_Attack.Properties.Resources.Pipe;
            this.PipeUpOne.Location = new System.Drawing.Point(393, 277);
            this.PipeUpOne.Name = "PipeUpOne";
            this.PipeUpOne.Size = new System.Drawing.Size(59, 173);
            this.PipeUpOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PipeUpOne.TabIndex = 13;
            this.PipeUpOne.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Martian_Attack.Properties.Resources.MyGround;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 392);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MainPlayer
            // 
            this.MainPlayer.BackColor = System.Drawing.Color.Transparent;
            this.MainPlayer.Image = global::Martian_Attack.Properties.Resources.PhotoshopShip;
            this.MainPlayer.Location = new System.Drawing.Point(142, 122);
            this.MainPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.MainPlayer.Name = "MainPlayer";
            this.MainPlayer.Size = new System.Drawing.Size(40, 31);
            this.MainPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPlayer.TabIndex = 0;
            this.MainPlayer.TabStop = false;
            // 
            // Star4
            // 
            this.Star4.Image = global::Martian_Attack.Properties.Resources.Star;
            this.Star4.Location = new System.Drawing.Point(184, 22);
            this.Star4.Margin = new System.Windows.Forms.Padding(2);
            this.Star4.Name = "Star4";
            this.Star4.Size = new System.Drawing.Size(30, 19);
            this.Star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Star4.TabIndex = 4;
            this.Star4.TabStop = false;
            // 
            // Star2
            // 
            this.Star2.Image = global::Martian_Attack.Properties.Resources.Star;
            this.Star2.Location = new System.Drawing.Point(240, 122);
            this.Star2.Margin = new System.Windows.Forms.Padding(2);
            this.Star2.Name = "Star2";
            this.Star2.Size = new System.Drawing.Size(30, 19);
            this.Star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Star2.TabIndex = 2;
            this.Star2.TabStop = false;
            // 
            // Star1
            // 
            this.Star1.Image = global::Martian_Attack.Properties.Resources.Star;
            this.Star1.Location = new System.Drawing.Point(45, 122);
            this.Star1.Margin = new System.Windows.Forms.Padding(2);
            this.Star1.Name = "Star1";
            this.Star1.Size = new System.Drawing.Size(30, 19);
            this.Star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Star1.TabIndex = 1;
            this.Star1.TabStop = false;
            // 
            // Star10
            // 
            this.Star10.Image = global::Martian_Attack.Properties.Resources.Star;
            this.Star10.Location = new System.Drawing.Point(334, 88);
            this.Star10.Margin = new System.Windows.Forms.Padding(2);
            this.Star10.Name = "Star10";
            this.Star10.Size = new System.Drawing.Size(30, 19);
            this.Star10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Star10.TabIndex = 10;
            this.Star10.TabStop = false;
            // 
            // Star3
            // 
            this.Star3.Image = global::Martian_Attack.Properties.Resources.Star;
            this.Star3.Location = new System.Drawing.Point(297, 17);
            this.Star3.Margin = new System.Windows.Forms.Padding(2);
            this.Star3.Name = "Star3";
            this.Star3.Size = new System.Drawing.Size(30, 19);
            this.Star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Star3.TabIndex = 3;
            this.Star3.TabStop = false;
            // 
            // Star5
            // 
            this.Star5.Image = global::Martian_Attack.Properties.Resources.Star;
            this.Star5.Location = new System.Drawing.Point(400, 45);
            this.Star5.Margin = new System.Windows.Forms.Padding(2);
            this.Star5.Name = "Star5";
            this.Star5.Size = new System.Drawing.Size(30, 19);
            this.Star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Star5.TabIndex = 5;
            this.Star5.TabStop = false;
            // 
            // Star6
            // 
            this.Star6.Image = global::Martian_Attack.Properties.Resources.Star;
            this.Star6.Location = new System.Drawing.Point(455, 127);
            this.Star6.Margin = new System.Windows.Forms.Padding(2);
            this.Star6.Name = "Star6";
            this.Star6.Size = new System.Drawing.Size(30, 19);
            this.Star6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Star6.TabIndex = 6;
            this.Star6.TabStop = false;
            // 
            // Star7
            // 
            this.Star7.Image = global::Martian_Attack.Properties.Resources.Star;
            this.Star7.Location = new System.Drawing.Point(517, 17);
            this.Star7.Margin = new System.Windows.Forms.Padding(2);
            this.Star7.Name = "Star7";
            this.Star7.Size = new System.Drawing.Size(30, 19);
            this.Star7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Star7.TabIndex = 7;
            this.Star7.TabStop = false;
            // 
            // Star9
            // 
            this.Star9.Image = global::Martian_Attack.Properties.Resources.Star;
            this.Star9.Location = new System.Drawing.Point(610, 33);
            this.Star9.Margin = new System.Windows.Forms.Padding(2);
            this.Star9.Name = "Star9";
            this.Star9.Size = new System.Drawing.Size(30, 19);
            this.Star9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Star9.TabIndex = 9;
            this.Star9.TabStop = false;
            // 
            // Star8
            // 
            this.Star8.Image = global::Martian_Attack.Properties.Resources.Star;
            this.Star8.Location = new System.Drawing.Point(620, 97);
            this.Star8.Margin = new System.Windows.Forms.Padding(2);
            this.Star8.Name = "Star8";
            this.Star8.Size = new System.Drawing.Size(30, 19);
            this.Star8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Star8.TabIndex = 8;
            this.Star8.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PipeDownOne);
            this.Controls.Add(this.PipeDownTwo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainPlayer);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Star4);
            this.Controls.Add(this.Star2);
            this.Controls.Add(this.Star1);
            this.Controls.Add(this.Star10);
            this.Controls.Add(this.Star3);
            this.Controls.Add(this.Star5);
            this.Controls.Add(this.Star6);
            this.Controls.Add(this.Star7);
            this.Controls.Add(this.Star9);
            this.Controls.Add(this.Star8);
            this.Controls.Add(this.PipeUpOne);
            this.Controls.Add(this.PipeUpTwo);
            this.Name = "Form1";
            this.Text = "Martian Attack";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PipeUpTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDownOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDownTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeUpOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPlayer;
        private System.Windows.Forms.PictureBox Star1;
        private System.Windows.Forms.PictureBox Star2;
        private System.Windows.Forms.PictureBox Star3;
        private System.Windows.Forms.PictureBox Star4;
        private System.Windows.Forms.PictureBox Star5;
        private System.Windows.Forms.PictureBox Star6;
        private System.Windows.Forms.PictureBox Star7;
        private System.Windows.Forms.PictureBox Star8;
        private System.Windows.Forms.PictureBox Star9;
        private System.Windows.Forms.PictureBox Star10;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PipeUpOne;
        private System.Windows.Forms.PictureBox PipeDownTwo;
        private System.Windows.Forms.PictureBox PipeDownOne;
        private System.Windows.Forms.PictureBox PipeUpTwo;
    }
}

