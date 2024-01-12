using DesktopApplication.Adminstration.Employees;
using DesktopApplication.CommonForms.Animals;
using Logic.Animals.Classes;
using Logic.Classes.ContactForm;
using Data; 
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

namespace DesktopApplication.Adminstration.Clients.ContactForms
{
	public partial class ContactFormsForm : Form
	{
		private AccountTypes _accountTypes;
		private DataTable dataTable;
		private DataView dataView;
		private IContactFormManager contactFormManager;
		private ContactForm selectedContactFormFromLV;


		public ContactFormsForm(AccountTypes accountTypes)
		{
			InitializeComponent();

			_accountTypes = accountTypes;

			contactFormManager = new ContactFormManager(new ContactFormDataManager());

			//Listview properties
			lvContactForms.View = View.Details;
			lvContactForms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

			//Add columns
			lvContactForms.Columns.Add("Id", 50);
			lvContactForms.Columns.Add("Name", 100);
			lvContactForms.Columns.Add("Phone Number", 150);
			lvContactForms.Columns.Add("Email Address", 150);
			lvContactForms.Columns.Add("Message", 100);
			lvContactForms.Columns.Add("Answer", 100);

			//Initialize dataTable and add columns
			dataTable = new DataTable();
			dataTable.Columns.Add("Id");
			dataTable.Columns.Add("Name");
			dataTable.Columns.Add("Phone Number");
			dataTable.Columns.Add("Email Address");
			dataTable.Columns.Add("Message");
			dataTable.Columns.Add("Answer");
		}

		private void PopulateListView(DataView dataView)
		{
			lvContactForms.Items.Clear();

			foreach (DataRow row in dataView.ToTable().Rows)
			{
				lvContactForms.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString() }));
			}
		}

		private void ContactFormsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			ALoginOptionsForm aLoginOptionsForm = new ALoginOptionsForm(_accountTypes);
			aLoginOptionsForm.SetClientButtons();
			aLoginOptionsForm.Show();
			this.Hide();
		}

		private void ContactFormsForm_Load(object sender, EventArgs e)
		{
			dataTable.Clear();

			if (contactFormManager != null)
			{
				foreach (ContactForm contactForm in contactFormManager.GetAllContacts())
				{
					dataTable.Rows.Add(contactForm.Id, contactForm.Name, contactForm.PhoneNumber, contactForm.EmailAddress, contactForm.Message, contactForm.Answer);
				}

				dataView = new DataView(dataTable);
				PopulateListView(dataView);
			}
		}

		private void lvContactForms_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvContactForms.SelectedItems.Count == 0) return;

			ListViewItem item = lvContactForms.SelectedItems[0];
			int id = int.Parse(item.SubItems[0].Text);

			ContactForm contactForm = contactFormManager.GetContactFormById(id);
			this.selectedContactFormFromLV = contactForm;
		}

		private void btnAnswer_Click(object sender, EventArgs e)
		{
			if (this.selectedContactFormFromLV != null)
			{
				ContactForm contactForm = this.selectedContactFormFromLV;
				AnswerContacFormMessage answerContacFormMessage = new AnswerContacFormMessage(contactForm);
				answerContacFormMessage.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Nothing Selected");
			}
		}
	}
}
