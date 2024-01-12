using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApplication.Adminstration.Employees;
using DesktopApplication.Scheduler.Animals.FeedingTimetable;
using Logic.Animals.Classes;
using Logic.Classes.FeedingTime;
using Data;
using Logic.Enums;
using Logic.Interfaces;
using DesktopApplication.Scheduler.FeedingTimeTable;

namespace DesktopApplication.Scheduler.Animals
{
	public partial class FeedingTimetableForm : Form
	{
		private DataTable dataTable;
		private DataView dataView;
		private IFeedingTimesManager feedingTimesManager;
		private AccountTypes _accountTypes;

		public FeedingTimetableForm(AccountTypes accountTypes)
		{
			InitializeComponent();

			feedingTimesManager = new FeedingTimesManager(new FeedingTimeDataManager());

			//Listview properties
			lvFeedingTimetable.View = View.Details;
			lvFeedingTimetable.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

			//Add columns
			lvFeedingTimetable.Columns.Add("Time", 50);
			lvFeedingTimetable.Columns.Add("Animal Type", 100);
			lvFeedingTimetable.Columns.Add("Food Type", 100);
			lvFeedingTimetable.Columns.Add("Amount of Food in grams", 200);
			lvFeedingTimetable.Columns.Add("Amount of Animal", 150);
			lvFeedingTimetable.Columns.Add("Estimated time in minutes", 200);


			//Initialize dataTable and add columns
			dataTable = new DataTable();
			dataTable.Columns.Add("Time");
			dataTable.Columns.Add("Animal Type");
			dataTable.Columns.Add("Food Type");
			dataTable.Columns.Add("Amount of Food in grams");
			dataTable.Columns.Add("Amount of Animal");
			dataTable.Columns.Add("Estimated time in minutes");

			_accountTypes = accountTypes;

			if (_accountTypes == AccountTypes.Scheduler)
			{
				btnAdd.Visible = true;
				btnDelete.Visible = true;
				return;
			}
			else if (_accountTypes == AccountTypes.Admin)
			{
				btnAdd.Visible = false;
				btnDelete.Visible = false;
				return;
			}
		}

		private void PopulateListView(DataView dataView)
		{
			lvFeedingTimetable.Items.Clear();

			foreach (DataRow row in dataView.ToTable().Rows)
			{
				lvFeedingTimetable.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString() }));
			}
		}

		private void CreateFeedingTimetableForm_FormClosing(object sender, FormClosingEventArgs e)
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

		private void FeedingTimetableForm_Load(object sender, EventArgs e)
		{
			dataTable.Clear();
			if (feedingTimesManager != null)
			{
				foreach (FeedingTime feedingTime in feedingTimesManager.ShowAllFeedingTimes())
				{
					dataTable.Rows.Add(feedingTime.TimesToBeFeed, feedingTime.animalType, feedingTime.animalFoodType, feedingTime.animalAmountOfFood, feedingTimesManager.ReturnAmountOfChosenAnimalType(feedingTime.animalType).ToString(), feedingTimesManager.ReturnNeededTime(feedingTime.animalType.ToString(), feedingTime.animalType));
				}

				dataView = new DataView(dataTable);
				PopulateListView(dataView);
			}
		}

        private void button2_Click(object sender, EventArgs e)
        {
            AddFeedingTimeForm addFeedingTimeForm = new AddFeedingTimeForm(_accountTypes);
            addFeedingTimeForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in feedingTimesManager.ShowAllFeedingTimes())
            {
                if (lvFeedingTimetable.SelectedItems.Count > 0)
                {
                    var confirmation = MessageBox.Show("Are you sure you want to delete the feeding time?",
                        "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        for (int i = lvFeedingTimetable.SelectedItems.Count - 1; i >= 0; i--)
                        {
                            ListViewItem listViewItem = lvFeedingTimetable.SelectedItems[i];
                            lvFeedingTimetable.Items[listViewItem.Index].Remove();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select a feeding time first!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                feedingTimesManager.RemoveFeedingTime(item);
                break;
            }
        }

		private void btnAssignEmployee_Click(object sender, EventArgs e)
		{
            foreach (var item in feedingTimesManager.ShowAllFeedingTimes())
            {
                if (lvFeedingTimetable.SelectedItems.Count > 0)
                {
					AssignedEmployee assignedEmployee = new AssignedEmployee();
					assignedEmployee.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Select a feeding time first!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                
                break;
            }
        }
	}
}
