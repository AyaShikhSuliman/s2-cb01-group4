using Data.data;
using Logic.Classes.Shift;
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

namespace DesktopApplication.Scheduler.Employees
{
    
    public partial class ExtraInfo : Form
    {
        IShiftManager shiftManager;
        public ExtraInfo()
        {
            InitializeComponent();
            shiftManager = new ShiftManager(new ShiftDataManager());
            if (cbOptions.Text == "")
            {
                lbInfo.Items.Clear();
                shiftManager.GetAllVacations().ToList().ForEach(r => lbInfo.Items.Add(r));
                shiftManager.GetAllWorkPrefrences().ToList().ForEach(r => lbInfo.Items.Add(r));
            }
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (cbOptions.SelectedItem.ToString() == "Preference day")
            {
                lbInfo.Items.Clear();
                shiftManager.GetAllWorkPrefrences().ToList().ForEach(r => lbInfo.Items.Add(r));
            }
            else if (cbOptions.SelectedItem.ToString()=="Vacation")
            {
                lbInfo.Items.Clear();
                shiftManager.GetAllVacations().ToList().ForEach(r => lbInfo.Items.Add(r));

            }
        }

        private void ExtraInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShiftCreatorForm shiftCreatorForm = new ShiftCreatorForm();
            shiftCreatorForm.Show();
            this.Hide();
        }
    }
}
