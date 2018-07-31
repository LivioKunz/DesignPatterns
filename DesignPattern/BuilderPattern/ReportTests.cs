using System;
using Xunit;

namespace BuilderPattern
{
    public class ReportTests
    {
        [Fact]
        public void Test_BuildReports()
        {
            DateTime now = DateTime.Now;


            Report currentMonthTaxReport =
                new Report(new DateTime(now.Year, now.Month, 1),
                    new DateTime(now.Year, now.Month, 1).AddMonths(1).AddSeconds(-1),
                    false, true, Report.SortingMethod.ByTaxCategory);


            Report currentYearTaxReport =
                new Report(new DateTime(now.Year, 1, 1),
                    new DateTime(now.Year, 12, 31),
                    false, true, Report.SortingMethod.ByTaxCategory);


            Report currentMonthCommissionReport =
                new Report(new DateTime(now.Year, now.Month, 1),
                    new DateTime(now.Year, now.Month, 1).AddMonths(1).AddSeconds(-1),
                    false, false, Report.SortingMethod.BySalesperson);

            Report currentYearCommissionReport =
                new Report(new DateTime(now.Year, 1, 1),
                    new DateTime(now.Year, 12, 31),
                    false, false, Report.SortingMethod.BySalesperson);
        }

        [Fact]
        public void Test_BuildReports_WithBuilderPattern()
        {
            ReportBuilder reportBuilder = new ReportBuilder();

            Report currentMonthTaxReport =
                reportBuilder.CreateMonthTaxReport(4, 2017);

            Report currentYearTaxReport =
                reportBuilder.CreateYearTaxReport(2017);

            Report currentMonthCommissionReport =
                reportBuilder.CreateMonthCommissionReport(4, 2017);

            Report currentYearCommissionReport =
                reportBuilder.CreateYearCommissionReport(2017);
        }
    }
}