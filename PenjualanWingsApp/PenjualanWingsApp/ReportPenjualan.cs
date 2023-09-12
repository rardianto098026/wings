using PenjualanWingsApp.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PenjualanWingsApp
{
    public partial class ReportPenjualan : Form
    {
        public ReportPenjualan()
        {
            InitializeComponent();
        }

        private void ReportPenjualan_Load(object sender, EventArgs e)
        {
            try
            {
                //string cek = "SP_GetTransactionsByFilter '" + tbox_search.Text + "','" + tbox_transaction.Text + "','" + tbox_user.Text + "','" + Convert.ToDecimal(tbox_total.Text) + "','" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "','" + tbox_item.Text + "'";
                DataTable dtReport = Common.ExecuteQuery("SP_GetTransactionsByFilter null,null,null,null,null,null");
                dataGridView1.DataSource = dtReport;
                dataGridView1.Columns["Date"].DefaultCellStyle.Format = "dd MMM yyyy";
            }
            catch(Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                //string cek = "SP_GetTransactionsByFilter /'" + tbox_search.Text + "','" + tbox_transaction.Text + "','" + tbox_user.Text + "','" + Convert.ToDecimal(tbox_total.Text) + "','" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "','" + tbox_item.Text + "'";
                string filter = "";
                if (!string.IsNullOrEmpty(tbox_search.Text))
                {
                    filter = "'" + tbox_search.Text + "', ";
                }else
                {
                    filter = "null, ";
                }

                if (!string.IsNullOrEmpty(tbox_transaction.Text))
                {
                    filter += "'" + tbox_transaction.Text + "' ";
                }
                else
                {
                    filter += "null, ";
                }

                if (!string.IsNullOrEmpty(tbox_user.Text))
                {
                    filter += "'" + tbox_user.Text + "', ";
                }
                else
                {
                    filter += "null, ";
                }

                if (!string.IsNullOrEmpty(tbox_total.Text))
                {
                    filter += Convert.ToDecimal(tbox_total.Text) + ", ";
                }
                else
                {
                    filter += "null, ";
                }

                if (chkBox_datetimepicker.Checked)
                {
                    filter += "'" + dateTimePicker1.Value.ToString("MM-dd-yyyy") + "', ";
                }
                else
                {
                    filter += "null, ";
                }

                if (!string.IsNullOrEmpty(tbox_item.Text))
                {
                    filter += "'" + tbox_item.Text + "'";
                }
                else
                {
                    filter += "null ";
                }
                DataTable dtReport = Common.ExecuteQuery("SP_GetTransactionsByFilter " + filter);
                dataGridView1.DataSource = dtReport;
                dataGridView1.Columns["Date"].DefaultCellStyle.Format = "dd MMM yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
        }

        private void tbox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
                e.Handled = true; // Prevent further processing of the Enter key
            }
        }

        private void tbox_transaction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
                e.Handled = true; // Prevent further processing of the Enter key
            }
        }

        private void tbox_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
                e.Handled = true; // Prevent further processing of the Enter key
            }
        }

        private void tbox_total_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
                e.Handled = true; // Prevent further processing of the Enter key
            }
        }

        private void tbox_item_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
                e.Handled = true; // Prevent further processing of the Enter key
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridView1);
        }
        private void ExportToExcel(DataGridView dataGridView)
        {
            try
            {
                // Create a new Excel application
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                // Create a new workbook and add a worksheet
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = excelWorkbook.Sheets[1];

                // Set the column headers in Excel
                for (int i = 1; i <= dataGridView.Columns.Count; i++)
                {
                    excelWorksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                }

                // Populate the Excel worksheet with data from the DataGridView
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        excelWorksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                    }
                }

                // Save the Excel file
                excelWorkbook.SaveAs("Report_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") +".xlsx");
                
                // Release COM objects to avoid memory leaks
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorksheet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void chkBox_datetimepicker_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_datetimepicker.Checked)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
