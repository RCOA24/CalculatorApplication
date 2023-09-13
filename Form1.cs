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
        //initiliaze delegate return type name formula with 2 parameter T
        public delegate T Formula<T>(T arg1, T arg2);

        class CalculatorClass //main class named Calculator Class
        {

            //declared a delegate variable name formula and double datatype
            public Formula<double> formula;

            //created static method name getsum of two double datatype parameter named num 1 and num 2 
            public static double GetSum(double num1, double num2)
            {
                return num1 + num2;//return sum of num1 and num2 
            }
            //created static method name GetDifference of two double datatype parameter named num1 and num2
            public static double GetDifference(double num1, double num2)
            {
                return num1 - num2;//return difference of num 1 and num 2
            }

            //created delegate event successor name calculatorevent
            public event Formula<double> CalculatorEvent
            {
                add//add deleagate
                {
                    Console.WriteLine("Added the Delegate");//print delegate added
                }
                remove//remove delegate
                {
                    Console.WriteLine("Remove the Delegate");//print delegate removed
                }
            }
            //created static method name getProduct of two double datatype parameter named sum1 and sum2
            public static double GetProduct(double num1, double num2)
            {
                return num1 * num2;
            }

            public static double GetQuotient(double num1, double num2)
            {
                return num1 / num2;
            }



        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
