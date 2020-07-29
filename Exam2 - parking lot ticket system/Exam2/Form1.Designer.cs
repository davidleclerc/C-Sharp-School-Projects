namespace Exam2
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.displayTxtBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.textTicketStatus = new System.Windows.Forms.TextBox();
            this.textTicketDate = new System.Windows.Forms.TextBox();
            this.textTicketNum = new System.Windows.Forms.TextBox();
            this.listTickets = new System.Windows.Forms.ListBox();
            this.btnPayTicket = new System.Windows.Forms.Button();
            this.btnPrintTicket = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // displayTxtBox
            // 
            this.displayTxtBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.displayTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTxtBox.Location = new System.Drawing.Point(15, 26);
            this.displayTxtBox.Name = "displayTxtBox";
            this.displayTxtBox.ReadOnly = true;
            this.displayTxtBox.Size = new System.Drawing.Size(347, 186);
            this.displayTxtBox.TabIndex = 7;
            this.displayTxtBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelNum);
            this.groupBox1.Controls.Add(this.textTicketStatus);
            this.groupBox1.Controls.Add(this.textTicketDate);
            this.groupBox1.Controls.Add(this.textTicketNum);
            this.groupBox1.Controls.Add(this.listTickets);
            this.groupBox1.Controls.Add(this.btnPayTicket);
            this.groupBox1.Location = new System.Drawing.Point(426, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 294);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 53);
            this.button1.TabIndex = 17;
            this.button1.Text = "Save Ticket List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Date Issued";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(305, 39);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(77, 13);
            this.labelNum.TabIndex = 14;
            this.labelNum.Text = "Ticket Number";
            // 
            // textTicketStatus
            // 
            this.textTicketStatus.Location = new System.Drawing.Point(308, 156);
            this.textTicketStatus.Name = "textTicketStatus";
            this.textTicketStatus.Size = new System.Drawing.Size(121, 20);
            this.textTicketStatus.TabIndex = 13;
            // 
            // textTicketDate
            // 
            this.textTicketDate.Location = new System.Drawing.Point(308, 105);
            this.textTicketDate.Name = "textTicketDate";
            this.textTicketDate.Size = new System.Drawing.Size(189, 20);
            this.textTicketDate.TabIndex = 12;
            // 
            // textTicketNum
            // 
            this.textTicketNum.Location = new System.Drawing.Point(308, 55);
            this.textTicketNum.Name = "textTicketNum";
            this.textTicketNum.Size = new System.Drawing.Size(100, 20);
            this.textTicketNum.TabIndex = 11;
            // 
            // listTickets
            // 
            this.listTickets.FormattingEnabled = true;
            this.listTickets.Location = new System.Drawing.Point(35, 19);
            this.listTickets.Name = "listTickets";
            this.listTickets.Size = new System.Drawing.Size(264, 186);
            this.listTickets.TabIndex = 10;
            this.listTickets.SelectedIndexChanged += new System.EventHandler(this.listTickets_SelectedIndexChanged);
            // 
            // btnPayTicket
            // 
            this.btnPayTicket.Location = new System.Drawing.Point(35, 211);
            this.btnPayTicket.Name = "btnPayTicket";
            this.btnPayTicket.Size = new System.Drawing.Size(133, 53);
            this.btnPayTicket.TabIndex = 1;
            this.btnPayTicket.Text = "Pay Ticket";
            this.btnPayTicket.UseVisualStyleBackColor = true;
            this.btnPayTicket.Click += new System.EventHandler(this.btnPayTicket_Click_1);
            // 
            // btnPrintTicket
            // 
            this.btnPrintTicket.Location = new System.Drawing.Point(120, 218);
            this.btnPrintTicket.Name = "btnPrintTicket";
            this.btnPrintTicket.Size = new System.Drawing.Size(140, 49);
            this.btnPrintTicket.TabIndex = 5;
            this.btnPrintTicket.Text = "Print Ticket";
            this.btnPrintTicket.UseVisualStyleBackColor = true;
            this.btnPrintTicket.Click += new System.EventHandler(this.btnPrintTicket_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.displayTxtBox);
            this.groupBox2.Controls.Add(this.btnPrintTicket);
            this.groupBox2.Location = new System.Drawing.Point(12, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 293);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 384);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox displayTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox textTicketStatus;
        private System.Windows.Forms.TextBox textTicketDate;
        private System.Windows.Forms.TextBox textTicketNum;
        private System.Windows.Forms.ListBox listTickets;
        private System.Windows.Forms.Button btnPayTicket;
        private System.Windows.Forms.Button btnPrintTicket;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

