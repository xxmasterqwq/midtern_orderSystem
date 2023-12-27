using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 期中專題_線上點餐系統
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "orderdb";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBconnectionString = scsb.ConnectionString;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();
            string mySql = "select * from employee where phone = @searchPhone and password = @searchPassword;";
            SqlCommand cmd = new SqlCommand(mySql, con);
            cmd.Parameters.AddWithValue("@searchPhone", txt_phone.Text);
            cmd.Parameters.AddWithValue("@searchPassword", txt_password.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                GlobalVar.isEmployee = true;
                reader.Close();
                con.Close();
                Close();
                return;
            }
            reader.Close();
            mySql = "select * from customers where phone = @searchPhone and password = @searchPassword;";
            cmd = new SqlCommand(mySql, con);
            cmd.Parameters.AddWithValue("@searchPhone", txt_phone.Text);
            cmd.Parameters.AddWithValue("@searchPassword", txt_password.Text);
            reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                if ((bool)reader["suspension"])
                {
                    MessageBox.Show("你已被停權");
                    reader.Close();
                    con.Close() ;
                    return;
                }
                GlobalVar.isLogin = true;
                GlobalVar.userID = (int)reader["id"];
                GlobalVar.username = (string)reader["name"];
                GlobalVar.point = (int)reader["point"];
                reader.Close();
                con.Close();
                Close();
            }
            else
            {
                MessageBox.Show("帳號或密碼輸入錯誤");
            }
            reader.Close();
            con.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            resgisterForm myRegisterForm = new resgisterForm();
            myRegisterForm.ShowDialog();
        }

        private void btn_forget_Click(object sender, EventArgs e)
        {

        }

        private void btn_visit_Click(object sender, EventArgs e)
        {

        }
    }
}
