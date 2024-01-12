using Data;
using DesktopApplication.Scheduler.Animals;
using Logic.Animals.Classes;
using Logic.Classes.Report;
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

namespace DesktopApplication.Scheduler.Animal
{
    public partial class GeneralReport : Form
    {
        private DataTable dataTable;
        private DataView dataView;
        private IReportManager reportManager;
        private AccountTypes accountTypes;

        public GeneralReport()
        {
            InitializeComponent();

            reportManager = new ReportManager(new ReportDataManager());

            //Listview properties
            lvReports.View = View.Details;
            lvReports.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Add columns
            lvReports.Columns.Add("Id", 50);
            lvReports.Columns.Add("Animal Id", 100);
            lvReports.Columns.Add("Date", 100);
            lvReports.Columns.Add("Description", 200);

            //Initialize dataTable and add columns
            dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Animal Id");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Description");
        }

        private void PopulateListView(DataView dataView)
        {
            lvReports.Items.Clear();

            foreach (DataRow row in dataView.ToTable().Rows)
            {
                lvReports.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString() }));
            }
        }

        private void GeneralReport_Load(object sender, EventArgs e)
        {
            dataTable.Clear();

            if (reportManager != null)
            {
                foreach (Report report in reportManager.GetReports())
                {
                    dataTable.Rows.Add(report.Id, report.AnimalId, report.Date, report.Description);
                }

                dataView = new DataView(dataTable);
                PopulateListView(dataView);
            }
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            dataView.RowFilter = String.Format("Id Like '%{0}%'", tbId.Text);
            PopulateListView(dataView);
        }

        private void GeneralReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            SLoginOptionsForm sLoginOptionsForm = new SLoginOptionsForm(accountTypes);
            sLoginOptionsForm.SetAnimalButtons();
            sLoginOptionsForm.Show();
            this.Hide();
            return;
        }
    }
}
