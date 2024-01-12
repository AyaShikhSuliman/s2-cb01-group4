using Logic.Classes.ContactForm;
using Data;
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
	public partial class AnswerContacFormMessage : Form
	{
		private ContactForm ContactForm { get; set; }
		private IContactFormManager ContactFormManager;
		
		public AnswerContacFormMessage(ContactForm ContactForm)
		{
			InitializeComponent();

			tbConfirmation1.Visible = false;

			ContactFormManager = new ContactFormManager(new ContactFormDataManager());
			this.ContactForm = ContactForm;

			tbId.Text = ContactForm.Id.ToString();
			tbName.Text = ContactForm.Name.ToString();
			tbPhoneNumber.Text = ContactForm.PhoneNumber.ToString();
			tbEmailAddress.Text = ContactForm.EmailAddress.ToString();
			tbMessage.Text = ContactForm.Message.ToString();
			tbAnswer.Text = ContactForm.Answer.ToString();
		}

		private void btnAnswer_Click(object sender, EventArgs e)
		{
			ContactForm.Name= tbName.Text;
			ContactForm.PhoneNumber= tbPhoneNumber.Text;
			ContactForm.EmailAddress= tbEmailAddress.Text;
			ContactForm.Message= tbMessage.Text;
			ContactForm.Answer= tbAnswer.Text;

			ContactFormManager.AnswerMessage(ContactForm);

			tbConfirmation1.Visible = true;
			this.timer1.Enabled = true;
			this.timer1.Interval = 1500;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

			tbName.Text = "";
			tbPhoneNumber.Text = "";
			tbEmailAddress.Text = "";
			tbMessage.Text = "";
			tbAnswer.Text = "";
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			tbConfirmation1.Visible = false;
		}

		private void AnswerContacFormMessage_FormClosing(object sender, FormClosingEventArgs e)
		{
			ContactFormsForm contactFormsForm = new ContactFormsForm(new Logic.Enums.AccountTypes());
			contactFormsForm.Show();
			this.Hide();
		}
	}
}
