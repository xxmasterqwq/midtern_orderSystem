using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中專題_線上點餐系統.Forms
{
    public partial class productForm : Form
    {
        public productForm()
        {
            InitializeComponent();
        }

        private void productForm_Load(object sender, EventArgs e)
        {

        }

        private void showList(int i)
        {
            listView_product.Clear();
            listView_product.LargeImageList = null;
            listView_product.SmallImageList = null;
            listView_product.View = View.Details;

            listView_product.Columns.Add("", 0);
            listView_product.Columns.Add("商品分類", 125);
            listView_product.Columns.Add("商品名稱", 125);
            listView_product.Columns.Add("價格", 80);
            foreach (ColumnHeader column in listView_product.Columns)
            {
                column.TextAlign = HorizontalAlignment.Center;
            }

            SetHeight(listView_product, 20);

            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();
            string mySql = "select * from ingridient inner join ingridientCategory on ingridient.ingridientCatID = ingridientCategory.ingridientCatID where ingridient.ingridientCatID = @searchID;";
            SqlCommand cmd = new SqlCommand(mySql, con);
            cmd.Parameters.AddWithValue("@searchID", i);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem("");
                item.SubItems.Add(reader["ingCatName"].ToString());
                item.SubItems.Add(reader["ingridientName"].ToString());
                item.SubItems.Add(reader["Price"].ToString());
                listView_product.Font = new Font("微軟正黑體", 12);
                listView_product.Items.Add(item);
            }
            listView_product.GridLines = false;
            listView_product.FullRowSelect = true;
        }

        private void SetHeight(ListView listView, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            listView.SmallImageList = imgList;
        }

        int catID = 0;
        private void btn_vege_Click(object sender, EventArgs e)
        {
            showList(1);
            catID = 1;
        }

        private void btn_prot_Click(object sender, EventArgs e)
        {
            showList(2);
            catID = 2;
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            showList(3);
            catID = 3;
        }

        private void btn_other_Click(object sender, EventArgs e)
        {
            showList(4);
            catID = 4;
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            showList(5);
            catID = 5;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            showList(6);
            catID = 6;
        }

        private void listView_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView_product.SelectedItems.Count > 0)
            {
                cbox_category.SelectedIndex = catID;
                txt_name.Text = listView_product.SelectedItems[0].SubItems[2].Text;
                txt_price.Text = listView_product.SelectedItems[0].SubItems[3].Text;
            }
            
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if(cbox_category.SelectedIndex != 0 && txt_name.Text != "" && txt_price.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
                con.Open();
                string sql = "select * from ingridient where ingridientName = @searchName;";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@searchName", txt_name.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    MessageBox.Show("已有此商品");
                    reader.Close();
                    con.Close();
                    return;
                }
                reader.Close();
                string sql1 = "insert into ingridient values(@catID, @name, @price);";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                cmd1.Parameters.AddWithValue("@catID", cbox_category.SelectedIndex);
                cmd1.Parameters.AddWithValue("@name", txt_name.Text);
                cmd1.Parameters.AddWithValue("@price", txt_price.Text);
                int rows = cmd1.ExecuteNonQuery();

                MessageBox.Show("新增成功");
                con.Close();
                showList(cbox_category.SelectedIndex);
            }
            else
            {
                MessageBox.Show("資料不齊全");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cbox_category.SelectedIndex != 0 && txt_name.Text != "" && txt_price.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
                con.Open();
                string sql = "select ingridientID from ingridient where ingridientName = @searchName;";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@searchName", listView_product.SelectedItems[0].SubItems[2].Text);
                SqlDataReader reader = cmd.ExecuteReader();
                int updateID = 0;
                if (reader.Read())
                {
                    updateID = (int)reader["ingridientID"];
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("請選取要更改的品項");
                    reader.Close();
                    con.Close() ;
                    return;
                }
                string sql1 = "update ingridient set ingridientCatID = @catID, ingridientName = @name, price = @price where ingridientID = @updateID;";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                cmd1.Parameters.AddWithValue("@catID", cbox_category.SelectedIndex);
                cmd1.Parameters.AddWithValue("@name", txt_name.Text);
                cmd1.Parameters.AddWithValue("@price", txt_price.Text);
                cmd1.Parameters.AddWithValue("@updateID", updateID);
                int rows = cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("編輯已儲存");
                showList(cbox_category.SelectedIndex);
            }
            else
            {
                MessageBox.Show("資料不齊全");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (cbox_category.SelectedIndex != 0 && txt_name.Text != "" && txt_price.Text != "")
            {
                DialogResult result = MessageBox.Show("確定要移除此品項", "移除品項", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
                    con.Open();
                    string sql = "delete from ingridient where ingridientName = @name;";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@name", txt_name.Text);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    showList(cbox_category.SelectedIndex);
                }                   
            }    
            else
            {
                MessageBox.Show("請保持欄位資料完整");
            }
        }
    }
}
