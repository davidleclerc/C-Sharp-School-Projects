namespace Final
{
    partial class GameForm
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
            this.player1Name = new System.Windows.Forms.Label();
            this.player2Name = new System.Windows.Forms.Label();
            this.player3Name = new System.Windows.Forms.Label();
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.player3ScoreLabel = new System.Windows.Forms.Label();
            this.category1Label = new System.Windows.Forms.Label();
            this.category2Label = new System.Windows.Forms.Label();
            this.category3Label = new System.Windows.Forms.Label();
            this.category4Label = new System.Windows.Forms.Label();
            this.category5Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clockLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1Name
            // 
            this.player1Name.AutoSize = true;
            this.player1Name.BackColor = System.Drawing.Color.Transparent;
            this.player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Name.ForeColor = System.Drawing.Color.White;
            this.player1Name.Location = new System.Drawing.Point(154, 577);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(0, 25);
            this.player1Name.TabIndex = 0;
            this.player1Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // player2Name
            // 
            this.player2Name.AutoSize = true;
            this.player2Name.BackColor = System.Drawing.Color.Transparent;
            this.player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Name.ForeColor = System.Drawing.Color.White;
            this.player2Name.Location = new System.Drawing.Point(441, 577);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(0, 25);
            this.player2Name.TabIndex = 1;
            this.player2Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.player2Name.Visible = false;
            // 
            // player3Name
            // 
            this.player3Name.AutoSize = true;
            this.player3Name.BackColor = System.Drawing.Color.Transparent;
            this.player3Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3Name.ForeColor = System.Drawing.Color.White;
            this.player3Name.Location = new System.Drawing.Point(705, 577);
            this.player3Name.Name = "player3Name";
            this.player3Name.Size = new System.Drawing.Size(0, 25);
            this.player3Name.TabIndex = 2;
            this.player3Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.player3Name.Visible = false;
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.AutoSize = true;
            this.player1ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.player1ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.player1ScoreLabel.Location = new System.Drawing.Point(163, 624);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(0, 31);
            this.player1ScoreLabel.TabIndex = 3;
            this.player1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.AutoSize = true;
            this.player2ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.player2ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.player2ScoreLabel.Location = new System.Drawing.Point(450, 624);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.player2ScoreLabel.Size = new System.Drawing.Size(0, 31);
            this.player2ScoreLabel.TabIndex = 4;
            this.player2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.player2ScoreLabel.Visible = false;
            // 
            // player3ScoreLabel
            // 
            this.player3ScoreLabel.AutoSize = true;
            this.player3ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.player3ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.player3ScoreLabel.Location = new System.Drawing.Point(715, 624);
            this.player3ScoreLabel.Name = "player3ScoreLabel";
            this.player3ScoreLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.player3ScoreLabel.Size = new System.Drawing.Size(0, 31);
            this.player3ScoreLabel.TabIndex = 5;
            this.player3ScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.player3ScoreLabel.Visible = false;
            // 
            // category1Label
            // 
            this.category1Label.AutoSize = true;
            this.category1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category1Label.ForeColor = System.Drawing.Color.White;
            this.category1Label.Location = new System.Drawing.Point(46, 44);
            this.category1Label.Name = "category1Label";
            this.category1Label.Size = new System.Drawing.Size(86, 20);
            this.category1Label.TabIndex = 6;
            this.category1Label.Text = "Category 1";
            // 
            // category2Label
            // 
            this.category2Label.AutoSize = true;
            this.category2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category2Label.ForeColor = System.Drawing.Color.White;
            this.category2Label.Location = new System.Drawing.Point(234, 44);
            this.category2Label.Name = "category2Label";
            this.category2Label.Size = new System.Drawing.Size(86, 20);
            this.category2Label.TabIndex = 7;
            this.category2Label.Text = "Category 2";
            // 
            // category3Label
            // 
            this.category3Label.AutoSize = true;
            this.category3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category3Label.ForeColor = System.Drawing.Color.White;
            this.category3Label.Location = new System.Drawing.Point(430, 44);
            this.category3Label.Name = "category3Label";
            this.category3Label.Size = new System.Drawing.Size(86, 20);
            this.category3Label.TabIndex = 8;
            this.category3Label.Text = "Category 3";
            // 
            // category4Label
            // 
            this.category4Label.AutoSize = true;
            this.category4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category4Label.ForeColor = System.Drawing.Color.White;
            this.category4Label.Location = new System.Drawing.Point(599, 44);
            this.category4Label.Name = "category4Label";
            this.category4Label.Size = new System.Drawing.Size(86, 20);
            this.category4Label.TabIndex = 9;
            this.category4Label.Text = "Category 4";
            // 
            // category5Label
            // 
            this.category5Label.AutoSize = true;
            this.category5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category5Label.ForeColor = System.Drawing.Color.White;
            this.category5Label.Location = new System.Drawing.Point(791, 44);
            this.category5Label.Name = "category5Label";
            this.category5Label.Size = new System.Drawing.Size(86, 20);
            this.category5Label.TabIndex = 10;
            this.category5Label.Text = "Category 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(41, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(919, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "_________________________________________________________________________________" +
    "_______________________________________________________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(41, 559);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(919, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "_________________________________________________________________________________" +
    "_______________________________________________________________________";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(41, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(9, 468);
            this.label13.TabIndex = 53;
            this.label13.Text = "\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|" +
    "\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(219, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(9, 468);
            this.label7.TabIndex = 78;
            this.label7.Text = "\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|" +
    "\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(407, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(9, 468);
            this.label8.TabIndex = 79;
            this.label8.Text = "\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|" +
    "\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(585, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(9, 468);
            this.label9.TabIndex = 80;
            this.label9.Text = "\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|" +
    "\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(770, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(9, 468);
            this.label10.TabIndex = 81;
            this.label10.Text = "\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|" +
    "\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(951, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(9, 468);
            this.label12.TabIndex = 82;
            this.label12.Text = "\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|" +
    "\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.ForeColor = System.Drawing.Color.White;
            this.clockLabel.Location = new System.Drawing.Point(39, 592);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(0, 25);
            this.clockLabel.TabIndex = 83;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(812, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 84;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(903, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 85;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1007, 693);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.category5Label);
            this.Controls.Add(this.category4Label);
            this.Controls.Add(this.category3Label);
            this.Controls.Add(this.category2Label);
            this.Controls.Add(this.category1Label);
            this.Controls.Add(this.player3ScoreLabel);
            this.Controls.Add(this.player2ScoreLabel);
            this.Controls.Add(this.player1ScoreLabel);
            this.Controls.Add(this.player3Name);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.player1Name);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.Label player3Name;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label player2ScoreLabel;
        private System.Windows.Forms.Label player3ScoreLabel;
        private System.Windows.Forms.Label category1Label;
        private System.Windows.Forms.Label category2Label;
        private System.Windows.Forms.Label category3Label;
        private System.Windows.Forms.Label category4Label;
        private System.Windows.Forms.Label category5Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}