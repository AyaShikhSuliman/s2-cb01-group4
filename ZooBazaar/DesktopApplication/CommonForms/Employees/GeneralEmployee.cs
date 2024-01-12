using DesktopApplication.Adminstration.Employees;
using Logic.Animals.Classes;
using Logic.Classes.Accounts;
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
using Logic.Enums;
using Data; 
using Logic.Classes.Employees;
using DesktopApplication.Scheduler.Animals;

namespace DesktopApplication.Adminstration
{
	public partial class EmployeeGeneralForm : Form
	{
		private DataTable dataTable;
		private DataView dataView;
		private Employee SelectedEmployee;
		private IEmployeeManager managerDB;
		private AccountTypes _accountTypes;

		public EmployeeGeneralForm(AccountTypes accountTypes)
		{
			InitializeComponent();

			managerDB = new EmployeeManager(new EmployeeDataManager());
			_accountTypes = accountTypes;

			//Listview properties
			lvEmployees.View = View.Details;
			lvEmployees.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

			//Add columns
			lvEmployees.Columns.Add("Id", 50);
			lvEmployees.Columns.Add("Name", 80);
			lvEmployees.Columns.Add("Age", 50);
			lvEmployees.Columns.Add("Email", 100);
			lvEmployees.Columns.Add("Gender", 70);
			lvEmployees.Columns.Add("Phone", 100);
			lvEmployees.Columns.Add("Password", 100);
			lvEmployees.Columns.Add("Role", 120);

			//Initialize dataTable and add columns
			dataTable = new DataTable();
			dataTable.Columns.Add("Id");
			dataTable.Columns.Add("Name");
			dataTable.Columns.Add("Age");
			dataTable.Columns.Add("Email");
			dataTable.Columns.Add("Gender");
			dataTable.Columns.Add("Phone");
			dataTable.Columns.Add("Password");
			dataTable.Columns.Add("Role");

			if (_accountTypes == AccountTypes.Scheduler)
			{
				btnPromote.Visible = false;
				btnRemove.Visible = false;
				btnEdit.Visible = false;
				return;

			}
			else if (_accountTypes == AccountTypes.Admin)
			{
				btnPromote.Visible = true;
				btnRemove.Visible = true;
				btnEdit.Visible = true;
				return;
			}
		}

		private void PopulateListView(DataView dataView)
		{
			lvEmployees.Items.Clear();

			foreach (DataRow row in dataView.ToTable().Rows)
			{
				lvEmployees.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString() }));
			}
		}

		private void btnShowAll_Click(object sender, EventArgs e)
		{
			dataTable.Clear();

			for (int i = 0; i < managerDB.ShowAll().Count; i++)
			{
				dataTable.Rows.Add(managerDB.ShowAll()[i].id, managerDB.ShowAll()[i].name, managerDB.ShowAll()[i].age,
					managerDB.ShowAll()[i].email, managerDB.ShowAll()[i].gender, managerDB.ShowAll()[i].phoneNumber,
					managerDB.ShowAll()[i].password, managerDB.ShowAll()[i].position);
			}

			dataView = new DataView(dataTable);
			PopulateListView(dataView);

			lbInfo.Items.Clear();
			if (managerDB != null)
			{
				if (managerDB.ShowAll() != null)
				{
					managerDB.ShowAll().ToList().ForEach(r => lbInfo.Items.Add(r));
				}
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (managerDB != null)
			{

				if (lvEmployees.SelectedItems.Count > 0)
				{
					var confirmation = MessageBox.Show($"Are you sure you want to delete this Employee?",
						"Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (confirmation == DialogResult.Yes)
					{
						if (lvEmployees.SelectedItems.Count == 0) return;
						ListViewItem item = lvEmployees.SelectedItems[0];
						int id = int.Parse(item.SubItems[0].Text);
						Employee employee = managerDB.GetEmployeeById(id);
						managerDB.RemoveEmployee(employee);

						for (int i = lvEmployees.SelectedItems.Count - 1; i >= 0; i--)
						{
							ListViewItem listViewItem = lvEmployees.SelectedItems[i];
							lvEmployees.Items[listViewItem.Index].Remove();

						}


					}

				}
				else
				{
					MessageBox.Show("Select an employee first!", "Error",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void EmployeeGeneralForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_accountTypes == AccountTypes.Scheduler)
			{
				SLoginOptionsForm sLoginOptionsForm = new SLoginOptionsForm(_accountTypes);
				sLoginOptionsForm.SetEmployeeButtons();
				sLoginOptionsForm.Show();
				this.Hide();
				return;
			}
			else if (_accountTypes == AccountTypes.Admin)
			{
				ALoginOptionsForm aloginOptionsForm = new ALoginOptionsForm(_accountTypes);
				aloginOptionsForm.SetEmployeeButtons();
				aloginOptionsForm.Show();
				this.Hide();
				return;
			}
		}

		private void btnPromote_Click(object sender, EventArgs e)
		{
			if (lvEmployees.SelectedItems.Count == 0) return;
			ListViewItem item = lvEmployees.SelectedItems[0];
			int id = int.Parse(item.SubItems[0].Text);
			Employee employee = managerDB.GetEmployeeById(id);

			managerDB.PromoteEmployee(employee);

			managerDB.ShowAll().ToList().ForEach(r => lbInfo.Items.Add(r));

			MessageBox.Show("Employee is promoted");
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{

			if (this.SelectedEmployee != null)
			{
				Employee employee = this.SelectedEmployee;
				UpdateEmployee updateForm = new UpdateEmployee(employee);
				updateForm.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Nothing Selected");
			}
		}

		private void EmployeeGeneralForm_Load(object sender, EventArgs e)
		{
			dataTable.Clear();
			if (managerDB != null)
			{
				foreach (Employee emp in managerDB.ShowAll())
				{
					dataTable.Rows.Add(emp.id, emp.name, emp.age, emp.email, emp.gender.ToString(), emp.phoneNumber, emp.password, emp.position.ToString());
				}

				dataView = new DataView(dataTable);
				PopulateListView(dataView);
			}

		}

		private void tbID_TextChanged(object sender, EventArgs e)
		{
			dataView.RowFilter = String.Format("Id Like '%{0}%'", tbID.Text);
			PopulateListView(dataView);
		}

		private void tbName_TextChanged(object sender, EventArgs e)
		{
			dataView.RowFilter = String.Format("Name Like '%{0}%'", tbName.Text);
			PopulateListView(dataView);
		}

		private void tbEmail_TextChanged(object sender, EventArgs e)
		{
			dataView.RowFilter = String.Format("Email Like '%{0}%'", tbEmail.Text);
			PopulateListView(dataView);
		}

		private void lvEmployees_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvEmployees.SelectedItems.Count == 0) return;
			ListViewItem item = lvEmployees.SelectedItems[0];
			int id = int.Parse(item.SubItems[0].Text);
			Employee employee = managerDB.GetEmployeeById(id);
			this.SelectedEmployee = employee;
		}

        private void lblAdd_Click(object sender, EventArgs e)
        {
			AddForm addForm = new AddForm();
			addForm.Show();
			this.Hide();
        }
    }
}
