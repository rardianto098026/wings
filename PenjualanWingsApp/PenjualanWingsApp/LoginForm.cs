using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PenjualanWingsApp.Repository;

namespace PenjualanWingsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtLogin = Common.ExecuteQuery("SP_LOGIN '" + textBox_username.Text + "','" + textBox_password.Text + "'");
                if(dtLogin.Rows.Count > 0)
                {
                    ModelPublic.SessionRole = dtLogin.Rows[0]["Role"].ToString();
                    ModelPublic.SessionUserID = dtLogin.Rows[0]["Id"].ToString();
                    ModelPublic.SessionUsername = dtLogin.Rows[0]["User"].ToString();

                    if (ModelPublic.SessionRole == "Admin")
                    {
                        Menu menuPage = new Menu();
                        menuPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        ProductList prodList = new ProductList();
                        prodList.Show();
                        this.Hide();
                    }
                }else
                {
                    MessageBox.Show("Invalid Username / Password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
                e.Handled = true; // Prevent further processing of the Enter key
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
