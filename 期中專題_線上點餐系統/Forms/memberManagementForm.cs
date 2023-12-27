using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace 期中專題_線上點餐系統.Forms
{
    public partial class memberManagementForm : Form
    {
        private Form currChildForm;

        public memberManagementForm()
        {
            InitializeComponent();
        }

        private void memberManagementForm_Load(object sender, EventArgs e)
        {
            showList();
        }

        private void showList()
        {
            panel_edit.Visible = false;
            btn_detailInfo.Enabled = true;
            isMemberForm = true;
            listView_member.Clear();
            listView_member.LargeImageList = null;
            listView_member.SmallImageList = null;
            listView_member.View = View.Details;

            listView_member.Columns.Add("", 0);
            listView_member.Columns.Add("會員編號", 100);
            listView_member.Columns.Add("姓名", 98);
            listView_member.Columns.Add("電話", 190);
            foreach (ColumnHeader column in listView_member.Columns)
            {
                column.TextAlign = HorizontalAlignment.Center;
            }
            SetHeight(listView_member, 20);

            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();
            string sql = "select * from customers;";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(reader["id"].ToString());
                item.SubItems.Add((string)reader["name"]);
                item.SubItems.Add((string)reader["phone"]);
                listView_member.Font = new Font("微軟正黑體", 12);
                listView_member.Items.Add(item);
            }
           
            listView_member.GridLines = false;
            listView_member.FullRowSelect = true;
            reader.Close();
            con.Close();
        }

        private void showStaffList()
        {
            panel_edit.Visible = false;
            btn_detailInfo.Enabled = true;
            isMemberForm = false;
            listView_member.Clear();
            listView_member.LargeImageList = null;
            listView_member.SmallImageList = null;
            listView_member.View = View.Details;

            listView_member.Columns.Add("", 0);
            listView_member.Columns.Add("員工編號", 100);
            listView_member.Columns.Add("姓名", 98);
            listView_member.Columns.Add("電話", 190);
            foreach (ColumnHeader column in listView_member.Columns)
            {
                column.TextAlign = HorizontalAlignment.Center;
            }
            SetHeight(listView_member, 20);

            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();
            string sql = "select * from employee;";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(reader["employeeID"].ToString());
                item.SubItems.Add((string)reader["name"]);
                item.SubItems.Add((string)reader["phone"]);
                listView_member.Font = new Font("微軟正黑體", 12);
                listView_member.Items.Add(item);
            }

            listView_member.GridLines = false;
            listView_member.FullRowSelect = true;
            reader.Close();
            con.Close();
        }

        private void SetHeight(ListView listView, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            listView.SmallImageList = imgList;
        }

        public static string search = "";

        bool isMemberForm = true;
        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_name.Text == "" && txt_phone.Text == "")
            {
                MessageBox.Show("請輸入欲查詢的資料");
                return;
            }
            else if(txt_name.Text == "" || txt_phone.Text == "")
            {
                MessageBox.Show("欄位輸入不完全");
            }

            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();
            if (isMemberForm)
            {
                panel_edit.Visible = true;
                listView_member.Clear();
                listView_member.LargeImageList = null;
                listView_member.SmallImageList = null;
                listView_member.View = View.Details;

                listView_member.Columns.Add("", 0);
                listView_member.Columns.Add("項目", 100);
                listView_member.Columns.Add("資料", 288);
                SetHeight(listView_member, 20);
                string sql = "select * from customers where name = @searchName and phone = @searchPhone;";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@searchName", txt_name.Text);
                cmd.Parameters.AddWithValue("@searchPhone", txt_phone.Text);
                SqlDataReader reader = cmd.ExecuteReader();
           
                if(reader.Read())
                {
                    ListViewItem item = new ListViewItem("");
                    item.SubItems.Add("會員編號");
                    item.SubItems.Add(reader["id"].ToString());
                    listView_member.Font = new Font("微軟正黑體", 16);
                    listView_member.Items.Add(item);

                    ListViewItem item1 = new ListViewItem("");
                    item1.SubItems.Add("姓名");
                    item1.SubItems.Add((string)reader["name"]);
                    listView_member.Font = new Font("微軟正黑體", 16);
                    listView_member.Items.Add(item1);

                    ListViewItem item2 = new ListViewItem("");
                    item2.SubItems.Add("電話");
                    item2.SubItems.Add((string)reader["phone"]);
                    listView_member.Font = new Font("微軟正黑體", 16);
                    listView_member.Items.Add(item2);

                    ListViewItem item3 = new ListViewItem("");
                    item3.SubItems.Add("密碼");
                    item3.SubItems.Add((string)reader["password"]);
                    listView_member.Font = new Font("微軟正黑體", 16);
                    listView_member.Items.Add(item3);

                    ListViewItem item4 = new ListViewItem("");
                    item4.SubItems.Add("Email");
                    item4.SubItems.Add((string)reader["email"]);
                    listView_member.Font = new Font("微軟正黑體", 16);
                    listView_member.Items.Add(item4);

                    ListViewItem item5 = new ListViewItem("");
                    item5.SubItems.Add("住址");
                    item5.SubItems.Add((string)reader["address"]);
                    listView_member.Font = new Font("微軟正黑體", 16);
                    listView_member.Items.Add(item5); 
                    
                    ListViewItem item6 = new ListViewItem("");
                    item6.SubItems.Add("停權");
                    item6.SubItems.Add((bool)reader["suspension"] ? "停權" : "無");
                    listView_member.Font = new Font("微軟正黑體", 16);
                    listView_member.Items.Add(item6);
                }
                reader.Close();
            }
            else
            {
                panel_edit.Visible = true;
                listView_member.Clear();
                listView_member.LargeImageList = null;
                listView_member.SmallImageList = null;
                listView_member.View = View.Details;

                listView_member.Columns.Add("", 0);
                listView_member.Columns.Add("項目", 100);
                listView_member.Columns.Add("資料", 288);
                SetHeight(listView_member, 20);
                string sql = "select * from employee where name = @searchName and phone = @searchPhone;";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@searchName", txt_name.Text);
                cmd.Parameters.AddWithValue("@searchPhone", txt_phone.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ListViewItem item = new ListViewItem("");
                    item.SubItems.Add("員工編號");
                    item.SubItems.Add(reader["employeeID"].ToString());
                    listView_member.Font = new Font("微軟正黑體", 16);
                    listView_member.Items.Add(item);

                    ListViewItem item1 = new ListViewItem("");
                    item1.SubItems.Add("姓名");
                    item1.SubItems.Add((string)reader["name"]);
                    listView_member.Font = new Font("微軟正黑體", 16);
                    listView_member.Items.Add(item1);

                    ListViewItem item2 = new ListViewItem("");
                    item2.SubItems.Add("電話");
                    item2.SubItems.Add((string)reader["phone"]);
                    listView_member.Font = new Font("微軟正黑體", 16);
                    listView_member.Items.Add(item2);

                    ListViewItem item3 = new ListViewItem("");
                    item3.SubItems.Add("密碼");
                    item3.SubItems.Add((string)reader["password"]);
                    listView_member.Font = new Font("微軟正黑體", 16);
                    listView_member.Items.Add(item3);

                    ListViewItem item4 = new ListViewItem("");
                    item4.SubItems.Add("Email");
                    item4.SubItems.Add((string)reader["email"]);
                    listView_member.Font = new Font("微軟正黑體", 16);
                    listView_member.Items.Add(item4);

                    ListViewItem item5 = new ListViewItem("");
                    item5.SubItems.Add("住址");
                    item5.SubItems.Add((string)reader["address"]);
                    listView_member.Font = new Font("微軟正黑體", 16);
                    listView_member.Items.Add(item5);

                    ListViewItem item6 = new ListViewItem("");
                    item6.SubItems.Add("權限");
                    item6.SubItems.Add(reader["permission"].ToString());
                    listView_member.Font = new Font("微軟正黑體", 16);
                    listView_member.Items.Add(item6);
                }
                reader.Close();
            }
            
            con.Close();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currChildForm != null)
            {
                currChildForm.Close();
            }
            currChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_list.Controls.Add(childForm);
            panel_list.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(listView_member.SelectedItems.Count > 0)
            {
                if (listView_member.SelectedIndices[0] != 0 && listView_member.SelectedIndices[0] != 2)
                {
                    listView_member.SelectedItems[0].SubItems[2].Text = txt_edit.Text;
                    txt_edit.Text = "";
                }
                else
                {
                    MessageBox.Show("會員編號、電話和權限無法更改");
                }
                
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            List<string> saveInfo = new List<string>();
            foreach (ListViewItem item in listView_member.Items)
            {
                    string temp = item.SubItems[2].Text;
                    saveInfo.Add(temp); 
                Console.WriteLine(temp);
            }
            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();

            if (isMemberForm)
            {                
                string sql = "update customers set name = @newName, password = @newPassword, email = @newEmail, address = @newAddress where id = @customerID;";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@newName", saveInfo[1]);
                cmd.Parameters.AddWithValue("@newPassword", saveInfo[3]);
                cmd.Parameters.AddWithValue("@newEmail", saveInfo[4]);
                cmd.Parameters.AddWithValue("@newAddress", saveInfo[5]);
                int ID = 0;
                Int32.TryParse(saveInfo[0], out ID);
                cmd.Parameters.AddWithValue("@customerID", ID);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("儲存成功");
                showList();
            }
            else
            {
                string sql = "update employee set name = @newName, password = @newPassword, email = @newEmail, address = @newAddress where employeeID = @ID;";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@newName", saveInfo[1]);
                cmd.Parameters.AddWithValue("@newPassword", saveInfo[3]);
                cmd.Parameters.AddWithValue("@newEmail", saveInfo[4]);
                cmd.Parameters.AddWithValue("@newAddress", saveInfo[5]);
                int ID = 0;
                Int32.TryParse(saveInfo[0], out ID);
                cmd.Parameters.AddWithValue("@ID", ID);
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("儲存成功");
                showStaffList();
            }
            con.Close();
        }

        private void btn_detailInfo_Click(object sender, EventArgs e)
        {
            if(listView_member.SelectedItems.Count > 0)
            {
                btn_detailInfo.Enabled = false;
                int ID = 0;
                Int32.TryParse(listView_member.SelectedItems[0].SubItems[1].Text, out ID);
                panel_edit.Visible = true;

                listView_member.Clear();
                listView_member.LargeImageList = null;
                listView_member.SmallImageList = null;
                listView_member.View = View.Details;

                listView_member.Columns.Add("", 0);
                listView_member.Columns.Add("項目", 100);
                listView_member.Columns.Add("資料", 288);
                SetHeight(listView_member, 20);
                SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
                con.Open();
                if(isMemberForm)
                {
                    string sql = "select * from customers where id = @searchID;";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@searchID", ID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        ListViewItem item = new ListViewItem("");
                        item.SubItems.Add("會員編號");
                        item.SubItems.Add(reader["id"].ToString());
                        listView_member.Font = new Font("微軟正黑體", 16);
                        listView_member.Items.Add(item);

                        ListViewItem item1 = new ListViewItem("");
                        item1.SubItems.Add("姓名");
                        item1.SubItems.Add((string)reader["name"]);
                        listView_member.Font = new Font("微軟正黑體", 16);
                        listView_member.Items.Add(item1);

                        ListViewItem item2 = new ListViewItem("");
                        item2.SubItems.Add("電話");
                        item2.SubItems.Add((string)reader["phone"]);
                        listView_member.Font = new Font("微軟正黑體", 16);
                        listView_member.Items.Add(item2);

                        ListViewItem item3 = new ListViewItem("");
                        item3.SubItems.Add("密碼");
                        item3.SubItems.Add((string)reader["password"]);
                        listView_member.Font = new Font("微軟正黑體", 16);
                        listView_member.Items.Add(item3);

                        ListViewItem item4 = new ListViewItem("");
                        item4.SubItems.Add("Email");
                        item4.SubItems.Add((string)reader["email"]);
                        listView_member.Font = new Font("微軟正黑體", 16);
                        listView_member.Items.Add(item4);

                        ListViewItem item5 = new ListViewItem("");
                        item5.SubItems.Add("住址");
                        item5.SubItems.Add((string)reader["address"]);
                        listView_member.Font = new Font("微軟正黑體", 16);
                        listView_member.Items.Add(item5);

                        ListViewItem item6 = new ListViewItem("");
                        item6.SubItems.Add("停權");
                        item6.SubItems.Add((bool)reader["suspension"] ? "停權" : "無");
                        listView_member.Font = new Font("微軟正黑體", 16);
                        listView_member.Items.Add(item6);

                    }
                    reader.Close();
                }
                else
                {
                    string sql = "select * from employee where employeeID = @searchID;";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@searchID", ID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        ListViewItem item = new ListViewItem("");
                        item.SubItems.Add("會員編號");
                        item.SubItems.Add(reader["employeeID"].ToString());
                        listView_member.Font = new Font("微軟正黑體", 16);
                        listView_member.Items.Add(item);

                        ListViewItem item1 = new ListViewItem("");
                        item1.SubItems.Add("姓名");
                        item1.SubItems.Add((string)reader["name"]);
                        listView_member.Font = new Font("微軟正黑體", 16);
                        listView_member.Items.Add(item1);

                        ListViewItem item2 = new ListViewItem("");
                        item2.SubItems.Add("電話");
                        item2.SubItems.Add((string)reader["phone"]);
                        listView_member.Font = new Font("微軟正黑體", 16);
                        listView_member.Items.Add(item2);

                        ListViewItem item3 = new ListViewItem("");
                        item3.SubItems.Add("密碼");
                        item3.SubItems.Add((string)reader["password"]);
                        listView_member.Font = new Font("微軟正黑體", 16);
                        listView_member.Items.Add(item3);

                        ListViewItem item4 = new ListViewItem("");
                        item4.SubItems.Add("Email");
                        item4.SubItems.Add((string)reader["email"]);
                        listView_member.Font = new Font("微軟正黑體", 16);
                        listView_member.Items.Add(item4);

                        ListViewItem item5 = new ListViewItem("");
                        item5.SubItems.Add("住址");
                        item5.SubItems.Add((string)reader["address"]);
                        listView_member.Font = new Font("微軟正黑體", 16);
                        listView_member.Items.Add(item5);

                        ListViewItem item6 = new ListViewItem("");
                        item6.SubItems.Add("權限");
                        item6.SubItems.Add(reader["permission"].ToString());
                        listView_member.Font = new Font("微軟正黑體", 16);
                        listView_member.Items.Add(item6);
                    }
                    reader.Close();
                }
                con.Close();
            }
            
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            showList();
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            showStaffList();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要刪除此筆資料?", "刪除資料", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
                con.Open();
                int ID = 0;
                Int32.TryParse(listView_member.Items[0].SubItems[2].Text, out ID);
                Console.WriteLine(ID.ToString());
                if (isMemberForm)
                {
                    string sql = "delete from customers where id = @customerID;";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("customerID", ID);
                    cmd.ExecuteNonQuery();
                    showList();
                }
                else
                {
                    string sql = "delete * from customers where employeeID = @ID;";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("ID", ID);
                    cmd.ExecuteNonQuery();
                    showStaffList();
                }
                con.Close();
            }
            
        }

        private void btn_newStaff_Click(object sender, EventArgs e)
        {

        }

        private void btn_suspension_Click(object sender, EventArgs e)
        {
            if(isMemberForm)
            {
                int ID = 0;
                Int32.TryParse(listView_member.Items[0].SubItems[2].Text, out ID);
                SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
                con.Open();
                string sql = "update customers set suspension = 1 where id = @customerID;";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@customerID", ID);
                cmd.ExecuteNonQuery();
                showList();
            }
            else
            {
                MessageBox.Show("員工不能被停權");
            }
        }
    }
}
