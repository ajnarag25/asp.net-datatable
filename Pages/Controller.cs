using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
namespace Crud_Web_App.Pages;

public class IndexModel : PageModel
{
    public IActionResult Index()
    {
        // Create a list of data rows
        List<string[]> dataRows1 = new List<string[]>();
        dataRows1.Add(new string[] { "Michael Suarez Rilan", "Senior Developer", "0002", "2008 / 12 / 08", "Php 120,050" });
        dataRows1.Add(new string[] { "Alliah Faith Nazaire", "Js Developer", "0002", "2009 / 10 /05 ", "Php 102,010 " });
        dataRows1.Add(new string[] { "Kyle Nicole Taccad", "Back - end Developer", "1102", "2012 / 25 / 10 ", "Php 110,250" });
        dataRows1.Add(new string[] { "Vanessa Tulabot", "Software Engineer", "3202", "2013 / 05 / 02", "Php 120,200 " });
        dataRows1.Add(new string[] { "Mary Chris Jasa", "Marketing Designer", "1032", "2012 / 22 / 10", "Php 110,200" });


        List<string[]> dataRows2 = new List<string[]>();
        dataRows2.Add(new string[] { "Michael Suarez Rilan", "Senior Developer", "0002", "2008 / 12 / 08", "Php 120,050" });
        dataRows2.Add(new string[] { "Alliah Faith Nazaire", "Js Developer", "0002", "2009 / 10 /05 ", "Php 102,010 " });
        dataRows2.Add(new string[] { "Kyle Nicole Taccad", "Back - end Developer", "1102", "2012 / 25 / 10 ", "Php 110,250" });
        dataRows2.Add(new string[] { "Vanessa Tulabot", "Software Engineer", "3202", "2013 / 05 / 02", "Php 120,200 " });
        dataRows2.Add(new string[] { "Mary Chris Jasa", "Marketing Designer", "1032", "2012 / 22 / 10", "Php 110,200" });

        // Create a data table
        System.Data.DataTable dataTable = new System.Data.DataTable();
        dataTable.Columns.Add("Name", typeof(int));
        dataTable.Columns.Add("Office", typeof(string));
        dataTable.Columns.Add("Extn.", typeof(string));
        dataTable.Columns.Add("Startdate", typeof(string));
        dataTable.Columns.Add("Salary", typeof(string));

        // Add data rows to the data table
        foreach (string[] row1 in dataRows1)
        {
            dataTable.Rows.Add(row1);
        }
        foreach (string[] row2 in dataRows2)
        {
            dataTable.Rows.Add(row2);
        }

        // Pass the data table to the view
        ViewData["DataTable1"] = dataTable;
        ViewData["DataTable2"] = dataTable;

        return Index();
    }
}
