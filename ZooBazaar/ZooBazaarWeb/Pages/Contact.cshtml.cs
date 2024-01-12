using Logic.Classes.ContactForm;
using Logic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZooBazaarWeb.Pages
{
	public class ContactModel : PageModel
	{
		[BindProperty]
		public ContactForm contactForm { get; set; }
		private IContactFormManager contactFormManager;
		public string HelloMessage { get; private set; }

		public void OnPost()
		{

			contactFormManager = new ContactFormManager(new Data.ContactFormDataManager());
			contactFormManager.SendMessage(contactForm);

			HelloMessage = $"Hello {contactForm.Name}, thank you for contacting us!" +
				$" We will respond within 2 working days to {contactForm.EmailAddress}";

			contactForm.Name = "";
			contactForm.PhoneNumber = "";
			contactForm.EmailAddress = "";
			contactForm.Message = "";
		}
	}
}
