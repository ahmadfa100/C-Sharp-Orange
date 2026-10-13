using System;

namespace Task4_OOP2;

public sealed class SchoolReport
{
    public string ReportTitle{get;set;}


    public SchoolReport(string title)
    {
        ReportTitle = title;
    }
    public void DisplayReportTitle()
    {
        Console.WriteLine($"Report Title : {ReportTitle}");
    }
}
// there is no inheritance for this class, because it is sealed.