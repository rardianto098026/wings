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
    public partial class ProductDetail : Form
    {
        public string idProduct;
        public static UCProduct InstanceUCP { get; set; }
        public Dictionary<string, int> CheckoutDict;

        public ProductDetail()
        {
            InitializeComponent();
        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {

        }

        #region set Attribute
        public void ResetAttribute(Dictionary<string,int> checkout_dict, UCProduct UCP)
        {
            lbl_title.Text = "";
            lbl_price.Text = "";
            lbl_price_after_discount.Text = "";
            lbl_dimesion.Text = "";
            lbl_price_unit.Text = "";
            CheckoutDict = checkout_dict;
            InstanceUCP = UCP;

            lbl_price.Font = new Font(lbl_price.Font, FontStyle.Regular);
        }
        public void setTitle(string title)
        {
            lbl_title.Text = title;
        }
        public void setPrice(string price)
        {
            lbl_price.Text = price;
        }
        public void setPriceAfterDiscount(string price_after_discount)
        {
            lbl_price.Font = new Font(lbl_price.Font, FontStyle.Strikeout);
            lbl_price_after_discount.Text = price_after_discount;
        }
        public void setDimension(string dimension)
        {
            lbl_dimesion.Text = dimension;
        }
        public void setPriceUnit(string price_unit)
        {
            lbl_price_unit.Text = price_unit;
        }
        public void setHiddenAttribute(string id_product)
        {
            idProduct = id_product;
        }
        #endregion

        private void btn_buy_Click(object sender, EventArgs e)
        {
            this.Hide();
            UCProduct ucp = new UCProduct();
            ucp.AddQty(idProduct, CheckoutDict, InstanceUCP);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
