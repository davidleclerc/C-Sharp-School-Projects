namespace MainForm
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.senderLabel = new System.Windows.Forms.Label();
            this.packageLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.invoicePanel = new System.Windows.Forms.Panel();
            this.prntInvoiceBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.closeInvoiceBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.invoicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // senderLabel
            // 
            this.senderLabel.AutoSize = true;
            this.senderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senderLabel.Location = new System.Drawing.Point(7, 17);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.Size = new System.Drawing.Size(115, 24);
            this.senderLabel.TabIndex = 0;
            this.senderLabel.Text = "senderLabel";
            // 
            // packageLabel
            // 
            this.packageLabel.AutoSize = true;
            this.packageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageLabel.Location = new System.Drawing.Point(5, 91);
            this.packageLabel.Name = "packageLabel";
            this.packageLabel.Size = new System.Drawing.Size(45, 16);
            this.packageLabel.TabIndex = 1;
            this.packageLabel.Text = "label1";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(22, 645);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(79, 29);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "label1";
            // 
            // invoicePanel
            // 
            this.invoicePanel.Controls.Add(this.label3);
            this.invoicePanel.Controls.Add(this.label2);
            this.invoicePanel.Controls.Add(this.packageLabel);
            this.invoicePanel.Controls.Add(this.senderLabel);
            this.invoicePanel.Controls.Add(this.costLabel);
            this.invoicePanel.Location = new System.Drawing.Point(8, 7);
            this.invoicePanel.Name = "invoicePanel";
            this.invoicePanel.Size = new System.Drawing.Size(830, 690);
            this.invoicePanel.TabIndex = 3;
            // 
            // prntInvoiceBtn
            // 
            this.prntInvoiceBtn.Location = new System.Drawing.Point(100, 713);
            this.prntInvoiceBtn.Name = "prntInvoiceBtn";
            this.prntInvoiceBtn.Size = new System.Drawing.Size(143, 23);
            this.prntInvoiceBtn.TabIndex = 4;
            this.prntInvoiceBtn.Text = "Print Invoice";
            this.prntInvoiceBtn.UseVisualStyleBackColor = true;
            this.prntInvoiceBtn.Click += new System.EventHandler(this.prntInvoiceBtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // closeInvoiceBtn
            // 
            this.closeInvoiceBtn.Location = new System.Drawing.Point(263, 713);
            this.closeInvoiceBtn.Name = "closeInvoiceBtn";
            this.closeInvoiceBtn.Size = new System.Drawing.Size(94, 23);
            this.closeInvoiceBtn.TabIndex = 5;
            this.closeInvoiceBtn.Text = "Close";
            this.closeInvoiceBtn.UseVisualStyleBackColor = true;
            this.closeInvoiceBtn.Click += new System.EventHandler(this.closeInvoiceBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(701, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "______________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(701, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "______________________________________";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 838);
            this.Controls.Add(this.closeInvoiceBtn);
            this.Controls.Add(this.prntInvoiceBtn);
            this.Controls.Add(this.invoicePanel);
            this.Name = "InvoiceForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.invoicePanel.ResumeLayout(false);
            this.invoicePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label senderLabel;
        private System.Windows.Forms.Label packageLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Panel invoicePanel;
        private System.Windows.Forms.Button prntInvoiceBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button closeInvoiceBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}