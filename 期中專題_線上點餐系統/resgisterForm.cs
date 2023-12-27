using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 期中專題_線上點餐系統
{
    public partial class resgisterForm : Form
    {
        bool isSame = false;
        public resgisterForm()
        {
            InitializeComponent();
        }

        private void resgisterForm_Load(object sender, EventArgs e)
        {
            isSame = false;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {

            bool isRegistered = false;
            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();
            string strSql = "select * from customers where phone = @searchPhone";
            SqlCommand cmd = new SqlCommand(strSql, con);
            cmd.Parameters.AddWithValue("@searchPhone", txt_phone.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("此手機號已被註冊");
                isRegistered = true;
            }
            reader.Close();
            if((!isRegistered) && isSame && txt_phone.Text != "" && txt_password.Text != "" && txt_name.Text != "" && txt_email.Text != "" && txt_address.Text != "")
            {
                string strSQL = "insert into customers values(@NewName, @NewPhone, @NewPassword, @NewEmail, @NewAddress, 0, 0);";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt_name.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt_phone.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txt_password.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txt_email.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt_address.Text);
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show("註冊成功!");
                
                con.Close();
                Close();
            }
            
            con.Close();
        }

        private void txt_comfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txt_comfirmPassword.Text != txt_password.Text)
            {
                lbl_diff.Visible = true;
                isSame = false;
            }
            if (txt_comfirmPassword.Text == txt_password.Text)
            {
                lbl_diff.Visible = false;
                isSame = true;
            }
        }
    }
}
