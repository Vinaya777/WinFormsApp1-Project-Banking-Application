using System;

using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

using System.Text.Json;
using System.Xml.Serialization;

namespace WinFormsApp1_Project_Banking_Application
{
    public partial class Form5 : Form


    {
        public Form5()
        {
            InitializeComponent();
        }

        private void BinaryWrite_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    FileStream fs = new FileStream(@"D:\SkillMineDoc\emp.dat", FileMode.Create, FileAccess.Write);
                    FileStream fs1 = new FileStream(@"D:\SkillMineDoc\Employee.dat", FileMode.Create, FileAccess.Write);

                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(Convert.ToInt32(IdTxt.Text));
                    bw.Write(Nametxt.Text);
                    bw.Write(Convert.ToDouble(SalaryTxt.Text));
                    Employee emp = new Employee();
                    emp.Id = Convert.ToInt32(IdTxt.Text);
                    emp.Name = Nametxt.Text;
                    emp.Salary = Convert.ToInt32(SalaryTxt.Text);
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                   
                    binaryFormatter.Serialize(fs1, emp);
                    fs1.Close();
                    MessageBox.Show("Employee record added to file");

                    bw.Close();
                    fs.Close();

                    MessageBox.Show("Data saved to file..");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalaryTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void BinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs1 = new FileStream(@"D:\SkillMineDoc\Employee.dat", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();

                FileStream fs = new FileStream(@"D:\SkillMineDoc\emp.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                emp = (Employee)binaryFormatter.Deserialize(fs1);
                fs1.Close();

                BinaryReader br = new BinaryReader(fs);
                IdTxt.Text = br.ReadInt32().ToString();
                Nametxt.Text = br.ReadString();
                IdTxt.Text = emp.Id.ToString();
                Nametxt.Text = emp.Name;
                SalaryTxt.Text = emp.Salary.ToString();

                SalaryTxt.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void XMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"D:\SkillMineDoc\EmployeeXML.xml", FileMode.Create, FileAccess.Write);
                // step 2
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(IdTxt.Text);
                emp.Name = Nametxt.Text;
                emp.Salary = Convert.ToInt32(SalaryTxt.Text);
                // step 3
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                xml.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Employee record added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SOAPWrite_Click(object sender, EventArgs e)
        {


            try
            {
                // step1 1
                FileStream fs = new FileStream(@"D:\SkillMineDoc\EmployeeSOAP.soap", FileMode.Create, FileAccess.Write);
                // step 2
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(IdTxt.Text);
                emp.Name = Nametxt.Text;
                emp.Salary = Convert.ToInt32(SalaryTxt.Text);
                // step 3
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Employee record added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"D:\SkillMineDoc\EmployeeSOAP.soap", FileMode.Open, FileAccess.Read);
                // step 2
                Employee emp = new Employee();
                // step 3
                //SoapFormatter soap = new SoapFormatter();
               // emp = (Employee)soap.Deserialize(fs);
                fs.Close();

                IdTxt.Text = emp.Id.ToString();
                Nametxt.Text = emp.Name;
                SalaryTxt.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void XMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"D:\SkillMineDoc\EmployeeXML.xml", FileMode.Open, FileAccess.Read);
                // step 2
                Employee emp = new Employee();
                // step 3
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                emp = (Employee)xml.Deserialize(fs);
                fs.Close();

                IdTxt.Text = emp.Id.ToString();
                Nametxt.Text = emp.Name;
                SalaryTxt.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void JSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"D:\SkillMineDoc\EmployeeJSON.json", FileMode.Create, FileAccess.Write);
                // step 2
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(IdTxt.Text);
                emp.Name = Nametxt.Text;
                emp.Salary = Convert.ToInt32(SalaryTxt.Text);
                // step 3
                JsonSerializer.Serialize<Employee>(fs, emp);
                fs.Close();
                MessageBox.Show("Employee record added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void JSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"D:\SkillMineDoc\EmployeeJSON.json", FileMode.Open, FileAccess.Read);
                // step 2
                Employee emp = new Employee();
                // step 3

                emp = JsonSerializer.Deserialize<Employee>(fs);
                fs.Close();

                IdTxt.Text = emp.Id.ToString();
                Nametxt.Text = emp.Name;
                SalaryTxt.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}