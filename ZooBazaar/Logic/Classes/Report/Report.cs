using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Report
{
    public class Report
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Report() { }

        public Report(int id, int animalId, DateTime date, string description)
        {
            Id = id;
            AnimalId = animalId;
            Date = date;
            Description = description;
        }
    }
}
