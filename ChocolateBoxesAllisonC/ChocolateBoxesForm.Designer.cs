﻿namespace ChocolateBoxesAllisonC
{
    partial class frmChocolateBoxes
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblPrize = new System.Windows.Forms.Label();
            this.lblBoxesSold = new System.Windows.Forms.Label();
            this.lblget = new System.Windows.Forms.Label();
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNumberOfBoxes = new System.Windows.Forms.TextBox();
            this.lblHonorable = new System.Windows.Forms.Label();
            this.lblsmall = new System.Windows.Forms.Label();
            this.picPrize = new System.Windows.Forms.PictureBox();
            this.lblTry = new System.Windows.Forms.Label();
            this.mnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(151, 103);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 25);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("Charlemagne Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.Location = new System.Drawing.Point(217, 207);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(59, 19);
            this.lblPrize.TabIndex = 3;
            this.lblPrize.Text = "Prize";
            // 
            // lblBoxesSold
            // 
            this.lblBoxesSold.AutoSize = true;
            this.lblBoxesSold.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxesSold.Location = new System.Drawing.Point(15, 47);
            this.lblBoxesSold.Name = "lblBoxesSold";
            this.lblBoxesSold.Size = new System.Drawing.Size(245, 19);
            this.lblBoxesSold.TabIndex = 4;
            this.lblBoxesSold.Text = "Enter the number of boxes you sold.";
            // 
            // lblget
            // 
            this.lblget.AutoSize = true;
            this.lblget.Font = new System.Drawing.Font("Charlemagne Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblget.Location = new System.Drawing.Point(197, 173);
            this.lblget.Name = "lblget";
            this.lblget.Size = new System.Drawing.Size(103, 19);
            this.lblget.TabIndex = 5;
            this.lblget.Text = "You get a";
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(377, 24);
            this.mnu.TabIndex = 6;
            this.mnu.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(92, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // txtNumberOfBoxes
            // 
            this.txtNumberOfBoxes.Location = new System.Drawing.Point(266, 47);
            this.txtNumberOfBoxes.Name = "txtNumberOfBoxes";
            this.txtNumberOfBoxes.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfBoxes.TabIndex = 8;
            // 
            // lblHonorable
            // 
            this.lblHonorable.AutoSize = true;
            this.lblHonorable.Font = new System.Drawing.Font("Charlemagne Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHonorable.Location = new System.Drawing.Point(147, 207);
            this.lblHonorable.Name = "lblHonorable";
            this.lblHonorable.Size = new System.Drawing.Size(218, 19);
            this.lblHonorable.TabIndex = 9;
            this.lblHonorable.Text = "Honorable Mention";
            // 
            // lblsmall
            // 
            this.lblsmall.AutoSize = true;
            this.lblsmall.Font = new System.Drawing.Font("Charlemagne Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsmall.Location = new System.Drawing.Point(197, 207);
            this.lblsmall.Name = "lblsmall";
            this.lblsmall.Size = new System.Drawing.Size(118, 19);
            this.lblsmall.TabIndex = 10;
            this.lblsmall.Text = "Small Prize";
            // 
            // picPrize
            // 
            this.picPrize.Location = new System.Drawing.Point(19, 148);
            this.picPrize.Name = "picPrize";
            this.picPrize.Size = new System.Drawing.Size(122, 101);
            this.picPrize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrize.TabIndex = 7;
            this.picPrize.TabStop = false;
            // 
            // lblTry
            // 
            this.lblTry.AutoSize = true;
            this.lblTry.Font = new System.Drawing.Font("Charlemagne Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTry.Location = new System.Drawing.Point(152, 207);
            this.lblTry.Name = "lblTry";
            this.lblTry.Size = new System.Drawing.Size(225, 19);
            this.lblTry.TabIndex = 11;
            this.lblTry.Text = "Next time try harder";
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(377, 261);
            this.Controls.Add(this.lblTry);
            this.Controls.Add(this.lblsmall);
            this.Controls.Add(this.lblHonorable);
            this.Controls.Add(this.txtNumberOfBoxes);
            this.Controls.Add(this.picPrize);
            this.Controls.Add(this.lblget);
            this.Controls.Add(this.lblBoxesSold);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.mnu);
            this.MainMenuStrip = this.mnu;
            this.Name = "frmChocolateBoxes";
            this.Text = "Chocolate Boxes by Allison C";
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.Label lblBoxesSold;
        private System.Windows.Forms.Label lblget;
        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.PictureBox picPrize;
        private System.Windows.Forms.TextBox txtNumberOfBoxes;
        private System.Windows.Forms.Label lblHonorable;
        private System.Windows.Forms.Label lblsmall;
        private System.Windows.Forms.Label lblTry;
    }
}

