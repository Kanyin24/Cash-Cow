
namespace CashCow
{
    partial class frmLost
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
            this.lblLost = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLost
            // 
            this.lblLost.AutoSize = true;
            this.lblLost.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLost.Location = new System.Drawing.Point(113, 132);
            this.lblLost.Name = "lblLost";
            this.lblLost.Size = new System.Drawing.Size(567, 35);
            this.lblLost.TabIndex = 0;
            this.lblLost.Text = "You Used Up All Your Magic Wands.";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.White;
            this.btnPlayAgain.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(244, 284);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(316, 43);
            this.btnPlayAgain.TabIndex = 12;
            this.btnPlayAgain.Text = "Yes, Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnMainPage
            // 
            this.btnMainPage.BackColor = System.Drawing.Color.White;
            this.btnMainPage.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainPage.Location = new System.Drawing.Point(244, 342);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(316, 46);
            this.btnMainPage.TabIndex = 13;
            this.btnMainPage.Text = "No, Go Back To Main Menu";
            this.btnMainPage.UseVisualStyleBackColor = false;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thanks for Playing! Do You Want to Play Again?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 55);
            this.label2.TabIndex = 15;
            this.label2.Text = "You Lost :(";
            // 
            // frmLost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(811, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMainPage);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblLost);
            this.Name = "frmLost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLost;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}