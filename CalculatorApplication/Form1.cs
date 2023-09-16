using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{

    public partial class Form1 : Form
    {
        CalculatorClass cal;
        double num1, num2;
       

        
        public Form1()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtboxinput1.Text);
            num2 = Convert.ToDouble(txtboxinput2.Text);

            // Checking if the combobox is valid
            if (cbOperator.Text == "+")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetSum);
                lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetSum);
            }
            else if (cbOperator.Text == "-")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
            }
            else if (cbOperator.Text == "*")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
            }
            else if (cbOperator.Text == "/")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetQoutient);
                lblDisplayTotal.Text = cal.GetQoutient(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetQoutient);
            }
        }
    }
}
