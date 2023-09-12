using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PenjualanWingsApp.Repository;

namespace PenjualanWingsApp
{
    public partial class UCProduct : UserControl
    {
        public string dimension, priceUnit, idProduct;
        public static UCProduct Instance { get; set; }
        public UCProduct()
        {
            InitializeComponent();
            Instance = this;
        }

        private void UCProduct_Load(object sender, EventArgs e)
        {
            btn_plus.Hide();
            btn_minus.Hide();
            tBox_qty.Hide();

            btn_buy.Show();
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            btn_plus.Show();
            btn_minus.Show();
            tBox_qty.Show();
            
            if (tBox_qty.Text == "")
            {
                tBox_qty.Text = "1";
            }
            else
            {
                tBox_qty.Text = (Convert.ToInt32(tBox_qty.Text) + 1).ToString();
            }
            ModelPublic.Checkout[idProduct] = Convert.ToInt32(tBox_qty.Text);

            btn_buy.Hide();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (tBox_qty.Text == "1")
            {
                btn_plus.Hide();
                btn_minus.Hide();
                tBox_qty.Hide();
                tBox_qty.Text = "";

                btn_buy.Show();
            }
            else
            {
                tBox_qty.Text = (Convert.ToInt32(tBox_qty.Text) - 1).ToString();
                if(tBox_qty.Text == "1")
                {
                    ModelPublic.Checkout.Remove(idProduct);
                }
                else
                {
                    ModelPublic.Checkout[idProduct] = Convert.ToInt32(tBox_qty.Text);
                }

            }   
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            tBox_qty.Text = (Convert.ToInt32(tBox_qty.Text) + 1).ToString();
            ModelPublic.Checkout[idProduct] = Convert.ToInt32(tBox_qty.Text);
        }

        #region set attribute
        public void ResetAttribute()
        {
            lbl_title.Text = "";
            lbl_price.Text = "";
            lbl_price_after_discount.Text = "";

            lbl_price.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }
        public void SetTitle(string title)
        {
            lbl_title.Text = title;
        }

        public void SetPrice(string price)
        {
            lbl_price.Text = "Rp. " + price;
        }
        public void SetPriceAfterDiscount(string price_after_discount)
        {
            lbl_price.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Strikeout);
            lbl_price_after_discount.Text = "Rp. " + price_after_discount;
        }
        public void AddQty(string idProd, Dictionary<string, int> CheckoutDict, UCProduct UCP)
        {
            Instance = UCP;
            ModelPublic.Checkout = CheckoutDict;
            Instance.idProduct = idProd;

            Instance.btn_plus.Show();
            Instance.btn_minus.Show();
            Instance.tBox_qty.Show();

            if (Instance.tBox_qty.Text == "")
            {
                Instance.tBox_qty.Text = "1";
            }
            else
            {
                Instance.tBox_qty.Text = (Convert.ToInt32(Instance.tBox_qty.Text) + 1).ToString();
            }
            ModelPublic.Checkout[Instance.idProduct] = Convert.ToInt32(Instance.tBox_qty.Text);

            Instance.btn_buy.Hide();
        }
        public void HiddenAttribute(string dimension_hdn, string price_unit, string id_product)
        {
            dimension = dimension_hdn;
            priceUnit = price_unit;
            idProduct = id_product;
        }
        #endregion

        private void pBox_Click(object sender, EventArgs e)
        {
            ProductDetail prodDetail = new ProductDetail();
            prodDetail.setHiddenAttribute(idProduct);
            prodDetail.ResetAttribute(ModelPublic.Checkout, this);
            prodDetail.setTitle(lbl_title.Text);
            
            prodDetail.setPrice(lbl_price.Text);
            if (!string.IsNullOrEmpty(lbl_price_after_discount.Text))
            {
                prodDetail.setPriceAfterDiscount(lbl_price_after_discount.Text);
            }
            prodDetail.setDimension(dimension);
            prodDetail.setPriceUnit(priceUnit);
            prodDetail.Show();
        }
    }
}
