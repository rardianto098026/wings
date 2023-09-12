using PenjualanWingsApp.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenjualanWingsApp
{
    public partial class CheckoutPage : Form
    {
        public CheckoutPage()
        {
            InitializeComponent();
        }

        private void CheckoutPage_Load(object sender, EventArgs e)
        {
            int initialY = 0; // Koordinat Y awal

            try
            {
                DataTable dtListProducts = Common.ExecuteQuery("SP_GetActiveProducts");
                if (dtListProducts.Rows.Count > 0)
                {
                    for (int i = 0; i < dtListProducts.Rows.Count; i++)
                    {
                        UCCheckout uc = new UCCheckout();
                        uc.ResetAttribute();
                        uc.Location = new Point(0, initialY); // Set posisi kontrol
                        uc.SetTitle(dtListProducts.Rows[i]["Product_Name"].ToString());
                        uc.SetUnit(dtListProducts.Rows[i]["Unit"].ToString());
                        double subTotal = 0;
                        int qty = 0;
                        if(ModelPublic.CheckoutFixed.TryGetValue(dtListProducts.Rows[i]["Id"].ToString(), out subTotal))
                        {
                            uc.SetSubTotal(subTotal);
                        }
                        if (ModelPublic.Checkout.TryGetValue(dtListProducts.Rows[i]["Id"].ToString(), out qty))
                        {
                            uc.SetQty(qty.ToString());
                        }
                        panel1.Controls.Add(uc);

                        // Tingkatkan posisi Y untuk kontrol berikutnya
                        initialY += uc.Height + 5; // Ganti 5 dengan jarak vertikal yang diinginkan
                    }
                }
                lbl_total.Text = ModelPublic.TotalHarga.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                string DocumentCode = ConfigurationManager.AppSettings["codeDocumentTransaction"].ToString();
                string UserId = ModelPublic.SessionUsername;
                double Total = ModelPublic.TotalHarga;
                string generatedDocumentNumber = string.Empty;

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_InsertTransactionHeader", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Document_Code", string.IsNullOrEmpty(DocumentCode) ? (object)DBNull.Value : (object)DocumentCode);
                        cmd.Parameters.AddWithValue("@User", string.IsNullOrEmpty(UserId) ? (object)DBNull.Value : (object)UserId);
                        cmd.Parameters.AddWithValue("@Total", Total == 0 ? (object)DBNull.Value : (object)Total);
                        
                        SqlParameter outputParam = new SqlParameter("@Document_Number", SqlDbType.NVarChar, 255);
                        outputParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputParam);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        
                        generatedDocumentNumber = outputParam.Value.ToString();

                        conn.Close();
                    }

                    foreach (KeyValuePair<string, int> item in ModelPublic.Checkout)
                    {
                        using (SqlCommand cmd = new SqlCommand("SP_InsertTransactionDetail", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Document_Code", string.IsNullOrEmpty(DocumentCode) ? DBNull.Value : (object)DocumentCode);
                            cmd.Parameters.AddWithValue("@Document_Number", string.IsNullOrEmpty(generatedDocumentNumber) ? DBNull.Value : (object)generatedDocumentNumber);
                            cmd.Parameters.AddWithValue("@Product_Id", string.IsNullOrEmpty(item.Key) ? DBNull.Value : (object)item.Key);
                            cmd.Parameters.AddWithValue("@Quantity", item.Value == null ? DBNull.Value : (object)item.Value);

                            double subTotal = 0;
                            if (ModelPublic.CheckoutFixed.TryGetValue(item.Key, out subTotal))
                            {
                                cmd.Parameters.AddWithValue("@Sub_Total", subTotal == null ? DBNull.Value : (object)subTotal);
                            }else
                            {
                                cmd.Parameters.AddWithValue("@Sub_Total", DBNull.Value);
                            }

                            double price = 0;
                            if (ModelPublic.PriceList.TryGetValue(item.Key, out price))
                            {
                                cmd.Parameters.AddWithValue("@Price", price == null ? DBNull.Value : (object)price);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@Price", DBNull.Value);
                            }

                            conn.Open();
                            cmd.ExecuteNonQuery();

                            conn.Close();
                        }
                    }
                }
                this.Hide();
                SuccessTransaction successTrx = new SuccessTransaction();
                successTrx.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductList prodList = new ProductList();
            prodList.Show();
        }
    }
}
