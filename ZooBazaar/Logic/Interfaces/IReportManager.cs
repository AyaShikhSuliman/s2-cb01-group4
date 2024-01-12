using Logic.Animals.Classes;
using Logic.Classes.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IReportManager
    {
        void AddReport(Report report, Animal animal);
        void RemoveReport(Report report);
        List<Report> GetReports();
        void EditReport(Report report);
    }
}
