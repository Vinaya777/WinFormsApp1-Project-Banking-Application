using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1_Project_Banking_Application
{
    [Serializable]
   public  class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }
    }
}
