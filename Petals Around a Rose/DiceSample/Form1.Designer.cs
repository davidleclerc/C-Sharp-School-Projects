namespace DiceSample
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
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.submitGuess = new System.Windows.Forms.Button();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.totalRolls = new System.Windows.Forms.Label();
            this.numCorrect = new System.Windows.Forms.Label();
            this.bestRun = new System.Windows.Forms.Label();
            this.gameResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.Location = new System.Drawing.Point(355, 254);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(75, 23);
            this.rollDiceButton.TabIndex = 0;
            this.rollDiceButton.Text = "Roll Dice";
            this.rollDiceButton.UseVisualStyleBackColor = true;
            this.rollDiceButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // submitGuess
            // 
            this.submitGuess.Enabled = false;
            this.submitGuess.Location = new System.Drawing.Point(500, 282);
            this.submitGuess.Name = "submitGuess";
            this.submitGuess.Size = new System.Drawing.Size(75, 23);
            this.submitGuess.TabIndex = 7;
            this.submitGuess.Text = "Submit Guess";
            this.submitGuess.UseVisualStyleBackColor = true;
            this.submitGuess.Click += new System.EventHandler(this.submitGuess_Click_1);
            // 
            // guessBox
            // 
            this.guessBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guessBox.Location = new System.Drawing.Point(500, 256);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(100, 20);
            this.guessBox.TabIndex = 8;
            // 
            // totalRolls
            // 
            this.totalRolls.AutoSize = true;
            this.totalRolls.Location = new System.Drawing.Point(640, 214);
            this.totalRolls.Name = "totalRolls";
            this.totalRolls.Size = new System.Drawing.Size(60, 13);
            this.totalRolls.TabIndex = 9;
            this.totalRolls.Text = "Total Rolls:";
            // 
            // numCorrect
            // 
            this.numCorrect.AutoSize = true;
            this.numCorrect.Location = new System.Drawing.Point(640, 239);
            this.numCorrect.Name = "numCorrect";
            this.numCorrect.Size = new System.Drawing.Size(91, 13);
            this.numCorrect.TabIndex = 10;
            this.numCorrect.Text = "Correct Guesses: ";
            // 
            // bestRun
            // 
            this.bestRun.AutoSize = true;
            this.bestRun.Location = new System.Drawing.Point(640, 263);
            this.bestRun.Name = "bestRun";
            this.bestRun.Size = new System.Drawing.Size(57, 13);
            this.bestRun.TabIndex = 11;
            this.bestRun.Text = "Best Run: ";
            // 
            // gameResult
            // 
            this.gameResult.AutoSize = true;
            this.gameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameResult.ForeColor = System.Drawing.Color.OrangeRed;
            this.gameResult.Location = new System.Drawing.Point(58, 392);
            this.gameResult.Name = "gameResult";
            this.gameResult.Size = new System.Drawing.Size(0, 55);
            this.gameResult.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameResult);
            this.Controls.Add(this.bestRun);
            this.Controls.Add(this.numCorrect);
            this.Controls.Add(this.totalRolls);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.submitGuess);
            this.Controls.Add(this.rollDiceButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollDiceButton;
        private System.Windows.Forms.Button submitGuess;
        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Label totalRolls;
        private System.Windows.Forms.Label numCorrect;
        private System.Windows.Forms.Label bestRun;
        private System.Windows.Forms.Label gameResult;
    }
}

