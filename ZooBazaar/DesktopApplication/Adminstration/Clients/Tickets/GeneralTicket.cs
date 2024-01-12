using DesktopApplication.Adminstration.Employees;
using Logic.Classes;
using Logic.Classes.ContactForm;
using Logic.Classes.Ticket;
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

namespace DesktopApplication.Adminstration.Clients.Tickets
{
    public partial class GeneralTicket : Form
    {
        private AccountTypes _accountTypes;
        private DataTable dataTable;
        private DataView dataView;
        private ITicketManager ticketManager;

        public GeneralTicket()
        {
            InitializeComponent();

            ticketManager = new TicketManager(new Data.TicketDataManager());

            //Listview properties
            lvContactForms.View = View.Details;
            lvContactForms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Add columns
            lvContactForms.Columns.Add("Id", 50);
            lvContactForms.Columns.Add("Number of adults", 150);
            lvContactForms.Columns.Add("Number of children", 150);
            lvContactForms.Columns.Add("Date", 100);
            lvContactForms.Columns.Add("Email", 100);

            //Initialize dataTable and add columns
            dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Number of adults");
            dataTable.Columns.Add("Number of children");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Email");
        }

        private void PopulateListView(DataView dataView)
        {
            lvContactForms.Items.Clear();

            foreach (DataRow row in dataView.ToTable().Rows)
            {
                lvContactForms.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString() }));
            }
        }

        private void GeneralTicket_Load(object sender, EventArgs e)
        {
            dataTable.Clear();

            if (ticketManager != null)
            {
                foreach (Ticket ticket in ticketManager.GetTickets())
                {
                    dataTable.Rows.Add(ticket.Id, ticket.Adult, ticket.Children, ticket.Date, ticket.Email);
                }

                dataView = new DataView(dataTable);
                PopulateListView(dataView);
            }
        }

        private void GeneralTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            ALoginOptionsForm aLoginOptionsForm = new ALoginOptionsForm(_accountTypes);
            aLoginOptionsForm.SetClientButtons();
            aLoginOptionsForm.Show();
            this.Hide();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            dataView.RowFilter = String.Format("Email Like '%{0}%'", tbEmail.Text);
            PopulateListView(dataView);
        }
    }
}
