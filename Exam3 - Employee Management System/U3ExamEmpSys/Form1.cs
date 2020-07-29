using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3ExamEmpSys
{
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBoxFullTime.DataSource = DataAdapter.SelectAll();
            labelStatus.Text = DataAdapter.Status;


        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            DataAdapter.Connect();
            labelStatus.Text = DataAdapter.Status;
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            DataAdapter.Disconnect();
            labelStatus.Text = DataAdapter.Status;
        }

        private void listBoxFullTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFullTime.SelectedIndex != -1){
                i = listBoxFullTime.SelectedIndex;
                FullTime FTEmployee = (FullTime)listBoxFullTime.Items[i];
                employeeIDtxtBox.Text = FTEmployee.EmployeeID.ToString();
                nameTxtBox.Text = FTEmployee.FName + " " + FTEmployee.LName;
                salaryTxtBox.Text = FTEmployee.Salary.ToString();
                sickDayTxtBox.Text = FTEmployee.SickDays.ToString();
                vacationDayTxtBox.Text = FTEmployee.VacationDays.ToString();
                if (FTEmployee.HasInsurance)
                {
                    hasInsuranceCheckBox.Checked = true ;
                }
                else
                {
                    hasInsuranceCheckBox.Checked = false;
                }
                if(FTEmployee.TaxExempt)
                {
                    taxExemptCheckBox.Checked = true;
                }
                else
                {
                    taxExemptCheckBox.Checked = false;
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int newInsurance=0 ;
            int newTaxExempt =0;

            if (addInsured.Checked == true)
            { newInsurance = 1; }
            if (addTaxExempt.Checked == true)
            {newTaxExempt = 1; }
            DataAdapter.InsertFullTime(
                addLname.Text,
                addFName.Text,
                DateTime.Now,
                Convert.ToInt32(addSocial.Text),
                addEmail.Text,
                Convert.ToInt32(addPhone.Text),
                Convert.ToDecimal(addTaxRate.Text),
                Convert.ToInt32(addEmpID.Text),
                Convert.ToInt32(addSalary.Text),
                Convert.ToInt32(addVacationDays.Text),
                newInsurance,
                newTaxExempt,
                Convert.ToInt32(addSickDays.Text)

                
                );
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int employeeID = Convert.ToInt32(employeeIDtxtBox.Text);
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + nameTxtBox.Text + "?","Delete?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataAdapter.DeleteFullTime(employeeID);
            }
        }
    }
}


