using DesktopApplication.Adminstration;
using DesktopApplication.Adminstration.Animals;
using DesktopApplication.Scheduler.Animal;
using DesktopApplication.Scheduler.Employees;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication.Scheduler.Animals
{
    public partial class SLoginOptionsForm : Form
    {
        private AccountTypes _accountTypes;

        public SLoginOptionsForm(AccountTypes accountTypes)
        {
            InitializeComponent();

            _accountTypes = accountTypes;

			_accountTypes = AccountTypes.Scheduler;
        }

        public void SetEmployeeButtons()
        {
			lblEmployeeGeneral.Visible = true;
			lblSchedule.Visible = true;

            btnEmployees.BackColor = Color.Green;
            btnAnimals.BackColor = Color.Brown;

            lblAnimalGeneral.Visible = false;
			lblCreateFeedingTimetable.Visible = false;
			lblReports.Visible = false;
		}

		public void SetAnimalButtons()
		{
			lblEmployeeGeneral.Visible = false;
			lblSchedule.Visible = false;
            btnAnimals.BackColor = Color.Green;
            btnEmployees.BackColor = Color.Brown;
            lblAnimalGeneral.Visible = true;
			lblCreateFeedingTimetable.Visible = true;
			lblReports.Visible = true;
		}

        public void SetBackGroundColourEmployeeButton()
		{
			btnEmployees.BackColor = Color.Green;
		}

		private void SLoginOptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm(_accountTypes);
            loginForm.Show();
            this.Hide();
        }  

		private void btnAnimals_Click(object sender, EventArgs e)
		{
            lblEmployeeGeneral.Visible= false;
            lblSchedule.Visible= false;
			btnAnimals.BackColor = Color.Green;
			btnEmployees.BackColor = Color.Brown;
            lblAnimalGeneral.Visible = true;
            lblCreateFeedingTimetable.Visible = true;
			lblReports.Visible = true;
		}

        private void btnEmployees_Click(object sender, EventArgs e)
		{
			lblEmployeeGeneral.Visible = true;
			lblSchedule.Visible = true;
			btnEmployees.BackColor= Color.Green;
			btnAnimals.BackColor = Color.Brown;
			lblAnimalGeneral.Visible = false;
			lblCreateFeedingTimetable.Visible = false;
			lblReports.Visible = false;
		}

        private void lblAnimalGeneral_Click(object sender, EventArgs e)
		{
			AnimalGeneralForm animalGeneralForm = new AnimalGeneralForm(_accountTypes);
			animalGeneralForm.Show();
			this.Hide();
		}

		private void lblEmployeeGeneral_Click(object sender, EventArgs e)
		{
            EmployeeScedule employeeGeneralForm = new EmployeeScedule();
            employeeGeneralForm.Show();
            this.Hide();
		}

		private void lblSchedule_Click(object sender, EventArgs e)
		{
			ShiftCreatorForm employeeScedule = new ShiftCreatorForm();
			employeeScedule.Show();
			this.Hide();
		}

		private void lblCreateFeedingTimetable_Click(object sender, EventArgs e)
		{
			FeedingTimetableForm createFeedingTimetableForm = new FeedingTimetableForm(_accountTypes);
			createFeedingTimetableForm.Show();
			this.Hide();
		}

        private void lblREPORTS_Click(object sender, EventArgs e)
        {
			GeneralReport generalReport = new GeneralReport();
			generalReport.Show();
			this.Hide();
        }
    }
}
