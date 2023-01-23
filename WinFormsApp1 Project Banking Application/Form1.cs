using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_Project_Banking_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Click_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
            label3.Visible = true;

            MessageBox.Show("Helooo: " + textBox1.Text);
            MessageBox.Show("Welcome to Form..!!!!!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        

        private void BasicSalaryText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double basic = Convert.ToDouble(BasicSalaryText.Text);
            double hra = basic * .15;
            double ta = basic * .20;
            double da = basic * .17;
            double pf = basic * 0.020;
            double totalsalary = (basic + hra + da +ta) - pf;
            HRATxt.Text = hra.ToString();
            DATxt.Text = da.ToString();
            TATxt.Text = ta.ToString();
            TotalSalaryTxt.Text = totalsalary.ToString();
        }

        private void HRATxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DATxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void TATxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalSalaryTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
