using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Project2
{
    public partial class Lab2_Bai4 : Form
    {
        private string excelPath = "data.xlsx";
        private string filePath = "data.txt";

        public Lab2_Bai4()
        {
            InitializeComponent();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab2_Bai4_Input_ inputForm = new Lab2_Bai4_Input_();
            inputForm.ShowDialog();
            inputForm = null;
            this.Show();
        }

        private string GetCellValue(WorkbookPart workbookPart, Cell cell)
        {
            SharedStringTablePart sharedStringPart = workbookPart.SharedStringTablePart;
            string cellValue = "";

            if (cell.CellValue != null)
            {
                cellValue = cell.CellValue.InnerText;
                if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
                {
                    cellValue = sharedStringPart.SharedStringTable.ChildElements[int.Parse(cellValue)].InnerText;
                }
            }
            return cellValue;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(excelPath, SpreadsheetDocumentType.Workbook))
                {
                    WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
                    workbookPart.Workbook = new Workbook();

                    WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                    worksheetPart.Worksheet = new Worksheet(new SheetData());

                    Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());
                    Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };
                    sheets.Append(sheet);

                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line = String.Empty;
                        int rowCounter = 1;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] fields = line.Split(';');
                            Row row = new Row { RowIndex = (uint)rowCounter++ };

                            for (int i = 0; i < fields.Length; i++)
                            {
                                Cell cell = new Cell();
                                if (i == 3 || i == 4)
                                {
                                    cell.DataType = CellValues.Number;
                                    cell.CellValue = new CellValue(fields[i]);
                                }
                                else
                                {
                                    cell.DataType = CellValues.String;
                                    cell.CellValue = new CellValue(fields[i]);
                                }

                                row.Append(cell);
                            }
                            double mathScore = double.Parse(fields[3]);
                            double literatureScore = double.Parse(fields[4]);
                            double averageScore = (mathScore + literatureScore) / 2;

                            Cell averageCell = new Cell();
                            averageCell.DataType = CellValues.Number;
                            averageCell.CellValue = new CellValue(averageScore.ToString());
                            row.Append(averageCell);

                            worksheetPart.Worksheet.GetFirstChild<SheetData>().AppendChild(row);
                        }
                    }
                }
                MessageBox.Show("Dữ liệu đã được nhập vào tệp Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(excelPath, false))
                {
                    WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
                    WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                    SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();

                    foreach (Row row in sheetData.Elements<Row>())
                    {
                        DataGridViewRow dataGridViewRow = dataGridView1.Rows[dataGridView1.Rows.Add()];

                        int columnIndex = 0;
                        foreach (Cell cell in row.Elements<Cell>())
                        {
                            string cellValue = GetCellValue(workbookPart, cell);
                            dataGridViewRow.Cells[columnIndex++].Value = cellValue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
