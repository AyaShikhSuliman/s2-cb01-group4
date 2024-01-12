using Logic.Animals.Classes;
using Logic.Classes.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DalInterfaces
{
    public interface IReportDataManager
    {
        void CreateReport(Report report, Animal animal);
        void DeleteReport(Report report);
        List<Report> ReadReports();
        void UpdateReport(Report report);
    }
}
