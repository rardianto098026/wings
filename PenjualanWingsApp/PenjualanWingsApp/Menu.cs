using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenjualanWingsApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_buy_product_Click(object sender, EventArgs e)
        {
            ProductList prodList = new ProductList();
            prodList.Show();
            this.Hide();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            ReportPenjualan reportPage = new ReportPenjualan();
            reportPage.Show();
            this.Hide();
        }
    }
}
