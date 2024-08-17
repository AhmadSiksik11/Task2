using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ExcelUploadApp.Controllers
{
    public class ConvertController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormFile file, string tableName)
        {
            if (file == null || file.Length == 0)
            {
                ViewBag.Message = "Please select a valid Excel file.";
                return View();
            }

            if (string.IsNullOrEmpty(tableName))
            {
                ViewBag.Message = "Please enter a valid table name.";
                return View();
            }

            List<List<string>> data = new List<List<string>>();
            StringBuilder sqlStatements = new StringBuilder();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; 

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;

                    
                    List<string> columnNames = new List<string>();
                    for (int col = 1; col <= colCount; col++)
                    {
                        columnNames.Add(worksheet.Cells[1, col].Text);
                    }

                    for (int row = 2; row <= rowCount; row++) 
                    {
                        List<string> rowData = new List<string>();
                        StringBuilder sqlRow = new StringBuilder($"INSERT INTO {tableName} ({string.Join(", ", columnNames)}) VALUES (");

                        for (int col = 1; col <= colCount; col++)
                        {
                            string cellValue = worksheet.Cells[row, col].Text;
                            rowData.Add(cellValue);

                            
                            if (int.TryParse(cellValue, out _) || double.TryParse(cellValue, out _))
                            {
                                sqlRow.Append(cellValue); 
                            }

                            else if (string.IsNullOrEmpty(cellValue))
                            {
                                sqlRow.Append("NULL"); 
                            }
   
                            else
                            {
                                sqlRow.Append($"N'{cellValue.Replace("'", "''")}'"); 
                            }

                            if (col < colCount)
                            {
                                sqlRow.Append(", ");
                            }
                        }

                        sqlRow.Append(");");
                        sqlStatements.AppendLine(sqlRow.ToString());
                        data.Add(rowData);
                    }
                }
            }

            ViewBag.Message = "File uploaded successfully!";
            ViewBag.SqlStatements = sqlStatements.ToString();
            ViewBag.Data = data;

            return View();
        }
    }
}