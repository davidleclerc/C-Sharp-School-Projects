namespace Final
{
    partial class QandA
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.answerTxtBox = new System.Windows.Forms.TextBox();
            this.playerCheck1 = new System.Windows.Forms.CheckBox();
            this.playerCheck2 = new System.Windows.Forms.CheckBox();
            this.playerCheck3 = new System.Windows.Forms.CheckBox();
            this.playerAnswer = new System.Windows.Forms.Label();
            this.correctButton = new System.Windows.Forms.Button();
            this.incorrectButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clockLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(27, 53);
            this.questionLabel.MaximumSize = new System.Drawing.Size(450, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(70, 25);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "label1";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.ForeColor = System.Drawing.Color.White;
            this.answerLabel.Location = new System.Drawing.Point(27, 230);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(189, 25);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.Text = "Correct response: ";
            this.answerLabel.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(80, 390);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Visible = false;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // answerTxtBox
            // 
            this.answerTxtBox.Location = new System.Drawing.Point(80, 354);
            this.answerTxtBox.Name = "answerTxtBox";
            this.answerTxtBox.Size = new System.Drawing.Size(197, 20);
            this.answerTxtBox.TabIndex = 3;
            // 
            // playerCheck1
            // 
            this.playerCheck1.AutoSize = true;
            this.playerCheck1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCheck1.ForeColor = System.Drawing.Color.White;
            this.playerCheck1.Location = new System.Drawing.Point(80, 324);
            this.playerCheck1.Name = "playerCheck1";
            this.playerCheck1.Size = new System.Drawing.Size(106, 24);
            this.playerCheck1.TabIndex = 4;
            this.playerCheck1.Text = "checkBox1";
            this.playerCheck1.UseVisualStyleBackColor = true;
            this.playerCheck1.CheckedChanged += new System.EventHandler(this.playerCheck1_CheckedChanged);
            // 
            // playerCheck2
            // 
            this.playerCheck2.AutoSize = true;
            this.playerCheck2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCheck2.ForeColor = System.Drawing.Color.White;
            this.playerCheck2.Location = new System.Drawing.Point(204, 324);
            this.playerCheck2.Name = "playerCheck2";
            this.playerCheck2.Size = new System.Drawing.Size(106, 24);
            this.playerCheck2.TabIndex = 5;
            this.playerCheck2.Text = "checkBox2";
            this.playerCheck2.UseVisualStyleBackColor = true;
            this.playerCheck2.Visible = false;
            this.playerCheck2.CheckedChanged += new System.EventHandler(this.playerCheck2_CheckedChanged);
            // 
            // playerCheck3
            // 
            this.playerCheck3.AutoSize = true;
            this.playerCheck3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCheck3.ForeColor = System.Drawing.Color.White;
            this.playerCheck3.Location = new System.Drawing.Point(339, 324);
            this.playerCheck3.Name = "playerCheck3";
            this.playerCheck3.Size = new System.Drawing.Size(106, 24);
            this.playerCheck3.TabIndex = 6;
            this.playerCheck3.Text = "checkBox3";
            this.playerCheck3.UseVisualStyleBackColor = true;
            this.playerCheck3.Visible = false;
            this.playerCheck3.CheckedChanged += new System.EventHandler(this.playerCheck3_CheckedChanged);
            // 
            // playerAnswer
            // 
            this.playerAnswer.AutoSize = true;
            this.playerAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerAnswer.ForeColor = System.Drawing.Color.White;
            this.playerAnswer.Location = new System.Drawing.Point(27, 188);
            this.playerAnswer.Name = "playerAnswer";
            this.playerAnswer.Size = new System.Drawing.Size(165, 25);
            this.playerAnswer.TabIndex = 7;
            this.playerAnswer.Text = "Your response: ";
            this.playerAnswer.Visible = false;
            // 
            // correctButton
            // 
            this.correctButton.Location = new System.Drawing.Point(204, 276);
            this.correctButton.Name = "correctButton";
            this.correctButton.Size = new System.Drawing.Size(94, 34);
            this.correctButton.TabIndex = 8;
            this.correctButton.Text = "Correct!";
            this.correctButton.UseVisualStyleBackColor = true;
            this.correctButton.Visible = false;
            this.correctButton.Click += new System.EventHandler(this.correctButton_Click);
            // 
            // incorrectButton
            // 
            this.incorrectButton.Location = new System.Drawing.Point(319, 276);
            this.incorrectButton.Name = "incorrectButton";
            this.incorrectButton.Size = new System.Drawing.Size(90, 34);
            this.incorrectButton.TabIndex = 9;
            this.incorrectButton.Text = "Incorrect!";
            this.incorrectButton.UseVisualStyleBackColor = true;
            this.incorrectButton.Visible = false;
            this.incorrectButton.Click += new System.EventHandler(this.incorrectButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clockLabel1
            // 
            this.clockLabel1.AutoSize = true;
            this.clockLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel1.ForeColor = System.Drawing.Color.White;
            this.clockLabel1.Location = new System.Drawing.Point(581, 342);
            this.clockLabel1.Name = "clockLabel1";
            this.clockLabel1.Size = new System.Drawing.Size(0, 37);
            this.clockLabel1.TabIndex = 10;
            // 
            // QandA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clockLabel1);
            this.Controls.Add(this.incorrectButton);
            this.Controls.Add(this.correctButton);
            this.Controls.Add(this.playerAnswer);
            this.Controls.Add(this.playerCheck3);
            this.Controls.Add(this.playerCheck2);
            this.Controls.Add(this.playerCheck1);
            this.Controls.Add(this.answerTxtBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.questionLabel);
            this.Name = "QandA";
            this.Text = "QandA";
            this.Load += new System.EventHandler(this.QandA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox answerTxtBox;
        private System.Windows.Forms.CheckBox playerCheck1;
        private System.Windows.Forms.CheckBox playerCheck2;
        private System.Windows.Forms.CheckBox playerCheck3;
        private System.Windows.Forms.Label playerAnswer;
        private System.Windows.Forms.Button correctButton;
        private System.Windows.Forms.Button incorrectButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label clockLabel1;
    }
}