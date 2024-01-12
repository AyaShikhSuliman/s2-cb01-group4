using Logic.Classes.Accounts;
using Logic.Classes.Employees;
using Data;
using Logic.Enums;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication.Adminstration.Employees
{
    public partial class UpdateEmployee : Form
    {
        private Employee Employee;
        private IEmployeeManager employeeManager;
        private AccountTypes accountTypes;
        
        public UpdateEmployee(Employee employee)
        {
            InitializeComponent();

            tbConfirmation.Visible = false;

			this.Employee = employee;
			employeeManager = new EmployeeManager(new EmployeeDataManager());

			tbID.Text = Employee.id.ToString();
            tbName.Text = Employee.name;
            tbAge.Text = Employee.age.ToString();
            tbEmail.Text = Employee.email;
            tbPhoneNumber.Text = Employee.phoneNumber;
            tbPassword.Text = Employee.password;
            tbAdress.Text = Employee.adress;
            cbGender.Text = Employee.gender.ToString();
            cbPosition.Text = Employee.position.ToString();

            loadEmployeePositionCbx();
            loadGenderCbx();
        }
        public void loadGenderCbx()
        {
            foreach (Gender gender in Enum.GetValues(typeof(Gender)))
            {
                cbGender.Items.Add(gender);
            }
        }
        public void loadEmployeePositionCbx()
        {
            foreach (EmployeeRole position in Enum.GetValues(typeof(EmployeeRole)))
            {
                cbPosition.Items.Add(position);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Gender gender = Gender.Parse<Gender>(cbGender.Text);
            EmployeeRole position = EmployeeRole.Parse<EmployeeRole>(cbPosition.Text);
            Employee employee = new Employee(int.Parse(tbID.Text), tbName.Text, int.Parse(tbAge.Text), tbEmail.Text, gender, tbPhoneNumber.Text, tbPassword.Text, tbAdress.Text, position);
            employeeManager.EditEmployee(employee);

			tbConfirmation.Visible = true;
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

			tbID.Text = "";
            tbName.Text = "";
            tbAge.Text = "";
            tbEmail.Text = "";
            tbPhoneNumber.Text = "";
            tbPassword.Text = "";
            tbAdress.Text = "";
            cbGender.Text = "";
            cbPosition.Text = "";
        }

        private void UpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EmployeeGeneralForm generalForm = new EmployeeGeneralForm(accountTypes);
            generalForm.Show();
            this.Hide();
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
            tbConfirmation.Visible = false;
		}
	}
}
