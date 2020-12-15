
namespace Martian_Attack
{
    partial class MainMenu
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
            this.StartGame = new System.Windows.Forms.Button();
            this.Martian_Attack_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.Transparent;
            this.StartGame.Location = new System.Drawing.Point(36, 254);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(228, 53);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "START GAME";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // Martian_Attack_Label
            // 
            this.Martian_Attack_Label.AutoSize = true;
            this.Martian_Attack_Label.BackColor = System.Drawing.Color.Transparent;
            this.Martian_Attack_Label.Font = new System.Drawing.Font("Yu Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Martian_Attack_Label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Martian_Attack_Label.Location = new System.Drawing.Point(0, -1);
            this.Martian_Attack_Label.Name = "Martian_Attack_Label";
            this.Martian_Attack_Label.Size = new System.Drawing.Size(494, 82);
            this.Martian_Attack_Label.TabIndex = 1;
            this.Martian_Attack_Label.Text = "Martian Attack";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Martian_Attack.Properties.Resources.Main_Menu;
            this.ClientSize = new System.Drawing.Size(629, 361);
            this.Controls.Add(this.Martian_Attack_Label);
            this.Controls.Add(this.StartGame);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Label Martian_Attack_Label;
    }
}