namespace Final
{
    partial class OptionsForm
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
            this.player1Txt = new System.Windows.Forms.TextBox();
            this.player2Txt = new System.Windows.Forms.TextBox();
            this.player3Txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numPlayers = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.player3Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of players:";
            // 
            // player1Txt
            // 
            this.player1Txt.Location = new System.Drawing.Point(120, 75);
            this.player1Txt.Name = "player1Txt";
            this.player1Txt.Size = new System.Drawing.Size(100, 20);
            this.player1Txt.TabIndex = 1;
            // 
            // player2Txt
            // 
            this.player2Txt.Location = new System.Drawing.Point(120, 117);
            this.player2Txt.Name = "player2Txt";
            this.player2Txt.Size = new System.Drawing.Size(100, 20);
            this.player2Txt.TabIndex = 2;
            this.player2Txt.Visible = false;
            // 
            // player3Txt
            // 
            this.player3Txt.Location = new System.Drawing.Point(120, 159);
            this.player3Txt.Name = "player3Txt";
            this.player3Txt.Size = new System.Drawing.Size(100, 20);
            this.player3Txt.TabIndex = 3;
            this.player3Txt.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Play Jeopardy!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numPlayers
            // 
            this.numPlayers.Location = new System.Drawing.Point(120, 39);
            this.numPlayers.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPlayers.Name = "numPlayers";
            this.numPlayers.Size = new System.Drawing.Size(43, 20);
            this.numPlayers.TabIndex = 5;
            this.numPlayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPlayers.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.player3Label);
            this.groupBox1.Controls.Add(this.player2Label);
            this.groupBox1.Controls.Add(this.player1Label);
            this.groupBox1.Controls.Add(this.numPlayers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.player3Txt);
            this.groupBox1.Controls.Add(this.player2Txt);
            this.groupBox1.Controls.Add(this.player1Txt);
            this.groupBox1.Location = new System.Drawing.Point(34, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 308);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // player3Label
            // 
            this.player3Label.AutoSize = true;
            this.player3Label.Location = new System.Drawing.Point(6, 159);
            this.player3Label.Name = "player3Label";
            this.player3Label.Size = new System.Drawing.Size(79, 13);
            this.player3Label.TabIndex = 8;
            this.player3Label.Text = "Player 3 Name:";
            this.player3Label.Visible = false;
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(6, 117);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(82, 13);
            this.player2Label.TabIndex = 7;
            this.player2Label.Text = "Player 2 Name: ";
            this.player2Label.Visible = false;
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(6, 75);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(79, 13);
            this.player1Label.TabIndex = 6;
            this.player1Label.Text = "Player 1 Name:";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPlayers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox player1Txt;
        private System.Windows.Forms.TextBox player2Txt;
        private System.Windows.Forms.TextBox player3Txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numPlayers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label player3Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Button button2;
    }
}