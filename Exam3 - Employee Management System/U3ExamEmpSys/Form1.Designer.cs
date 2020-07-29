namespace U3ExamEmpSys
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
            this.connectBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.listBoxFullTime = new System.Windows.Forms.ListBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.salaryTxtBox = new System.Windows.Forms.TextBox();
            this.vacationDayTxtBox = new System.Windows.Forms.TextBox();
            this.sickDayTxtBox = new System.Windows.Forms.TextBox();
            this.taxExemptCheckBox = new System.Windows.Forms.CheckBox();
            this.hasInsuranceCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addFName = new System.Windows.Forms.TextBox();
            this.addLname = new System.Windows.Forms.TextBox();
            this.addEmail = new System.Windows.Forms.TextBox();
            this.addSocial = new System.Windows.Forms.TextBox();
            this.addPhone = new System.Windows.Forms.TextBox();
            this.addSalary = new System.Windows.Forms.TextBox();
            this.addEmpID = new System.Windows.Forms.TextBox();
            this.addTaxRate = new System.Windows.Forms.TextBox();
            this.addSickDays = new System.Windows.Forms.TextBox();
            this.addVacationDays = new System.Windows.Forms.TextBox();
            this.addTaxExempt = new System.Windows.Forms.CheckBox();
            this.addInsured = new System.Windows.Forms.CheckBox();
            this.employeeIDtxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(12, 332);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(118, 55);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Load Full Time Employee Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Location = new System.Drawing.Point(251, 332);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(107, 55);
            this.disconnectBtn.TabIndex = 2;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // listBoxFullTime
            // 
            this.listBoxFullTime.FormattingEnabled = true;
            this.listBoxFullTime.Location = new System.Drawing.Point(12, 46);
            this.listBoxFullTime.Name = "listBoxFullTime";
            this.listBoxFullTime.Size = new System.Drawing.Size(723, 264);
            this.listBoxFullTime.TabIndex = 3;
            this.listBoxFullTime.SelectedIndexChanged += new System.EventHandler(this.listBoxFullTime_SelectedIndexChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(177, 27);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 13);
            this.labelStatus.TabIndex = 4;
            // 
            // salaryTxtBox
            // 
            this.salaryTxtBox.Location = new System.Drawing.Point(19, 80);
            this.salaryTxtBox.Name = "salaryTxtBox";
            this.salaryTxtBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTxtBox.TabIndex = 5;
            // 
            // vacationDayTxtBox
            // 
            this.vacationDayTxtBox.Location = new System.Drawing.Point(19, 124);
            this.vacationDayTxtBox.Name = "vacationDayTxtBox";
            this.vacationDayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.vacationDayTxtBox.TabIndex = 6;
            // 
            // sickDayTxtBox
            // 
            this.sickDayTxtBox.Location = new System.Drawing.Point(19, 167);
            this.sickDayTxtBox.Name = "sickDayTxtBox";
            this.sickDayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.sickDayTxtBox.TabIndex = 7;
            // 
            // taxExemptCheckBox
            // 
            this.taxExemptCheckBox.AutoSize = true;
            this.taxExemptCheckBox.Location = new System.Drawing.Point(19, 193);
            this.taxExemptCheckBox.Name = "taxExemptCheckBox";
            this.taxExemptCheckBox.Size = new System.Drawing.Size(82, 17);
            this.taxExemptCheckBox.TabIndex = 8;
            this.taxExemptCheckBox.Text = "Tax Exempt";
            this.taxExemptCheckBox.UseVisualStyleBackColor = true;
            // 
            // hasInsuranceCheckBox
            // 
            this.hasInsuranceCheckBox.AutoSize = true;
            this.hasInsuranceCheckBox.Location = new System.Drawing.Point(19, 216);
            this.hasInsuranceCheckBox.Name = "hasInsuranceCheckBox";
            this.hasInsuranceCheckBox.Size = new System.Drawing.Size(61, 17);
            this.hasInsuranceCheckBox.TabIndex = 9;
            this.hasInsuranceCheckBox.Text = "Insured";
            this.hasInsuranceCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(19, 35);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(166, 20);
            this.nameTxtBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Employee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Salary: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Vacation Days Available:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sick Days Available:";
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.label5);
            this.groupbox1.Controls.Add(this.employeeIDtxtBox);
            this.groupbox1.Controls.Add(this.deleteBtn);
            this.groupbox1.Controls.Add(this.updateBtn);
            this.groupbox1.Controls.Add(this.label4);
            this.groupbox1.Controls.Add(this.label3);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.nameTxtBox);
            this.groupbox1.Controls.Add(this.hasInsuranceCheckBox);
            this.groupbox1.Controls.Add(this.taxExemptCheckBox);
            this.groupbox1.Controls.Add(this.sickDayTxtBox);
            this.groupbox1.Controls.Add(this.vacationDayTxtBox);
            this.groupbox1.Controls.Add(this.salaryTxtBox);
            this.groupbox1.Location = new System.Drawing.Point(761, 46);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(250, 316);
            this.groupbox1.TabIndex = 15;
            this.groupbox1.TabStop = false;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(19, 259);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(110, 259);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 55);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addFName
            // 
            this.addFName.Location = new System.Drawing.Point(204, 447);
            this.addFName.Name = "addFName";
            this.addFName.Size = new System.Drawing.Size(100, 20);
            this.addFName.TabIndex = 17;
            // 
            // addLname
            // 
            this.addLname.Location = new System.Drawing.Point(321, 447);
            this.addLname.Name = "addLname";
            this.addLname.Size = new System.Drawing.Size(100, 20);
            this.addLname.TabIndex = 18;
            // 
            // addEmail
            // 
            this.addEmail.Location = new System.Drawing.Point(427, 447);
            this.addEmail.Name = "addEmail";
            this.addEmail.Size = new System.Drawing.Size(100, 20);
            this.addEmail.TabIndex = 19;
            // 
            // addSocial
            // 
            this.addSocial.Location = new System.Drawing.Point(651, 447);
            this.addSocial.Name = "addSocial";
            this.addSocial.Size = new System.Drawing.Size(100, 20);
            this.addSocial.TabIndex = 20;
            // 
            // addPhone
            // 
            this.addPhone.Location = new System.Drawing.Point(533, 447);
            this.addPhone.Name = "addPhone";
            this.addPhone.Size = new System.Drawing.Size(100, 20);
            this.addPhone.TabIndex = 21;
            // 
            // addSalary
            // 
            this.addSalary.Location = new System.Drawing.Point(321, 498);
            this.addSalary.Name = "addSalary";
            this.addSalary.Size = new System.Drawing.Size(100, 20);
            this.addSalary.TabIndex = 22;
            // 
            // addEmpID
            // 
            this.addEmpID.Location = new System.Drawing.Point(204, 421);
            this.addEmpID.Name = "addEmpID";
            this.addEmpID.Size = new System.Drawing.Size(79, 20);
            this.addEmpID.TabIndex = 23;
            // 
            // addTaxRate
            // 
            this.addTaxRate.Location = new System.Drawing.Point(204, 498);
            this.addTaxRate.Name = "addTaxRate";
            this.addTaxRate.Size = new System.Drawing.Size(100, 20);
            this.addTaxRate.TabIndex = 24;
            // 
            // addSickDays
            // 
            this.addSickDays.Location = new System.Drawing.Point(427, 498);
            this.addSickDays.Name = "addSickDays";
            this.addSickDays.Size = new System.Drawing.Size(100, 20);
            this.addSickDays.TabIndex = 25;
            // 
            // addVacationDays
            // 
            this.addVacationDays.Location = new System.Drawing.Point(533, 498);
            this.addVacationDays.Name = "addVacationDays";
            this.addVacationDays.Size = new System.Drawing.Size(100, 20);
            this.addVacationDays.TabIndex = 26;
            // 
            // addTaxExempt
            // 
            this.addTaxExempt.AutoSize = true;
            this.addTaxExempt.Location = new System.Drawing.Point(655, 498);
            this.addTaxExempt.Name = "addTaxExempt";
            this.addTaxExempt.Size = new System.Drawing.Size(80, 17);
            this.addTaxExempt.TabIndex = 27;
            this.addTaxExempt.Text = "checkBox1";
            this.addTaxExempt.UseVisualStyleBackColor = true;
            // 
            // addInsured
            // 
            this.addInsured.AutoSize = true;
            this.addInsured.Location = new System.Drawing.Point(741, 498);
            this.addInsured.Name = "addInsured";
            this.addInsured.Size = new System.Drawing.Size(80, 17);
            this.addInsured.TabIndex = 28;
            this.addInsured.Text = "checkBox2";
            this.addInsured.UseVisualStyleBackColor = true;
            // 
            // employeeIDtxtBox
            // 
            this.employeeIDtxtBox.Location = new System.Drawing.Point(134, 80);
            this.employeeIDtxtBox.Name = "employeeIDtxtBox";
            this.employeeIDtxtBox.Size = new System.Drawing.Size(100, 20);
            this.employeeIDtxtBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Employee ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 581);
            this.Controls.Add(this.addInsured);
            this.Controls.Add(this.addTaxExempt);
            this.Controls.Add(this.addVacationDays);
            this.Controls.Add(this.addSickDays);
            this.Controls.Add(this.addTaxRate);
            this.Controls.Add(this.addEmpID);
            this.Controls.Add(this.addSalary);
            this.Controls.Add(this.addPhone);
            this.Controls.Add(this.addSocial);
            this.Controls.Add(this.addEmail);
            this.Controls.Add(this.addLname);
            this.Controls.Add(this.addFName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.listBoxFullTime);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.connectBtn);
            this.Name = "Form1";
            this.Text = "Full Time Employee Data";
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.ListBox listBoxFullTime;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox salaryTxtBox;
        private System.Windows.Forms.TextBox vacationDayTxtBox;
        private System.Windows.Forms.TextBox sickDayTxtBox;
        private System.Windows.Forms.CheckBox taxExemptCheckBox;
        private System.Windows.Forms.CheckBox hasInsuranceCheckBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox addFName;
        private System.Windows.Forms.TextBox addLname;
        private System.Windows.Forms.TextBox addEmail;
        private System.Windows.Forms.TextBox addSocial;
        private System.Windows.Forms.TextBox addPhone;
        private System.Windows.Forms.TextBox addSalary;
        private System.Windows.Forms.TextBox addEmpID;
        private System.Windows.Forms.TextBox addTaxRate;
        private System.Windows.Forms.TextBox addSickDays;
        private System.Windows.Forms.TextBox addVacationDays;
        private System.Windows.Forms.CheckBox addTaxExempt;
        private System.Windows.Forms.CheckBox addInsured;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox employeeIDtxtBox;
    }
}

