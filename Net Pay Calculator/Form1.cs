using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net_Pay_Calculator
{
    public partial class Form1 : Form
    {
        int salary = 0;
        int basicSal = 5000;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double totalWeekSales = Convert.ToDouble(textBox2.Text);
            double pay = totalWeekSales * 0.07;

            double federalTaxRate = pay * 0.018;
            double retirementContribution = pay * 0.015;
            double socialSecurityTax = pay * 0.09;

            textBox3.Text = Convert.ToString(federalTaxRate);
            textBox4.Text = Convert.ToString(retirementContribution);
            textBox5.Text = Convert.ToString(socialSecurityTax);


            double netPay = pay - (federalTaxRate + retirementContribution + socialSecurityTax);

            label9.Text = Convert.ToString(netPay);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

