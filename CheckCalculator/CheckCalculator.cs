using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckCalculator
{
    public partial class CheckCalculator : Form
    {
        public CheckCalculator()
        {
            InitializeComponent();
        }
     
        private void clear_Click(object sender, EventArgs e)
        {
            hourlyPayTextBox.Text = "";
            hoursTextBox.Text = "";
            grossPayTextBox.Text = "";
            netPayTextBox.Text = "";
            paIncomeTaxTextBox.Text = "";
            paSUISDITaxTextBox.Text = "";
            decaturTownshipTaxTextBox.Text = "";            
            socialSecurityTextBox.Text = "";
            medicareTaxTextBox.Text = "";
            hoursTextBox.Focus();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enter_Click_1(object sender, EventArgs e)
        {
            decimal socialSecurityTax = .062M;
            decimal medicareTax = .0145M;
            decimal paIncomeTax = .0307M;
            decimal decaturTownshipIncomeTax = .01350M;
            decimal paSuiSdiTax = .0007M;            
            decimal hourlyPay, hoursWorked, netPay;                     

            // Reading user input for hourly wage earned
            hourlyPay = Convert.ToDecimal(hourlyPayTextBox.Text);
            hoursWorked = Convert.ToDecimal(hoursTextBox.Text);

            decimal grossPay = hourlyPay * hoursWorked;
            decimal socialSecurityTaxWithholding = grossPay * socialSecurityTax;
            decimal medicareTaxWithholding = grossPay * medicareTax;
            decimal paIncomeTaxWithholding = grossPay * paIncomeTax;
            decimal decaturTowhshipIncomeTaxWithholding = grossPay * decaturTownshipIncomeTax;
            decimal paSuiSdiWithholding = grossPay * paSuiSdiTax;

            grossPayTextBox.Text = (Convert.ToDecimal(hourlyPay) *
                Convert.ToDecimal(hoursWorked)).ToString("C2");
            paIncomeTaxTextBox.Text = (grossPay * paIncomeTax).ToString("C2");
            socialSecurityTextBox.Text = (grossPay * socialSecurityTax).ToString("C2");
            medicareTaxTextBox.Text = (grossPay * medicareTax).ToString("C2");
            decaturTownshipTaxTextBox.Text = (grossPay * decaturTownshipIncomeTax).ToString("C2");
            paSUISDITaxTextBox.Text = (grossPay * paSuiSdiTax).ToString("C2");

            netPayTextBox.Text = (grossPay - socialSecurityTaxWithholding - medicareTaxWithholding -
                paIncomeTaxWithholding - decaturTowhshipIncomeTaxWithholding - paSuiSdiWithholding).ToString("C2");

            grossPayLabel.Visible = true;
            socialSecurityTaxLabel.Visible = true;
            medicareTaxLabel.Visible = true;
            paIncomeTaxLabel.Visible = true;
            decaturTownshipTaxLabel.Visible = true;
            PaSUISDITax.Visible = true;
            netPayLabel.Visible = true;
        }

        private void CheckCalculator_Load(object sender, EventArgs e)
        {
            grossPayLabel.Visible = false;
            socialSecurityTaxLabel.Visible = false;
            medicareTaxLabel.Visible = false;
            paIncomeTaxLabel.Visible = false;
            decaturTownshipTaxLabel.Visible = false;
            PaSUISDITax.Visible = false;
            netPayLabel.Visible = false;

        }            
    }
}
