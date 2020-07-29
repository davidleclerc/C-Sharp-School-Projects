namespace MainForm
{
    partial class Label
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Label));
            this.labelPanel = new System.Windows.Forms.Panel();
            this.weightLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shipToLabel = new System.Windows.Forms.Label();
            this.senderLabel = new System.Windows.Forms.Label();
            this.shipTypeLabel = new System.Windows.Forms.Label();
            this.carrierLabel = new System.Windows.Forms.Label();
            this.printLabelBtn = new System.Windows.Forms.Button();
            this.closeLabelBtn = new System.Windows.Forms.Button();
            this.printDocumentLabel = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogLabel = new System.Windows.Forms.PrintPreviewDialog();
            this.labelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPanel
            // 
            this.labelPanel.BackColor = System.Drawing.Color.White;
            this.labelPanel.Controls.Add(this.weightLabel);
            this.labelPanel.Controls.Add(this.dateLabel);
            this.labelPanel.Controls.Add(this.label4);
            this.labelPanel.Controls.Add(this.label3);
            this.labelPanel.Controls.Add(this.label2);
            this.labelPanel.Controls.Add(this.label1);
            this.labelPanel.Controls.Add(this.shipToLabel);
            this.labelPanel.Controls.Add(this.senderLabel);
            this.labelPanel.Controls.Add(this.shipTypeLabel);
            this.labelPanel.Controls.Add(this.carrierLabel);
            this.labelPanel.Location = new System.Drawing.Point(24, 20);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(583, 307);
            this.labelPanel.TabIndex = 0;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(275, 100);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(35, 13);
            this.weightLabel.TabIndex = 10;
            this.weightLabel.Text = "label6";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(275, 87);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(35, 13);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 55);
            this.label4.TabIndex = 8;
            this.label4.Text = " \t˺ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 55);
            this.label3.TabIndex = 7;
            this.label3.Text = "˹ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 55);
            this.label2.TabIndex = 6;
            this.label2.Text = " \t˻ ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = " \t˼ ";
            // 
            // shipToLabel
            // 
            this.shipToLabel.AutoSize = true;
            this.shipToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipToLabel.Location = new System.Drawing.Point(240, 178);
            this.shipToLabel.Name = "shipToLabel";
            this.shipToLabel.Size = new System.Drawing.Size(70, 25);
            this.shipToLabel.TabIndex = 4;
            this.shipToLabel.Text = "label1";
            this.shipToLabel.Click += new System.EventHandler(this.shipToLabel_Click);
            // 
            // senderLabel
            // 
            this.senderLabel.AutoSize = true;
            this.senderLabel.Location = new System.Drawing.Point(116, 134);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.Size = new System.Drawing.Size(35, 13);
            this.senderLabel.TabIndex = 2;
            this.senderLabel.Text = "label1";
            // 
            // shipTypeLabel
            // 
            this.shipTypeLabel.AutoSize = true;
            this.shipTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipTypeLabel.Location = new System.Drawing.Point(272, 56);
            this.shipTypeLabel.Name = "shipTypeLabel";
            this.shipTypeLabel.Size = new System.Drawing.Size(86, 31);
            this.shipTypeLabel.TabIndex = 1;
            this.shipTypeLabel.Text = "label2";
            // 
            // carrierLabel
            // 
            this.carrierLabel.AutoSize = true;
            this.carrierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrierLabel.Location = new System.Drawing.Point(113, 56);
            this.carrierLabel.Name = "carrierLabel";
            this.carrierLabel.Size = new System.Drawing.Size(86, 31);
            this.carrierLabel.TabIndex = 0;
            this.carrierLabel.Text = "label1";
            // 
            // printLabelBtn
            // 
            this.printLabelBtn.Location = new System.Drawing.Point(62, 346);
            this.printLabelBtn.Name = "printLabelBtn";
            this.printLabelBtn.Size = new System.Drawing.Size(113, 36);
            this.printLabelBtn.TabIndex = 1;
            this.printLabelBtn.Text = "Print Label";
            this.printLabelBtn.UseVisualStyleBackColor = true;
            this.printLabelBtn.Click += new System.EventHandler(this.printLabelBtn_Click);
            // 
            // closeLabelBtn
            // 
            this.closeLabelBtn.Location = new System.Drawing.Point(264, 346);
            this.closeLabelBtn.Name = "closeLabelBtn";
            this.closeLabelBtn.Size = new System.Drawing.Size(109, 36);
            this.closeLabelBtn.TabIndex = 2;
            this.closeLabelBtn.Text = "Close Label";
            this.closeLabelBtn.UseVisualStyleBackColor = true;
            this.closeLabelBtn.Click += new System.EventHandler(this.closeLabelBtn_Click);
            // 
            // printDocumentLabel
            // 
            this.printDocumentLabel.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialogLabel
            // 
            this.printPreviewDialogLabel.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogLabel.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogLabel.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogLabel.Document = this.printDocumentLabel;
            this.printPreviewDialogLabel.Enabled = true;
            this.printPreviewDialogLabel.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogLabel.Icon")));
            this.printPreviewDialogLabel.Name = "printPreviewDialog1";
            this.printPreviewDialogLabel.Visible = false;
            // 
            // Label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeLabelBtn);
            this.Controls.Add(this.printLabelBtn);
            this.Controls.Add(this.labelPanel);
            this.Name = "Label";
            this.Text = "Label";
            this.Load += new System.EventHandler(this.Label_Load);
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.Label shipToLabel;
        private System.Windows.Forms.Label senderLabel;
        private System.Windows.Forms.Label shipTypeLabel;
        private System.Windows.Forms.Label carrierLabel;
        private System.Windows.Forms.Button printLabelBtn;
        private System.Windows.Forms.Button closeLabelBtn;
        private System.Drawing.Printing.PrintDocument printDocumentLabel;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}