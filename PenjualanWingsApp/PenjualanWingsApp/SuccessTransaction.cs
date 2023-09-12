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

namespace PenjualanWingsApp
{
    public partial class SuccessTransaction : Form
    {
        public SuccessTransaction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (ModelPublic.SessionRole == "Admin")
            {
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                ProductList prodList = new ProductList();
                prodList.Show();
            }
        }
    }
}
