using Logic.DalInterfaces;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Report
{
    public class ReportManager: IReportManager
    {
        private IReportDataManager reportDataManager;

        public ReportManager(IReportDataManager reportDataManager)
        {
            this.reportDataManager = reportDataManager;
        }

        public void AddReport(Report report, Animals.Classes.Animal animal)
        {
            reportDataManager.CreateReport(report, animal);
        }

        public void EditReport(Report report)
        {
            reportDataManager.UpdateReport(report);
        }

        public List<Report> GetReports()
        {
            return reportDataManager.ReadReports();
        }

        public void RemoveReport(Report report)
        {
            reportDataManager.DeleteReport(report);
        }
    }
}
