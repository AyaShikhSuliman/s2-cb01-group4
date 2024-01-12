using Logic.Animals.Classes;
using Logic.DalInterfaces;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.ContactForm
{
	public class ContactFormManager : IContactFormManager
	{
		private IContactFormDataManager contactFormDataManager;

		public ContactFormManager(IContactFormDataManager contactFormDataManager)
		{
			this.contactFormDataManager = contactFormDataManager;
		}

		public void AnswerMessage(ContactForm contactForm)
		{
			contactFormDataManager.UpdateContactForm(contactForm);
		}

		public List<ContactForm> GetAllContacts()
		{
			return contactFormDataManager.ReadContacts();
		}

		public void SendMessage(ContactForm contactForm)
		{
			contactFormDataManager.CreateContactForm(contactForm);
		}

		public ContactForm GetContactFormById(int id)
		{
			ContactForm contactForm = contactFormDataManager.GetContactForm(id);

			if (contactForm.Id != 0)
			{
				return contactForm;
			}
			return new();
		}

	}
}
