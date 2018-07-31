using System;

namespace BuilderPattern
{
    public class ReportBuilder
    {
        private Report CreateTaxReport(DateTime from, DateTime to)
        {
            return new Report(from, to, false, true, Report.SortingMethod.ByTaxCategory);
        }

        public Report CreateMonthTaxReport(int month, int year)
        {
            return CreateTaxReport(new DateTime(year, month, 1),
                new DateTime(year, month, 1).AddMonths(1).AddSeconds(-1));
        }

        public Report CreateYearTaxReport(int year)
        {
            return CreateTaxReport(new DateTime(year, 1, 1),
                new DateTime(year, 12, 31));
        }

        private Report CreateCommissionReport(DateTime from, DateTime to)
        {
            return new Report(from, to, false, false, Report.SortingMethod.BySalesperson);
        }

        public Report CreateMonthCommissionReport(int month, int year)
        {
            return CreateCommissionReport(new DateTime(year, month, 1),
                new DateTime(year, month, 1).AddMonths(1).AddSeconds(-1));
        }

        public Report CreateYearCommissionReport(int year)
        {
            return CreateCommissionReport(new DateTime(year, 1, 1),
                new DateTime(year, 12, 31));
        }
    }
}