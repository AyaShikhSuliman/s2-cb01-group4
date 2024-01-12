using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Ticket
{
    public class Ticket
    {
        public int Id { get; set; }
        public int Adult { get; set; }
        public int Children { get; set; }
        [Required]
        public DateTime Date = DateTime.Now;
        [Required]
        public string Email { get; set; }

        public Ticket(int id, int adult, int children, DateTime date, string email)
        {
            Id = id;
            Adult = adult;
            Children = children;
            Date = date;
            Email = email;
        }

        public Ticket() { }
    }
}
