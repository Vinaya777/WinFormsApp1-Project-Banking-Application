
namespace WinFormsApp1_Project_Banking_Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Click = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BasicSalaryText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HRATxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DATxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TATxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalSalaryTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(138, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "My First Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 34);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(19, 146);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(115, 23);
            this.Password.TabIndex = 3;
            this.Password.Text = "Enter Pasword";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 146);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(282, 32);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Click
            // 
            this.Click.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Click.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Click.Location = new System.Drawing.Point(579, 379);
            this.Click.Name = "Click";
            this.Click.Size = new System.Drawing.Size(131, 35);
            this.Click.TabIndex = 5;
            this.Click.Text = "Click\r\n";
            this.Click.UseVisualStyleBackColor = true;
            this.Click.Click += new System.EventHandler(this.Click_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = " Basic  Salary";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BasicSalaryText
            // 
            this.BasicSalaryText.Location = new System.Drawing.Point(211, 204);
            this.BasicSalaryText.Name = "BasicSalaryText";
            this.BasicSalaryText.Size = new System.Drawing.Size(282, 27);
            this.BasicSalaryText.TabIndex = 8;
            this.BasicSalaryText.TextChanged += new System.EventHandler(this.BasicSalaryText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(42, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "HRA";
            // 
            // HRATxt
            // 
            this.HRATxt.Location = new System.Drawing.Point(211, 259);
            this.HRATxt.Name = "HRATxt";
            this.HRATxt.Size = new System.Drawing.Size(282, 27);
            this.HRATxt.TabIndex = 10;
            this.HRATxt.TextChanged += new System.EventHandler(this.HRATxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(52, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "DA";
            // 
            // DATxt
            // 
            this.DATxt.Location = new System.Drawing.Point(211, 317);
            this.DATxt.Name = "DATxt";
            this.DATxt.Size = new System.Drawing.Size(285, 27);
            this.DATxt.TabIndex = 12;
            this.DATxt.TextChanged += new System.EventHandler(this.DATxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(52, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "TA";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TATxt
            // 
            this.TATxt.Location = new System.Drawing.Point(211, 362);
            this.TATxt.Name = "TATxt";
            this.TATxt.Size = new System.Drawing.Size(282, 27);
            this.TATxt.TabIndex = 14;
            this.TATxt.TextChanged += new System.EventHandler(this.TATxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(52, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "TotalSalary";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // TotalSalaryTxt
            // 
            this.TotalSalaryTxt.Location = new System.Drawing.Point(211, 409);
            this.TotalSalaryTxt.Name = "TotalSalaryTxt";
            this.TotalSalaryTxt.Size = new System.Drawing.Size(285, 27);
            this.TotalSalaryTxt.TabIndex = 16;
            this.TotalSalaryTxt.TextChanged += new System.EventHandler(this.TotalSalaryTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(579, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(579, 317);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(131, 36);
            this.CalculateButton.TabIndex = 19;
            this.CalculateButton.Text = "Claculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1536, 544);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TotalSalaryTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TATxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DATxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HRATxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BasicSalaryText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Click);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Click;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BasicSalaryText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HRATxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DATxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TATxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TotalSalaryTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CalculateButton;
    }
}

