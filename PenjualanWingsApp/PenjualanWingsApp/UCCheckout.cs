using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenjualanWingsApp
{
    public partial class UCCheckout : UserControl
    {
        public UCCheckout()
        {
            InitializeComponent();
        }

        private void pBox_Click(object sender, EventArgs e)
        {
            ProductDetail prodDetail = new ProductDetail();
            prodDetail.Show();

            this.Hide();
        }

        private void UCCheckout_Load(object sender, EventArgs e)
        {

        }


        #region set attribute
        public void ResetAttribute()
        {
            lbl_title.Text = "";
            lbl_unit.Text = "";
            lbl_subtotal.Text = "";
            tbox_qty.Text = "";
        }
        public void SetTitle(string title)
        {
            lbl_title.Text = title;
        }
        public void SetUnit(string unit)
        {
            lbl_unit.Text = unit;
        }
        public void SetSubTotal(double subTotal)
        {
            lbl_subtotal.Text = subTotal.ToString();
        }
        public void SetQty(string qty)
        {
            tbox_qty.Text = qty;
        }
        #endregion
    }
}
