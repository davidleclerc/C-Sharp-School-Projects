namespace MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.createLabelButton = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.txtBxInfo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbBxShipType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBxCarrier = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxRecpZip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxRecpState = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxRecpCity = new System.Windows.Forms.TextBox();
            this.txtBxRecpAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBxRecpName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxSendZip = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.Label();
            this.txtBxSendState = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.Label();
            this.txtBxSendCity = new System.Windows.Forms.TextBox();
            this.txtBxSendAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxSendName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveInv = new System.Windows.Forms.Button();
            this.invoicePanel = new System.Windows.Forms.Panel();
            this.txtBxInfo2 = new System.Windows.Forms.TextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.lstBxInvoices = new System.Windows.Forms.ListBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.invoicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.createLabelButton);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnAddPackage);
            this.tabPage1.Controls.Add(this.txtBxInfo);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Package";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(474, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Current Invoice:";
            // 
            // createLabelButton
            // 
            this.createLabelButton.Location = new System.Drawing.Point(299, 188);
            this.createLabelButton.Name = "createLabelButton";
            this.createLabelButton.Size = new System.Drawing.Size(121, 35);
            this.createLabelButton.TabIndex = 22;
            this.createLabelButton.Text = "Create Label";
            this.createLabelButton.UseVisualStyleBackColor = true;
            this.createLabelButton.Click += new System.EventHandler(this.createLabelButton_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(568, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save Invoice";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(299, 149);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(121, 33);
            this.btnAddPackage.TabIndex = 13;
            this.btnAddPackage.Text = "Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // txtBxInfo
            // 
            this.txtBxInfo.Location = new System.Drawing.Point(477, 66);
            this.txtBxInfo.Multiline = true;
            this.txtBxInfo.Name = "txtBxInfo";
            this.txtBxInfo.ReadOnly = true;
            this.txtBxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBxInfo.Size = new System.Drawing.Size(252, 296);
            this.txtBxInfo.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.nudWeight);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmbBxShipType);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmbBxCarrier);
            this.groupBox3.Location = new System.Drawing.Point(245, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 107);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Package Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Weight";
            // 
            // nudWeight
            // 
            this.nudWeight.DecimalPlaces = 2;
            this.nudWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudWeight.Location = new System.Drawing.Point(74, 77);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(120, 20);
            this.nudWeight.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Ship Type";
            // 
            // cmbBxShipType
            // 
            this.cmbBxShipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxShipType.FormattingEnabled = true;
            this.cmbBxShipType.Items.AddRange(new object[] {
            "Two Day",
            "Overnight"});
            this.cmbBxShipType.Location = new System.Drawing.Point(73, 48);
            this.cmbBxShipType.Name = "cmbBxShipType";
            this.cmbBxShipType.Size = new System.Drawing.Size(121, 21);
            this.cmbBxShipType.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Carrier";
            // 
            // cmbBxCarrier
            // 
            this.cmbBxCarrier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxCarrier.FormattingEnabled = true;
            this.cmbBxCarrier.Items.AddRange(new object[] {
            "UPS",
            "FEDEX",
            "USPS"});
            this.cmbBxCarrier.Location = new System.Drawing.Point(73, 19);
            this.cmbBxCarrier.Name = "cmbBxCarrier";
            this.cmbBxCarrier.Size = new System.Drawing.Size(121, 21);
            this.cmbBxCarrier.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBxRecpZip);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBxRecpState);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBxRecpCity);
            this.groupBox2.Controls.Add(this.txtBxRecpAddress);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBxRecpName);
            this.groupBox2.Location = new System.Drawing.Point(18, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 159);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recipient Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Zip Code";
            // 
            // txtBxRecpZip
            // 
            this.txtBxRecpZip.Location = new System.Drawing.Point(77, 126);
            this.txtBxRecpZip.Name = "txtBxRecpZip";
            this.txtBxRecpZip.Size = new System.Drawing.Size(129, 20);
            this.txtBxRecpZip.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "State";
            // 
            // txtBxRecpState
            // 
            this.txtBxRecpState.Location = new System.Drawing.Point(77, 100);
            this.txtBxRecpState.Name = "txtBxRecpState";
            this.txtBxRecpState.Size = new System.Drawing.Size(129, 20);
            this.txtBxRecpState.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "City";
            // 
            // txtBxRecpCity
            // 
            this.txtBxRecpCity.Location = new System.Drawing.Point(77, 74);
            this.txtBxRecpCity.Name = "txtBxRecpCity";
            this.txtBxRecpCity.Size = new System.Drawing.Size(129, 20);
            this.txtBxRecpCity.TabIndex = 7;
            // 
            // txtBxRecpAddress
            // 
            this.txtBxRecpAddress.Location = new System.Drawing.Point(77, 48);
            this.txtBxRecpAddress.Name = "txtBxRecpAddress";
            this.txtBxRecpAddress.Size = new System.Drawing.Size(129, 20);
            this.txtBxRecpAddress.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name";
            // 
            // txtBxRecpName
            // 
            this.txtBxRecpName.Location = new System.Drawing.Point(77, 19);
            this.txtBxRecpName.Name = "txtBxRecpName";
            this.txtBxRecpName.Size = new System.Drawing.Size(129, 20);
            this.txtBxRecpName.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBxSendZip);
            this.groupBox1.Controls.Add(this.State);
            this.groupBox1.Controls.Add(this.txtBxSendState);
            this.groupBox1.Controls.Add(this.City);
            this.groupBox1.Controls.Add(this.txtBxSendCity);
            this.groupBox1.Controls.Add(this.txtBxSendAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBxSendName);
            this.groupBox1.Location = new System.Drawing.Point(18, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sender Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zip Code";
            // 
            // txtBxSendZip
            // 
            this.txtBxSendZip.Location = new System.Drawing.Point(77, 126);
            this.txtBxSendZip.Name = "txtBxSendZip";
            this.txtBxSendZip.Size = new System.Drawing.Size(129, 20);
            this.txtBxSendZip.TabIndex = 4;
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(5, 103);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(32, 13);
            this.State.TabIndex = 2;
            this.State.Text = "State";
            // 
            // txtBxSendState
            // 
            this.txtBxSendState.Location = new System.Drawing.Point(77, 100);
            this.txtBxSendState.Name = "txtBxSendState";
            this.txtBxSendState.Size = new System.Drawing.Size(129, 20);
            this.txtBxSendState.TabIndex = 3;
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(6, 77);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(24, 13);
            this.City.TabIndex = 2;
            this.City.Text = "City";
            // 
            // txtBxSendCity
            // 
            this.txtBxSendCity.Location = new System.Drawing.Point(77, 74);
            this.txtBxSendCity.Name = "txtBxSendCity";
            this.txtBxSendCity.Size = new System.Drawing.Size(129, 20);
            this.txtBxSendCity.TabIndex = 2;
            // 
            // txtBxSendAddress
            // 
            this.txtBxSendAddress.Location = new System.Drawing.Point(77, 48);
            this.txtBxSendAddress.Name = "txtBxSendAddress";
            this.txtBxSendAddress.Size = new System.Drawing.Size(129, 20);
            this.txtBxSendAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txtBxSendName
            // 
            this.txtBxSendName.Location = new System.Drawing.Point(77, 19);
            this.txtBxSendName.Name = "txtBxSendName";
            this.txtBxSendName.Size = new System.Drawing.Size(129, 20);
            this.txtBxSendName.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(762, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveInv);
            this.tabPage2.Controls.Add(this.invoicePanel);
            this.tabPage2.Controls.Add(this.printButton);
            this.tabPage2.Controls.Add(this.lstBxInvoices);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Invoices";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveInv
            // 
            this.btnSaveInv.Location = new System.Drawing.Point(30, 367);
            this.btnSaveInv.Name = "btnSaveInv";
            this.btnSaveInv.Size = new System.Drawing.Size(169, 23);
            this.btnSaveInv.TabIndex = 4;
            this.btnSaveInv.Text = "Save Invoices To Database";
            this.btnSaveInv.UseVisualStyleBackColor = true;
            this.btnSaveInv.Click += new System.EventHandler(this.btnSaveInv_Click);
            // 
            // invoicePanel
            // 
            this.invoicePanel.Controls.Add(this.txtBxInfo2);
            this.invoicePanel.Location = new System.Drawing.Point(320, 20);
            this.invoicePanel.Name = "invoicePanel";
            this.invoicePanel.Size = new System.Drawing.Size(442, 300);
            this.invoicePanel.TabIndex = 3;
            // 
            // txtBxInfo2
            // 
            this.txtBxInfo2.Location = new System.Drawing.Point(17, 23);
            this.txtBxInfo2.Multiline = true;
            this.txtBxInfo2.Name = "txtBxInfo2";
            this.txtBxInfo2.ReadOnly = true;
            this.txtBxInfo2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBxInfo2.Size = new System.Drawing.Size(404, 258);
            this.txtBxInfo2.TabIndex = 1;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(463, 338);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(148, 23);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Print Selected Invoice";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // lstBxInvoices
            // 
            this.lstBxInvoices.FormattingEnabled = true;
            this.lstBxInvoices.Location = new System.Drawing.Point(6, 6);
            this.lstBxInvoices.Name = "lstBxInvoices";
            this.lstBxInvoices.Size = new System.Drawing.Size(298, 355);
            this.lstBxInvoices.TabIndex = 0;
            this.lstBxInvoices.SelectedIndexChanged += new System.EventHandler(this.lstBxInvoices_SelectedIndexChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.invoicePanel.ResumeLayout(false);
            this.invoicePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxSendName;
        private System.Windows.Forms.TextBox txtBxSendAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxSendCity;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBxShipType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBxCarrier;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxRecpZip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxRecpState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxRecpCity;
        private System.Windows.Forms.TextBox txtBxRecpAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBxRecpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxSendZip;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.TextBox txtBxSendState;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.TextBox txtBxInfo;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.ListBox lstBxInvoices;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBxInfo2;
        private System.Windows.Forms.Button printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel invoicePanel;
        private System.Windows.Forms.Button createLabelButton;
        private System.Windows.Forms.Button btnSaveInv;
        private System.Windows.Forms.Label label12;
    }
}

