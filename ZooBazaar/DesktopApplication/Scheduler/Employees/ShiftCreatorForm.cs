using DesktopApplication.Scheduler.Animals;
using Logic.Animals.Enums;
using Logic.Classes.Employees;
using Logic.Classes.Shift;
using Data;
using Logic.Enums;
using Logic.Enums.Animal;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.data;

namespace DesktopApplication.Scheduler.Employees
{
    public partial class ShiftCreatorForm : Form
    {
        IEmployeeManager employeeManager;
        IShiftManager shiftManager;

        public ShiftCreatorForm()
        {

            InitializeComponent();

            tbConfirmation.Visible = false;

            employeeManager = new EmployeeManager(new EmployeeDataManager());
            shiftManager = new ShiftManager(new ShiftDataManager());

            cbShiftTimes.Items.AddRange(Enum.GetNames(typeof(ShiftType)));
            LoadListBoxEmployeeInfo();
        }

        public void LoadListBoxEmployeeInfo()
        {

            foreach (Employee employee in employeeManager.ShowAll())
            {
                //foreach (Shift shift in shiftManager.GetAllShifts())
                //{
                //    if (employee.id != )
                //    {
                lbInfo.Items.Add(employee);
                //    }
                //}
            }
        }
        private void ShiftCreatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AccountTypes accountTypes = AccountTypes.Scheduler;
            SLoginOptionsForm sLoginOptionsForm = new SLoginOptionsForm(accountTypes);
            sLoginOptionsForm.SetBackGroundColourEmployeeButton();
            sLoginOptionsForm.Show();
            this.Hide();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = lbInfo.SelectedItem as Employee;
            ShiftType shiftType = Enum.Parse<ShiftType>(cbShiftTimes.Text);
            DateTime date = Convert.ToDateTime(ChooseDate.Value.ToShortDateString());
            Shift shift = new Shift(employee, shiftType, date);


            if (shiftManager.CheckExistingShiftForAnEmployee(shift) == false)
            {
                shiftManager.AddShift(shift);

                tbConfirmation.Visible = true;
                this.timer1.Enabled = true;
                this.timer1.Interval = 1000;
                this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            }
            else
            {
                MessageBox.Show("This Shift already exist for this employee!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbConfirmation.Visible = false;
        }

        private void btnExtraInfo_Click(object sender, EventArgs e)
        {
            ExtraInfo extraInfo = new ExtraInfo();
            extraInfo.Show();
            this.Hide();
        }
    }
}
