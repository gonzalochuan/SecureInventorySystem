using System;
using System.Windows.Forms;
using InventorySystem1._0.Includes;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace InventorySystem1._0
{
    public partial class frmListStockout : Form
    {
        public frmListStockout()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        string sql;

        private void frmListStockout_Load(object sender, EventArgs e)
        {
            sql = "SELECT  `TRANSACTIONNUMBER` as ID,concat(`FIRSTNAME`, `LASTNAME`) as 'CUSTOMER',`NAME` as 'ITEMNAME', `DESCRIPTION`, `PRICE`, `TRANSACTIONDATE` as DATE, o.`QTY`, `TOTALPRICE` FROM  `tblperson` p,`tblstock_in_out` o ,`tblitems` i WHERE REMARKS='StockOut' and i.`ITEMID`=o.`ITEMID` and p.`SUPLIERCUSTOMERID`=o.`SUPLIERCUSTOMERID` and p.TYPE = 'Customer'" +
                  " AND (NAME like '%" + txtsearch.Text + "%' OR  TRANSACTIONNUMBER like '%" + txtsearch.Text + "%')";
            config.Load_DTG(sql, dtglist);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            frmListStockout_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtglist.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook|*.xlsx",
                Title = "Save Stock-Out List"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                    Excel.Worksheet worksheet = workbook.ActiveSheet;
                    worksheet.Name = "StockOutList";

                    // Add column headers
                    for (int i = 1; i <= dtglist.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i] = dtglist.Columns[i - 1].HeaderText;
                    }

                    // Add rows
                    for (int i = 0; i < dtglist.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtglist.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dtglist.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    workbook.SaveAs(sfd.FileName);
                    workbook.Close();
                    excelApp.Quit();

                    // Release COM objects
                    Marshal.ReleaseComObject(worksheet);
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(excelApp);

                    MessageBox.Show("Exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting to Excel: " + ex.Message, "Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}