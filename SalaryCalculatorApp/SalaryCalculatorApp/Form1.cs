using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryCalcForm : Form
    {
        public SalaryCalcForm()
        {
            InitializeComponent();
        }
        Employee anEmployee = new Employee();
        EmployeeName empName = new EmployeeName();
        private void showMeSalaryButton_Click(object sender, EventArgs e)
        {
            empName.name = employeeNameTextBox.Text;
            anEmployee.basicAcc = Convert.ToDouble(basicAccountTextBox.Text);
            anEmployee.houseRent = Convert.ToDouble(houseRentTextBox.Text);
            anEmployee.medicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);

            MessageBox.Show("Name: "+empName.name+"\nand the salary is "+anEmployee.getSalary().ToString());

        }
    }
}
