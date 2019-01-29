namespace SDD_Graphics_Attempt_1
{
    partial class Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RedButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.YellowButton = new System.Windows.Forms.Button();
            this.OrangeButton = new System.Windows.Forms.Button();
            this.PurpleButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "MASTER MIND";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "SCORE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Colors";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RedButton
            // 
            this.RedButton.BackColor = System.Drawing.Color.Red;
            this.RedButton.Font = new System.Drawing.Font("Calibri", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedButton.ForeColor = System.Drawing.Color.Black;
            this.RedButton.Location = new System.Drawing.Point(22, 152);
            this.RedButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(100, 50);
            this.RedButton.TabIndex = 3;
            this.RedButton.Text = "Red";
            this.RedButton.UseVisualStyleBackColor = false;
            this.RedButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.BlueButton.Font = new System.Drawing.Font("Calibri", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueButton.Location = new System.Drawing.Point(22, 208);
            this.BlueButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(100, 50);
            this.BlueButton.TabIndex = 4;
            this.BlueButton.Text = "Blue";
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.SeaGreen;
            this.GreenButton.Font = new System.Drawing.Font("Calibri", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenButton.Location = new System.Drawing.Point(22, 263);
            this.GreenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(100, 50);
            this.GreenButton.TabIndex = 5;
            this.GreenButton.Text = "Green";
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // YellowButton
            // 
            this.YellowButton.BackColor = System.Drawing.Color.Yellow;
            this.YellowButton.Font = new System.Drawing.Font("Calibri", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YellowButton.ForeColor = System.Drawing.Color.Black;
            this.YellowButton.Location = new System.Drawing.Point(128, 152);
            this.YellowButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(100, 50);
            this.YellowButton.TabIndex = 6;
            this.YellowButton.Text = "Yellow";
            this.YellowButton.UseVisualStyleBackColor = false;
            this.YellowButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // OrangeButton
            // 
            this.OrangeButton.BackColor = System.Drawing.Color.Orange;
            this.OrangeButton.Font = new System.Drawing.Font("Calibri", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrangeButton.Location = new System.Drawing.Point(128, 208);
            this.OrangeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrangeButton.Name = "OrangeButton";
            this.OrangeButton.Size = new System.Drawing.Size(100, 50);
            this.OrangeButton.TabIndex = 7;
            this.OrangeButton.Text = "Orange";
            this.OrangeButton.UseVisualStyleBackColor = false;
            this.OrangeButton.Click += new System.EventHandler(this.OrangeButton_Click);
            // 
            // PurpleButton
            // 
            this.PurpleButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.PurpleButton.Font = new System.Drawing.Font("Calibri", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurpleButton.Location = new System.Drawing.Point(128, 263);
            this.PurpleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PurpleButton.Name = "PurpleButton";
            this.PurpleButton.Size = new System.Drawing.Size(100, 50);
            this.PurpleButton.TabIndex = 8;
            this.PurpleButton.Text = "Purple";
            this.PurpleButton.UseVisualStyleBackColor = false;
            this.PurpleButton.Click += new System.EventHandler(this.PurpleButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.Info;
            this.ClearButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.ClearButton.Location = new System.Drawing.Point(22, 319);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(206, 75);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ScoreBox
            // 
            this.ScoreBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ScoreBox.Location = new System.Drawing.Point(128, 75);
            this.ScoreBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.ReadOnly = true;
            this.ScoreBox.Size = new System.Drawing.Size(100, 31);
            this.ScoreBox.TabIndex = 10;
            this.ScoreBox.TabStop = false;
            this.ScoreBox.TextChanged += new System.EventHandler(this.ScoreBox_TextChanged);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.Info;
            this.Confirm.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.Confirm.Location = new System.Drawing.Point(22, 402);
            this.Confirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(206, 75);
            this.Confirm.TabIndex = 11;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.Confirm);
            this.panel1.Controls.Add(this.ScoreBox);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.PurpleButton);
            this.panel1.Controls.Add(this.OrangeButton);
            this.panel1.Controls.Add(this.YellowButton);
            this.panel1.Controls.Add(this.GreenButton);
            this.panel1.Controls.Add(this.BlueButton);
            this.panel1.Controls.Add(this.RedButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 750);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pegs:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(341, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 750);
            this.panel3.TabIndex = 14;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1598, 865);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDD Term 2 Major Project By Shaan Khan";
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button YellowButton;
        private System.Windows.Forms.Button OrangeButton;
        private System.Windows.Forms.Button PurpleButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox ScoreBox;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
    }
}

