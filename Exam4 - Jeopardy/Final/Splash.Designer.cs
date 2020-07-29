namespace Final
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.splashImage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.alex = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splashImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alex)).BeginInit();
            this.SuspendLayout();
            // 
            // splashImage
            // 
            this.splashImage.Image = ((System.Drawing.Image)(resources.GetObject("splashImage.Image")));
            this.splashImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("splashImage.InitialImage")));
            this.splashImage.Location = new System.Drawing.Point(12, 12);
            this.splashImage.Name = "splashImage";
            this.splashImage.Size = new System.Drawing.Size(33, 28);
            this.splashImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.splashImage.TabIndex = 0;
            this.splashImage.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(740, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alex
            // 
            this.alex.Image = ((System.Drawing.Image)(resources.GetObject("alex.Image")));
            this.alex.InitialImage = ((System.Drawing.Image)(resources.GetObject("alex.InitialImage")));
            this.alex.Location = new System.Drawing.Point(745, 332);
            this.alex.MaximumSize = new System.Drawing.Size(340, 337);
            this.alex.Name = "alex";
            this.alex.Size = new System.Drawing.Size(340, 337);
            this.alex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alex.TabIndex = 2;
            this.alex.TabStop = false;
            this.alex.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 656);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(591, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "\'JEOPARDY!\' and \'America\'s Favorite Quiz Show\' are registered trademarks of Jeopa" +
    "rdy Productions, Inc. All rights reserved.";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1199, 670);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splashImage);
            this.Name = "Splash";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splashImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox splashImage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox alex;
        private System.Windows.Forms.Label label2;
    }
}

