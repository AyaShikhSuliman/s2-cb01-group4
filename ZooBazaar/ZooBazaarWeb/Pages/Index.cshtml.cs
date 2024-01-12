using Data;
using Logic.Classes;
using Logic.Classes.Ticket;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZooBazaarWeb.Pages
{
    public class IndexModel : PageModel
    {
        ITicketManager ticketManager = new TicketManager(new TicketDataManager());
        public ICommentManager commentManager = new CommentManager(new CommentDataManager());
        [BindProperty]
        public Ticket Ticket { get; set; }
        [BindProperty]
        public string Comment { get; set; }

        public void OnGet()
        {

        }
        public IActionResult OnPostTicket()
        {
            ModelState.Remove("comment");
            if (ModelState.IsValid)
            {
                ticketManager.AddTicket(Ticket);
                TempData["Alert"] = "Success";
                return Page();
            }
            return Page();
        }
        public void OnPostComment()
        {
            if (!string.IsNullOrEmpty(Comment))
            {
                commentManager.AddComment(Comment);
                Response.Redirect("Index");
            }
        }
    }
}