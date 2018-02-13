namespace Blackjack
{
    partial class frmBlackJack21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBlackJack21));
            this.lblModoJuego = new System.Windows.Forms.Label();
            this.btnMultiplayer = new System.Windows.Forms.Button();
            this.btnCpu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModoJuego
            // 
            this.lblModoJuego.AutoSize = true;
            this.lblModoJuego.BackColor = System.Drawing.Color.Gold;
            this.lblModoJuego.Location = new System.Drawing.Point(200, 163);
            this.lblModoJuego.Name = "lblModoJuego";
            this.lblModoJuego.Size = new System.Drawing.Size(144, 13);
            this.lblModoJuego.TabIndex = 1;
            this.lblModoJuego.Text = "Seleccione el modo de juego";
            // 
            // btnMultiplayer
            // 
            this.btnMultiplayer.Location = new System.Drawing.Point(118, 210);
            this.btnMultiplayer.Name = "btnMultiplayer";
            this.btnMultiplayer.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplayer.TabIndex = 2;
            this.btnMultiplayer.Text = "Multiplayer";
            this.btnMultiplayer.UseVisualStyleBackColor = true;
            this.btnMultiplayer.Click += new System.EventHandler(this.btnMultiplayer_Click);
            // 
            // btnCpu
            // 
            this.btnCpu.Location = new System.Drawing.Point(343, 210);
            this.btnCpu.Name = "btnCpu";
            this.btnCpu.Size = new System.Drawing.Size(75, 23);
            this.btnCpu.TabIndex = 3;
            this.btnCpu.Text = "CPU";
            this.btnCpu.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmBlackJack21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(559, 307);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCpu);
            this.Controls.Add(this.btnMultiplayer);
            this.Controls.Add(this.lblModoJuego);
            this.Name = "frmBlackJack21";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack 21";
            this.Load += new System.EventHandler(this.frmBlackJack21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModoJuego;
        private System.Windows.Forms.Button btnMultiplayer;
        private System.Windows.Forms.Button btnCpu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}