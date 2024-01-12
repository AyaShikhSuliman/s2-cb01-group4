using Logic.Classes.ContactForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
	public interface IContactFormManager
	{
		void SendMessage(ContactForm contactForm);
		void AnswerMessage(ContactForm contactForm);
		List<ContactForm> GetAllContacts();
		ContactForm GetContactFormById(int id);
	}
}
