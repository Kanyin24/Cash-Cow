
namespace CashCow
{
    partial class frmMainGame
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
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblCowCash = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblContinue = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.picWand5 = new System.Windows.Forms.PictureBox();
            this.picWand4 = new System.Windows.Forms.PictureBox();
            this.picWand3 = new System.Windows.Forms.PictureBox();
            this.picWand2 = new System.Windows.Forms.PictureBox();
            this.picWand1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWand5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWand4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWand3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWand1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrGame
            // 
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(177, 313);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(731, 49);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "PRESS ENTER TO START GAME";
            // 
            // lblCowCash
            // 
            this.lblCowCash.AutoSize = true;
            this.lblCowCash.Font = new System.Drawing.Font("Cooper Black", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCowCash.Location = new System.Drawing.Point(374, 21);
            this.lblCowCash.Name = "lblCowCash";
            this.lblCowCash.Size = new System.Drawing.Size(373, 78);
            this.lblCowCash.TabIndex = 6;
            this.lblCowCash.Text = "Cash Cow";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(80, 175);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(170, 50);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score: ";
            this.lblScore.Visible = false;
            // 
            // lblContinue
            // 
            this.lblContinue.AutoSize = true;
            this.lblContinue.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinue.Location = new System.Drawing.Point(309, 662);
            this.lblContinue.Name = "lblContinue";
            this.lblContinue.Size = new System.Drawing.Size(465, 29);
            this.lblContinue.TabIndex = 9;
            this.lblContinue.Text = "GREAT JOB! CLICK TO CONTINUE!";
            this.lblContinue.Visible = false;
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(83, 263);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(197, 35);
            this.lblHighScore.TabIndex = 12;
            this.lblHighScore.Text = "High Score: ";
            this.lblHighScore.Visible = false;
            // 
            // picWand5
            // 
            this.picWand5.ErrorImage = null;
            this.picWand5.Image = global::CashCow.Resource1.MagicWand;
            this.picWand5.Location = new System.Drawing.Point(246, 429);
            this.picWand5.Name = "picWand5";
            this.picWand5.Size = new System.Drawing.Size(75, 117);
            this.picWand5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWand5.TabIndex = 5;
            this.picWand5.TabStop = false;
            this.picWand5.Visible = false;
            this.picWand5.Click += new System.EventHandler(this.picWand5_Click);
            // 
            // picWand4
            // 
            this.picWand4.ErrorImage = null;
            this.picWand4.Image = global::CashCow.Resource1.MagicWand;
            this.picWand4.Location = new System.Drawing.Point(174, 429);
            this.picWand4.Name = "picWand4";
            this.picWand4.Size = new System.Drawing.Size(76, 117);
            this.picWand4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWand4.TabIndex = 4;
            this.picWand4.TabStop = false;
            this.picWand4.Visible = false;
            this.picWand4.Click += new System.EventHandler(this.picWand4_Click);
            // 
            // picWand3
            // 
            this.picWand3.ErrorImage = null;
            this.picWand3.Image = global::CashCow.Resource1.MagicWand;
            this.picWand3.Location = new System.Drawing.Point(272, 322);
            this.picWand3.Name = "picWand3";
            this.picWand3.Size = new System.Drawing.Size(69, 112);
            this.picWand3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWand3.TabIndex = 3;
            this.picWand3.TabStop = false;
            this.picWand3.Visible = false;
            this.picWand3.Click += new System.EventHandler(this.picWand3_Click);
            // 
            // picWand2
            // 
            this.picWand2.ErrorImage = null;
            this.picWand2.Image = global::CashCow.Resource1.MagicWand;
            this.picWand2.Location = new System.Drawing.Point(202, 322);
            this.picWand2.Name = "picWand2";
            this.picWand2.Size = new System.Drawing.Size(73, 112);
            this.picWand2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWand2.TabIndex = 2;
            this.picWand2.TabStop = false;
            this.picWand2.Visible = false;
            this.picWand2.Click += new System.EventHandler(this.picWand2_Click);
            // 
            // picWand1
            // 
            this.picWand1.ErrorImage = null;
            this.picWand1.Image = global::CashCow.Resource1.MagicWand;
            this.picWand1.Location = new System.Drawing.Point(132, 322);
            this.picWand1.Name = "picWand1";
            this.picWand1.Size = new System.Drawing.Size(73, 112);
            this.picWand1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWand1.TabIndex = 1;
            this.picWand1.TabStop = false;
            this.picWand1.Visible = false;
            this.picWand1.Click += new System.EventHandler(this.PicWand1_Click);
            // 
            // frmMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1114, 710);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblContinue);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblCowCash);
            this.Controls.Add(this.picWand5);
            this.Controls.Add(this.picWand4);
            this.Controls.Add(this.picWand3);
            this.Controls.Add(this.picWand2);
            this.Controls.Add(this.picWand1);
            this.Controls.Add(this.lblEnter);
            this.Name = "frmMainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainGame";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMainGame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMainGame_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmMainGame_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.picWand5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWand4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWand3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWand1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.PictureBox picWand1;
        private System.Windows.Forms.PictureBox picWand2;
        private System.Windows.Forms.PictureBox picWand3;
        private System.Windows.Forms.PictureBox picWand4;
        private System.Windows.Forms.PictureBox picWand5;
        private System.Windows.Forms.Label lblCowCash;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblContinue;
        private System.Windows.Forms.Label lblHighScore;
    }
}