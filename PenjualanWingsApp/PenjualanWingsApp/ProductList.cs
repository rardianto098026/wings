using PenjualanWingsApp.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenjualanWingsApp
{
    public partial class ProductList : Form
    {
        private ModelPublic modelPublicInstance = new ModelPublic(); // Create an instance
        
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            if(ModelPublic.SessionRole != "Admin")
            {
                button2.Hide();
            }
            int initialY = 0; // Koordinat Y awal

            try
            {
                DataTable dtListProducts = Common.ExecuteQuery("SP_GetActiveProducts");
                if (dtListProducts.Rows.Count > 0)
                {
                    for (int i = 0; i < dtListProducts.Rows.Count; i++)
                    {
                        UCProduct uc = new UCProduct();
                        uc.ResetAttribute();
                        uc.Location = new Point(0, initialY); // Set posisi kontrol
                        uc.SetTitle(dtListProducts.Rows[i]["Product_Name"].ToString());
                        uc.SetPrice(dtListProducts.Rows[i]["Price"].ToString());
                        string discountValue = dtListProducts.Rows[i]["Discount"].ToString();
                        int disc, price;
                        if (!string.IsNullOrEmpty(discountValue) && int.TryParse(discountValue, out disc))
                        {
                            string priceValue = dtListProducts.Rows[i]["Price"].ToString();
                            if (int.TryParse(priceValue, out price))
                            {
                                double price_after_discount = price - (price * ((double)disc / 100));
                                uc.SetPriceAfterDiscount(price_after_discount.ToString());
                                ModelPublic.PriceList[dtListProducts.Rows[i]["Id"].ToString()] = Convert.ToDouble(price_after_discount.ToString());
                            }
                            else
                            {
                                uc.SetPriceAfterDiscount("eror");
                            }
                        }
                        else
                        {
                            ModelPublic.PriceList[dtListProducts.Rows[i]["Id"].ToString()] = Convert.ToInt32(dtListProducts.Rows[i]["Price"]);
                        }
                        uc.HiddenAttribute(dtListProducts.Rows[i]["Dimension"].ToString(), dtListProducts.Rows[i]["Unit"].ToString(), dtListProducts.Rows[i]["Id"].ToString());
                        panel1.Controls.Add(uc);

                        // Tingkatkan posisi Y untuk kontrol berikutnya
                        initialY += uc.Height + 5; // Ganti 5 dengan jarak vertikal yang diinginkan
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            double totalHarga = 0;
            foreach (KeyValuePair<string, int> item in ModelPublic.Checkout)
            {
                double price = 0;
                if(ModelPublic.PriceList.TryGetValue(item.Key, out price))
                {
                    double subtotalHarga = item.Value * price;
                    totalHarga += subtotalHarga;

                    ModelPublic.CheckoutFixed[item.Key] = subtotalHarga;
                }
            }
            this.Hide();
            ModelPublic.TotalHarga = totalHarga;
            CheckoutPage COP = new CheckoutPage();
            COP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
