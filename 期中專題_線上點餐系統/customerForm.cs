using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;
using 期中專題_線上點餐系統.custForm;
using Microsoft.SqlServer.Server;

namespace 期中專題_線上點餐系統
{
    public partial class customerForm : System.Windows.Forms.Form
    {

        private IconButton currBtn;
        private Panel leftBorderBtn;
        private System.Windows.Forms.Form currChildForm;
        



        public customerForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 95);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        private struct RGBColors
        {
            public static Color color3 = Color.FromArgb(46, 139, 87);
            public static Color color2 = Color.FromArgb(255, 231, 186);
            public static Color color1 = Color.FromArgb(0, 100, 0);
            public static Color color4 = Color.FromArgb(65, 105, 225);
            public static Color color5 = Color.FromArgb(139, 35, 35);
            public static Color color6 = Color.FromArgb(106, 90, 205);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currBtn = (IconButton)senderBtn;
                currBtn.BackColor = Color.FromArgb(255, 106, 106);
                currBtn.ForeColor = color;
                currBtn.TextAlign = ContentAlignment.MiddleCenter;
                currBtn.IconColor = color;
                currBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currBtn != null)
            {
                currBtn.BackColor = Color.FromArgb(192, 64, 0);
                currBtn.ForeColor = Color.FromArgb(255, 255, 192);
                currBtn.TextAlign = ContentAlignment.MiddleLeft;
                currBtn.IconColor = Color.FromArgb(255, 255, 192);
                currBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
 
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        private void customerForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("form load");
            scsb.DataSource = @".";
            scsb.InitialCatalog = "orderdb";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBconnectionString = scsb.ConnectionString;
            listInitialize();
            //showList();
            if (!GlobalVar.isLogin)
            {
                Form1 myForm = new Form1();
                myForm.ShowDialog();
            }
            if (GlobalVar.isEmployee)
            {
                Hide();
                staffForm myStaffForm = new staffForm();
                myStaffForm.ShowDialog();
            }
            lbl_welcome.Text = string.Format("歡迎光臨 {0}", GlobalVar.username);
            showList(1);
        }

        private void listInitialize()
        {
            int i = 0;
            GlobalVar.isChecked = false;
            GlobalVar.orderQuantity.Clear();
            if(GlobalVar.flavorID != 0)
            {
                radio_original.Checked = false;
                radio_satay.Checked = false;
                radio_light.Checked = false;
                radio_softly.Checked = false;
                radio_small.Checked = false;
                radio_medium.Checked = false;
                radio_extreme.Checked = false;
                radio_milk.Checked = false;
                radio_spicymilk.Checked = false;
            }
            GlobalVar.flavorID = 0;
            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();
            string mySql = "select ingridientName, price, ingridientID from ingridient order by ingridientCatID;";
            SqlCommand cmd = new SqlCommand(mySql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                GlobalVar.orderQuantity.Add(new Tuple<string, string, int, int>(reader["ingridientName"].ToString(), reader["price"].ToString(), 0, (int)reader["ingridientID"])); ;
            }
            reader.Close();
            con.Close();
        }

        private void showList(int i)
        {
            btn_add.Visible = true;
            btn_minus.Visible = true;
            listView_product.Clear();
            listView_product.LargeImageList = null;
            listView_product.SmallImageList = null;
            listView_product.View = View.Details;

            listView_product.Columns.Add("", 0);
            listView_product.Columns.Add("商品名稱", 150);
            listView_product.Columns.Add("商品價格", 150);
            listView_product.Columns.Add("數量", 100);
            foreach (ColumnHeader column in listView_product.Columns)
            { 
                column.TextAlign = HorizontalAlignment.Center;
            }

            SetHeight(listView_product, 80);

            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();
            string mySql = "select ingridientName, price from ingridient where ingridientCatID = @searchID;";
            SqlCommand cmd = new SqlCommand(mySql, con);
            cmd.Parameters.AddWithValue("@searchID", i.ToString());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem("");
                item.SubItems.Add(reader["ingridientName"].ToString());
                item.SubItems.Add(reader["Price"].ToString());
                var quantity = GlobalVar.orderQuantity.Where(n => n.Item1 == reader["ingridientName"].ToString());
                item.SubItems.Add(quantity.FirstOrDefault().Item3.ToString());
                listView_product.Font = new Font("微軟正黑體", 16);
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


        private void btn_vegetable_Click(object sender, EventArgs e)
        {
            //if(currChildForm.Text == "vegeForm" || currChildForm.Text == "vegeForm2")
            //{
            //    return;
            //}  //需先指定一個childForm才可運行
            listView_product.Visible = true;
            ActivateButton(sender, RGBColors.color1);
            showList(1);
            btn_add2cart.Visible = false;
        }

        private void btn_protein_Click(object sender, EventArgs e)
        {
            listView_product.Visible = true;
            ActivateButton(sender, RGBColors.color2);
            showList(2);
            btn_add2cart.Visible = false;
        }

        private void btn_mainDish_Click(object sender, EventArgs e)
        {
            listView_product.Visible = true;
            ActivateButton(sender, RGBColors.color3);
            showList(3);
            btn_add2cart.Visible = false;
        }


        private void btn_other_Click(object sender, EventArgs e)
        {
            listView_product.Visible = true;
            ActivateButton(sender, RGBColors.color6);
            showList(4);
            btn_add2cart.Visible = false;
        }

        private void btn_flavor_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            listView_product.Visible = false;
            btn_add2cart.Visible = true;
            btn_add.Visible = false;
            btn_minus.Visible = false;
        }

