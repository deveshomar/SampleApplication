using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.InterfaceWithDI
{

    //
    // IReportData ireport = new ExcelReportData();
    // ireport.GetReportData();

    public interface IReportData
    {
        void GetReportData();
    }

    public class ExcelReportData : IReportData
    {
        public void GetReportData()
        {
            Console.WriteLine("Excel reprot ");
        }
    }

    public class PDFReportData : IReportData
    {
        public void GetReportData()
        { // logic
            Console.WriteLine("PDF reprot ");
        }
    }

    public class HTMLReportData : IReportData
    {
        public void GetReportData()
        { // logic
            Console.WriteLine("HTML reprot ");
        }
    }

    /// <summary>
    /// loose coupling 
    /// </summary>
    public class ExecuteReport
    {
       public  IReportData ireport;
       public ExecuteReport(IReportData reportData)
        {
            ireport = reportData;
        }

        public void PrintReport()
        {
            ireport.GetReportData();
            //achieved loose coupling
        }

        public void PDFReport()
        { 
            //tight coupling
            PDFReportData obj = new PDFReportData();
            obj.GetReportData();
        }
        public void ExcelReport()
        {    //tight coupling
            ExcelReportData obj = new ExcelReportData();
            obj.GetReportData();
        }
    }

    public class GetReportFactory
    {
        public static IReportData GetObject(string type)
        {
            if(type=="PDF")
            {
                return new PDFReportData();
            }
            if (type == "Excel")
            {
                return new ExcelReportData();
            }

            return null;
        }
    }
}
/*
 
 
/*
IReportData ireport = new ExcelReportData();
ireport.GetReportData();

ireport = new PDFReportData();
ireport.GetReportData();


IReportData ireport = new ExcelReportData();
ExecuteReport objexcute = new ExecuteReport(ireport);
objexcute.PrintReport();



IReportData ireport1 = new PDFReportData();
ExecuteReport objexcute1 = new ExecuteReport(ireport1);
objexcute1.PrintReport();

//factory pattern
IReportData objreportData = GetReportFactory.GetObject("PDF");
objreportData.GetReportData();
*/ 