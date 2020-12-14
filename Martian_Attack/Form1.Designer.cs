
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
            this.MainPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPlayer
            // 
            this.MainPlayer.BackColor = System.Drawing.Color.Transparent;
            this.MainPlayer.Image = global::Martian_Attack.Properties.Resources.PhotoshopShip;
            this.MainPlayer.Location = new System.Drawing.Point(283, 234);
            this.MainPlayer.Name = "MainPlayer";
            this.MainPlayer.Size = new System.Drawing.Size(80, 59);
            this.MainPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPlayer.TabIndex = 0;
            this.MainPlayer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.MainPlayer);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Martian Attack";
            ((System.ComponentModel.ISupportInitialize)(this.MainPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPlayer;
    }
}