        private void btn_hotpot_Click(object sender, EventArgs e)
        {
            listView_product.Visible = true;
            ActivateButton(sender, RGBColors.color4);
            showList(5);
            btn_add2cart.Visible = false;
        }


        private void listView_product_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 192, 192)), e.Bounds);
            Font headerFont = new Font("微軟正黑體", 20, FontStyle.Bold);

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.Black, e.Bounds, format);
        }

        private void listView_product_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (listView_product.SelectedItems.Count > 0)
            {
                int q = 0;
                var matchName = GlobalVar.orderQuantity.FirstOrDefault(n => n.Item1 == listView_product.SelectedItems[0].SubItems[1].Text);
                q = matchName.Item3;
                GlobalVar.orderQuantity.RemoveAll(n => n.Item1 == matchName.Item1);
                q++;
                GlobalVar.orderQuantity.Add(new Tuple<string, string, int, int>(matchName.Item1.ToString(), matchName.Item2.ToString(), q, matchName.Item4));
                listView_product.SelectedItems[0].SubItems[3].Text = q.ToString();
            }

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (listView_product.SelectedItems.Count > 0)
            {
                int q = 0;
                var matchName = GlobalVar.orderQuantity.FirstOrDefault(n => n.Item1 == listView_product.SelectedItems[0].SubItems[1].Text);
                q = matchName.Item3;
                if(q > 0)
                {
                    GlobalVar.orderQuantity.RemoveAll(n => n.Item1 == matchName.Item1);
                    q--;
                    GlobalVar.orderQuantity.Add(new Tuple<string, string, int, int>(matchName.Item1.ToString(), matchName.Item2.ToString(), q, matchName.Item4 ));
                    listView_product.SelectedItems[0].SubItems[3].Text = q.ToString();
                }               
            }

        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            cart cart = new cart();
            cart.ShowDialog();
            if(GlobalVar.isChecked)
            {
                customerForm_Load(sender, e);
            }
        }

        private void btn_add2cart_Click(object sender, EventArgs e)
        {
            if(GlobalVar.flavorID == 0)
            {
                MessageBox.Show("請選擇口味！");
                return;
            }
            string flavorName = "";
            string flavorPrice = "";
            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();
            string mySql = "select flavorName, price from flavor where flavorID = @searchID";
            SqlCommand cmd = new SqlCommand(mySql, con);
            cmd.Parameters.AddWithValue("@searchID", GlobalVar.flavorID);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                flavorName = reader["flavorName"].ToString();
                flavorPrice = reader["price"].ToString();

                reader.Close();
                con.Close();

                GlobalVar.quantityList.Add(1);
                GlobalVar.cartFlavorList.Add(Tuple.Create(GlobalVar.flavorID, flavorPrice, flavorName));
                GlobalVar.orderQuantity.RemoveAll(n => n.Item3 == 0);
                GlobalVar.cartList.Add(GlobalVar.orderQuantity.ToList());

                foreach (var item in GlobalVar.cartList)
                {
                    foreach (var items in item)
                    {
                        Console.WriteLine(items);
                    }

                }
                MessageBox.Show("已新增至購物車");
                listInitialize();
                btn_vegetable.PerformClick();
            }
            else
            {
                MessageBox.Show("發生錯誤");
            }
            
        }

        private void radio_original_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.flavorID = 1;
        }

        private void radio_spicymilk_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.flavorID = 9;
        }

        private void radio_milk_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.flavorID = 8;
        }

        private void radio_satay_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.flavorID = 2;
        }

        private void radio_light_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.flavorID = 3;
        }

        private void radio_softly_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.flavorID = 4;
        }

        private void radio_small_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.flavorID = 5;
        }

        private void radio_medium_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.flavorID = 6;
        }

        private void radio_extreme_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.flavorID = 7;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            listInitialize();
            for(int i = 0; i < listView_product.Items.Count; i++)
            {
                listView_product.Items[i].SubItems[3].Text = "0";
            }
        }

        private void btn_checkList_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            //con.Open();
            //string sql = "select * from orders where customerID = @searchID;";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.Parameters.AddWithValue("@searchID", GlobalVar.userID);
            //if(ReadOnlyAttribute )
            checlListForm myCheclListForm = new checlListForm();
            myCheclListForm.ShowDialog();
        }
    }
}
