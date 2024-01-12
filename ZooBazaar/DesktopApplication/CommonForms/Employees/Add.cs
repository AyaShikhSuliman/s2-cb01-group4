using DesktopApplication.Adminstration.Employees;
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

namespace DesktopApplication.Adminstration
{
    public partial class AddForm : Form
    {
        IEmployeeManager manager = new EmployeeManager(new EmployeeDataManager());
        public AddForm()
        {
            InitializeComponent();
           
            loadEmployeePositionCbx();
            loadGenderCbx();

            tbConfirmation.Visible = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPosition.SelectedItem != null || cbGender.SelectedItem != null)
                {
					Gender gender = (Gender)cbGender.SelectedItem;
                    EmployeeRole position = (EmployeeRole)cbPosition.SelectedItem;
                    
                    Employee employee = new Employee(tbName.Text, Convert.ToInt32(tbAge.Text), tbEmail.Text, gender, tbPhoneNumber.Text, tbPassword.Text, tbAdress.Text, position);
                    manager.AddEmployee(employee);
                  
                    tbConfirmation.Visible = true;
					this.timer1.Enabled = true;
					this.timer1.Interval = 1000;
					this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

					tbAdress.Text = "";
                    tbAge.Text = "";
                    tbEmail.Text = "";
                    tbPassword.Text = "";
                    tbName.Text = "";
                    tbPhoneNumber.Text = "";
                    cbGender.Text = "";
                    cbPosition.Text = "";
				}
				else
                {
                    MessageBox.Show("Gender or Position can't be empty");
                }

            }
            catch
            {
                MessageBox.Show("All fields should be filled");
            }
        }


        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ALoginOptionsForm aELoginOptions = new ALoginOptionsForm(new AccountTypes());
            aELoginOptions.SetEmployeeButtons();
            aELoginOptions.Show();
            this.Hide();
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
			tbConfirmation.Visible = false;
		}
	}
}
