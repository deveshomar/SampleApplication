using SampleApplication.InterfaceWithDI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.InterfaceWithDI
{

    // SOILD PRINCPAL
    // S - Single Responsibility Principle
    // O - Open/Closed Principle
    // L - Liskov Substitution Principle
    // I - Interface Segregation Principle
    // D - Dependency Inversion Principle   

    public class  ReportGenerationFactory
    {
        ReportGenerationFactory()
        {

        }

        // if Ireport not impelmented by any class then it will throw error
        public static WordReport CreateReportWord(string type, string title)
        {
            return new WordReport(title);
        }
        public static ExcelReport CreateReportExcel(string type, string title)
        {
            return new ExcelReport(title);
        }
        public static PdfReport CreateReportPdf(string type, string title)
        {
            return new PdfReport(title);
        }


        public static IReport CreateReport(string type, string title)
        {
            if (type.Equals("Word", StringComparison.OrdinalIgnoreCase))
            {
                return new WordReport(title);
            }
            else if (type.Equals("PDF", StringComparison.OrdinalIgnoreCase))
            {
                return new PdfReport(title);
            }
            else if (type.Equals("EXCEL", StringComparison.OrdinalIgnoreCase))
            {
                return new ExcelReport(title);
            }
            else if (type.Equals("HTML", StringComparison.OrdinalIgnoreCase))
            {
                return new HTMLReport(title);
            }
            else
            {
                throw new ArgumentException("Invalid report type");
            }
        }

    }


    public interface IReport
    {
        string Title { get; }
        void Generate();
    }


    public class WordReport : IReport
    {
        public string Title { get; private set; }

        public WordReport(string title)
        {
            Title = title;
        }

        public void Generate()
        {
            //logic
             Console.WriteLine($"Generating Word Report: {Title}");       
            // throw new NotImplementedException();
        }

       
    }

    public class PdfReport : IReport
    {
        public string Title { get; private set; }

        public PdfReport(string title)
        {
            Title = title;
        }

        public void Generate()
        {//  loggic
            Console.WriteLine($"Generating PDF Report: {Title}");
        }
    }

    public class HTMLReport : IReport
    {
        public string Title { get; private set; }

        public HTMLReport(string title)
        {
            Title = title;
        }

        public void Generate()
        {
            //logic
            Console.WriteLine($"Generating HTMLReport Report: {Title}");
        }
    }


    public class ExcelReport  : IReport
    {
        public string Title { get; private set; }

        public ExcelReport(string title)
        {
            Title = title;
        }

        public void Generate()
        {
            Console.WriteLine($"Generating ExcelReport Report: {Title}");
        }
    }

    internal class InterafaceWithChild
    {
    }
}

public static class ReportService
{
    public static void PrintReport(IReport report)
    {
        Console.WriteLine($"[INFO] Starting report generation...");
        report.Generate();
        Console.WriteLine($"[INFO] Report generated: {report.Title}\n");
    }
}

 /*
IReport pdf = new PdfReport("Monthly Sales");
        IReport word = new WordReport("Employee Summary");

        ReportService.PrintReport(pdf);
        ReportService.PrintReport(word); 
 */