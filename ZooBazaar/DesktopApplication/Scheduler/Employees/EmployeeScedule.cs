using Logic.Classes.FeedingTime;
using Data;
using Logic.Enums;
using Logic.Interfaces;
using Logic.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Classes.Employees;
using DesktopApplication.Scheduler.Animals;
using Logic.Classes.Shift;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Data.data;

namespace DesktopApplication.Scheduler.Employees
{
    public partial class EmployeeScedule : Form
    {

        private IShiftManager shiftManager;
        private DataTable dataTable;
        private DataView dataView;
        private AccountTypes accountTypes;
        private List<ShiftType> shiftTypes;

        public EmployeeScedule()
        {
            InitializeComponent();

            shiftManager = new ShiftManager(new ShiftDataManager());
            shiftTypes = Enum.GetValues(typeof(ShiftType)).Cast<ShiftType>().ToList();
            dataTable = new DataTable();

            MakeTable();


        }
        private void PopulateListView(DataView dataView)
        {
            lvEmployeeSchdule.Items.Clear();

            foreach (DataRow row in dataView.ToTable().Rows)
            {
                lvEmployeeSchdule.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString(), row[11].ToString(), row[12].ToString(), row[13].ToString(), row[14].ToString(), }));
            }
        }
        public void MakeTheCoulmuns()
        {

            lvEmployeeSchdule.Columns.Add("Employee Name", 150);
            dataTable.Columns.Add("Employee Name");
            foreach (ShiftType shiftType in shiftTypes)
            {
                lvEmployeeSchdule.Columns.Add(shiftType.ToString(), 150);
                dataTable.Columns.Add(shiftType.ToString());
            }
        }
        public void MakeTable()
        {
            lvEmployeeSchdule.View = View.Details;
            lvEmployeeSchdule.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            MakeTheCoulmuns();

            List<Employee> NoDuplicate = shiftManager.GetAllEmployeeInfoNoDuplicateInShiftTable();

            for (int i = 0; i < NoDuplicate.Count; i++)
            {
                dataTable.Rows.Add(NoDuplicate[i].name);

            }

            foreach (var item in NoDuplicate)
            {
                Shift shift = shiftManager.GetShiftsByEmployeeId(item.id);
                for (int i = 0; i < shift.ShiftType.Count; i++)
                {
                    int index = shift.ShiftType[i] + 1;
                    dataTable.Rows[NoDuplicate.IndexOf(item)][index] = shift.Date[i].ToString();
                
                }
            }


            dataView = new DataView(dataTable);
            PopulateListView(dataView);



        }





        private void EmployeeScedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            SLoginOptionsForm sLoginOptionsForm = new SLoginOptionsForm(accountTypes);
			sLoginOptionsForm.SetEmployeeButtons();
			sLoginOptionsForm.Show();
            this.Hide();
        }
    }
}