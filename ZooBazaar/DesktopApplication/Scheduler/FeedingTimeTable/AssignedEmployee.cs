using Data;
using Data.data;
using DesktopApplication.Adminstration.Employees;
using DesktopApplication.Scheduler.Animals;
using Logic.Classes.Employees;
using Logic.Classes.Shift;
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

namespace DesktopApplication.Scheduler.FeedingTimeTable
{
    public partial class AssignedEmployee : Form
    {
        IShiftDataManager shiftDataManager;

        private AccountTypes _accountTypes;

        public AssignedEmployee()
        {
            InitializeComponent();

            shiftDataManager = new ShiftDataManager();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cbEmployees.SelectedIndex > -1)
            {
                MessageBox.Show("Employee has been assigned");
                cbEmployees.Text = String.Empty;
            }
        }

        private void dtpFeeding_ValueChanged(object sender, EventArgs e)
        {
            cbEmployees.Items.Clear();
            DateTime date = Convert.ToDateTime(dtpFeeding.Value.ToShortDateString());
            List<Employee> employees = shiftDataManager.GetAvailableEmployeesByDate(date);
            foreach (var item in employees)
            {
                cbEmployees.Items.Add(item.name);
            }

        }

        private void AssignedEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_accountTypes == AccountTypes.Scheduler)
            {
                SLoginOptionsForm sLoginOptionsForm = new SLoginOptionsForm(_accountTypes);
                sLoginOptionsForm.SetAnimalButtons();
                sLoginOptionsForm.Show();
                this.Hide();
                return;
            }
            else if (_accountTypes == AccountTypes.Admin)
            {
                ALoginOptionsForm aloginOptionsForm = new ALoginOptionsForm(_accountTypes);
                aloginOptionsForm.SetAnimalButtons();
                aloginOptionsForm.Show();
                this.Hide();
                return;
            }
        }
    }
}
