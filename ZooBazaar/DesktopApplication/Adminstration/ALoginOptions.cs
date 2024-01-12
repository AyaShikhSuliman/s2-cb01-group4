using DesktopApplication.Adminstration.Animals;
using DesktopApplication.Scheduler.Animals;
using Logic.Animals.Classes;
using Logic.Animals.Interfaces;
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
using DesktopApplication.Scheduler.Animals.FeedingTimetable;
using DesktopApplication.Adminstration.Clients.ContactForms;
using DesktopApplication.Adminstration.Clients.Tickets;

namespace DesktopApplication.Adminstration.Employees
{
    public partial class ALoginOptionsForm : Form
    {
        private AccountTypes _accountTypes;

        public ALoginOptionsForm(AccountTypes accountTypes)
        {
            InitializeComponent();

            btnAnimalGeneral.Visible = false;
            btnFeedingTimeTable.Visible = false;
            btnHealth.Visible = false;
            btnEmployeeGeneral.Visible = true;
            lblContactForms.Visible = false;
            lblTickets.Visible = false;

            _accountTypes = accountTypes;
        }
        public void SetEmployeeButtonBackgroundCoulour()
        {
            btnEmployees.BackColor = Color.Green;
        }

        public void SetAnimalButtons()
        {
            btnAnimalGeneral.Visible = true;
            btnFeedingTimeTable.Visible = true;
            btnHealth.Visible = true;

            btnAnimals.BackColor = Color.Green;
            btnEmployees.BackColor = Color.Brown;

            btnEmployeeGeneral.Visible = false;
            lblTickets.Visible = false;
        }

        public void SetEmployeeButtons()
        {
            btnAnimalGeneral.Visible = false;
            btnFeedingTimeTable.Visible = false;
            btnHealth.Visible = false;
            lblTickets.Visible = false;

            SetEmployeeButtonBackgroundCoulour();

            btnAnimals.BackColor = Color.Brown;

            btnEmployeeGeneral.Visible = true;
        }

        public void SetClientButtons()
        {
            lblContactForms.Visible = true;
            lblTickets.Visible = true;


            btnClients.BackColor = Color.Green;
            btnAnimals.BackColor = Color.Brown;
            btnEmployees.BackColor = Color.Brown;

            btnEmployeeGeneral.Visible = false;
            btnAnimalGeneral.Visible = false;
            btnFeedingTimeTable.Visible = false;
            btnHealth.Visible = false;
        }

        private void btnEmployeeGeneral_Click(object sender, EventArgs e)
        {
            EmployeeGeneralForm employeeGeneralForm = new EmployeeGeneralForm(_accountTypes);
            employeeGeneralForm.Show();
            this.Hide();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
            this.Hide();
        }

        private void AELoginOptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm login = new LoginForm(_accountTypes);
            login.Show();
            this.Hide();
        }

        private void btnAnimalGeneral_Click(object sender, EventArgs e)
        {
            AnimalGeneralForm animalGeneralForm = new AnimalGeneralForm(_accountTypes);
            animalGeneralForm.Show();
            this.Hide();
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            HealthForm healthForm = new HealthForm();
            healthForm.Show();
            this.Hide();
        }

        private void btnFeedingTimeTable_Click(object sender, EventArgs e)
        {
            FeedingTimetableForm feedingTimetableForm = new FeedingTimetableForm(_accountTypes);
            feedingTimetableForm.Show();
            this.Hide();
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            btnEmployeeGeneral.Visible = false;
            lblContactForms.Visible = false;

            btnAnimals.BackColor = Color.Green;
            btnEmployees.BackColor = Color.Brown;
            btnClients.BackColor = Color.Brown;

            btnAnimalGeneral.Visible = true;
            btnFeedingTimeTable.Visible = true;
            btnHealth.Visible = true;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            btnAnimalGeneral.Visible = false;
            btnFeedingTimeTable.Visible = false;
            btnHealth.Visible = false;
            lblContactForms.Visible = false;

            SetEmployeeButtonBackgroundCoulour();

            btnAnimals.BackColor = Color.Brown;
            btnClients.BackColor = Color.Brown;

            btnEmployeeGeneral.Visible = true;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            btnEmployeeGeneral.Visible = false;
            btnAnimalGeneral.Visible = false;
            btnFeedingTimeTable.Visible = false;
            btnHealth.Visible = false;

            btnClients.BackColor = Color.Green;
            btnAnimals.BackColor = Color.Brown;
            btnEmployees.BackColor = Color.Brown;

            lblContactForms.Visible = true;
            lblTickets.Visible = true;
        }

        private void lblContactForms_Click(object sender, EventArgs e)
        {
            ContactFormsForm contactFormsForm = new ContactFormsForm(_accountTypes);
            contactFormsForm.Show();
            this.Hide();
        }

        private void lblTickets_Click(object sender, EventArgs e)
        {
            GeneralTicket generalTicket = new GeneralTicket();
            generalTicket.Show();
            this.Hide();
        }
    }

}
