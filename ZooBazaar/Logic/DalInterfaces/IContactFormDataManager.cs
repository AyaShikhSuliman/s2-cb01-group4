using Logic.Classes.ContactForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DalInterfaces
{
	public interface IContactFormDataManager
	{
		void UpdateContactForm(ContactForm contactForm);
		void CreateContactForm(ContactForm contactForm);
		List<ContactForm> ReadContacts();
		ContactForm GetContactForm(int id);
	}
}
