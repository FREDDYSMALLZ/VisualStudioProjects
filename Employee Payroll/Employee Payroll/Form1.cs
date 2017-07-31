using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Payroll
{
    public partial class EmployeePayroll : Form
    {
       
        public EmployeePayroll()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hours, rate;
            double FederalTax, NetPay, StateTax, GrossPay;

            /* Console.Write("Please Enter the number of hours worked");
             String input = Console.ReadLine();
             double hours = double.Parse
             */
            hours = Convert.ToDouble(textBox_HoursWorked.Text);
            rate = Convert.ToDouble(textBox_HourlyRate.Text);

            GrossPay = hours * rate;
            FederalTax = GrossPay * 0.15;
            StateTax = GrossPay * 0.05;
            NetPay = GrossPay - (FederalTax + StateTax);

            textBoxGrossPay.Text = GrossPay.ToString("C");
            textBoxFedTax.Text = FederalTax.ToString("C");
            textBoxStateTax.Text = StateTax.ToString("C");
            textBoxNetPay.Text = NetPay.ToString("C");
        }
    }
}
