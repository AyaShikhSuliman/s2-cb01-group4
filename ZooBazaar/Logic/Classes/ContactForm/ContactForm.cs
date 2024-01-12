using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.ContactForm
{
	public class ContactForm
	{
		public int Id { get; set; }
		public string Name { get; set; }	
		public string PhoneNumber { get; set; }	
		public string EmailAddress { get; set; }	
		public string Message { get; set; }	
		public string? Answer { get; set; }

		public ContactForm(int id, string name, string phoneNumber, string emailAddress, string message, string? answer)
		{
			Id = id;
			Name = name;
			PhoneNumber = phoneNumber;
			EmailAddress = emailAddress;
			Message = message;
			Answer = answer;
		}

		public ContactForm() { }

	}
}
