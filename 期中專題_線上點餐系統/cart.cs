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

namespace 期中專題_線上點餐系統
{
    public partial class cart : Form
    {
        public cart()
        {
            InitializeComponent();
        }

        private void cart_Load(object sender, EventArgs e)
        {
            showList();
            foreach (var items in GlobalVar.cartList)
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
            total();
        }

        void total()
        {
            int total = 0;
            for (int i = 0; i < GlobalVar.cartList.Count; i++)
            {
                total += GlobalVar.subtotalList[i] * GlobalVar.quantityList[i];
            }
            lbl_total.Text = string.Format("總金額：{0}元", total);
        }

        private void showList()
        {
            listView_cart.Clear();
            listView_cart.LargeImageList = null;
            listView_cart.SmallImageList = null;
            listView_cart.View = View.Details;

            listView_cart.Columns.Add("", 0);
            listView_cart.Columns.Add("品項", 575);
            listView_cart.Columns.Add("數量", 100);
            listView_cart.Columns.Add("價錢", 98);
            foreach (ColumnHeader column in listView_cart.Columns)
            {
                column.TextAlign = HorizontalAlignment.Center;
            }
            SetHeight(listView_cart, 120);

            for (int i = 0; i < GlobalVar.cartList.Count; i++)
            {
                ListViewItem item = new ListViewItem("");
                string strList = $"麻辣燙  {GlobalVar.cartFlavorList[i].Item3}  內含 :\n\n";
                int subtotal = 0;
                Int32.TryParse(GlobalVar.cartFlavorList[i].Item2, out subtotal);
                for (int j = 0; j < GlobalVar.cartList[i].Count; j++)
                {
                    strList += $"{GlobalVar.cartList[i][j].Item1} * {GlobalVar.cartList[i][j].Item3.ToString()}  ";
                    int price = 0;
                    Int32.TryParse(GlobalVar.cartList[i][j].Item2, out price);
                    subtotal += price * GlobalVar.cartList[i][j].Item3;
                }
                GlobalVar.subtotalList.Add(subtotal);
                subtotal *= GlobalVar.quantityList[i];
                item.SubItems.Add(strList);
                item.SubItems.Add(GlobalVar.quantityList[i].ToString());
                item.SubItems.Add(subtotal.ToString());
                listView_cart.Font = new Font("微軟正黑體", 16);
                listView_cart.Items.Add(item);
                listView_cart.Columns[1].TextAlign = HorizontalAlignment.Left;
            }

            listView_cart.GridLines = false;
            listView_cart.FullRowSelect = true;
        }

        private void SetHeight(ListView listView, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            listView.SmallImageList = imgList;
        }


        private void listView_cart_DrawColumnHeader_1(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 192, 192)), e.Bounds);
            Font headerFont = new Font("微軟正黑體", 18, FontStyle.Bold);

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.Black, e.Bounds, format);
        }

        private void listView_cart_DrawItem_1(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {

            if (listView_cart.Items.Count == 0)
            {
                MessageBox.Show("購物車內沒有東西");
                return;
            }
            if(radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radio_takeout.Checked == true )
            {
                DateTime checkTime = DateTime.Now;

                SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
                con.Open();
                string sql = "insert into orders values(@userid, @datetime, @isTakeOut, @table, 1, null); select SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@userid", GlobalVar.userID);
                cmd.Parameters.AddWithValue("@datetime", checkTime);
                cmd.Parameters.AddWithValue("@isTakeOut", GlobalVar.isTakeout);
                cmd.Parameters.AddWithValue("@table", GlobalVar.isTakeout ? (int?)null : GlobalVar.table);
                int orderID = Convert.ToInt32(cmd.ExecuteScalar());
                for (int i = 0; i < listView_cart.Items.Count; i++)
                {
                    string sql1 = "insert into product values(@orderID, @flavorID, @pQuantity); select SCOPE_IDENTITY();";
                    SqlCommand cmd1 = new SqlCommand(sql1, con);
                    cmd1.Parameters.AddWithValue("@orderID", orderID);
                    cmd1.Parameters.AddWithValue("@flavorID", GlobalVar.cartFlavorList[i].Item1);
                    cmd1.Parameters.AddWithValue("@pQuantity", GlobalVar.quantityList[i]);
                    int pID = Convert.ToInt32(cmd1.ExecuteScalar());
                    for(int j = 0; j < GlobalVar.cartList[i].Count; j++)
                    {
                        string sql2 = "insert into malatang values(@pID, @ingridientID, @IQuantity);";
                        SqlCommand cmd2 = new SqlCommand(sql2, con);
                        cmd2.Parameters.AddWithValue("@pID", pID);
                        cmd2.Parameters.AddWithValue("@ingridientID", GlobalVar.cartList[i][j].Item4);
                        cmd2.Parameters.AddWithValue("@IQuantity", GlobalVar.cartList[i][j].Item3);
                        int rows = cmd2.ExecuteNonQuery();
                    }
                }
                con.Close();
                MessageBox.Show("訂單已送出，請至櫃檯結帳。");
                GlobalVar.orderQuantity.Clear();
                GlobalVar.cartList.Clear();
                GlobalVar.subtotalList.Clear();
                GlobalVar.cartFlavorList.Clear();
                GlobalVar.quantityList.Clear();
                GlobalVar.isChecked = true;
                Close();
            }
            else
            {
                MessageBox.Show("請選擇桌號或外帶");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.table = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.table = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.table = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.table = 4;
        }

        private void radio_takeout_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_takeout.Checked)
            {
                GlobalVar.isTakeout = true;
            }
            else
            {
                GlobalVar.isTakeout = false;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (listView_cart.SelectedItems.Count > 0)
            {
                int q = GlobalVar.quantityList[listView_cart.SelectedIndices[0]];
                q++;
                GlobalVar.quantityList[listView_cart.SelectedIndices[0]]++;
                listView_cart.SelectedItems[0].SubItems[2].Text = q.ToString();
                int price = GlobalVar.subtotalList[listView_cart.SelectedIndices[0]];
                price *= q;
                listView_cart.SelectedItems[0].SubItems[3].Text = price.ToString();
                total();
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (listView_cart.SelectedItems.Count > 0 && GlobalVar.quantityList[listView_cart.SelectedIndices[0]] > 1)
            {
                int q = GlobalVar.quantityList[listView_cart.SelectedIndices[0]];
                q--;
                GlobalVar.quantityList[listView_cart.SelectedIndices[0]]--;
                listView_cart.SelectedItems[0].SubItems[2].Text = q.ToString();
                int price = GlobalVar.subtotalList[listView_cart.SelectedIndices[0]];
                price *= q;
                listView_cart.SelectedItems[0].SubItems[3].Text = price.ToString();
                total();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (listView_cart.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("確定要移除這個品項嗎", "移除品項", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    int index = listView_cart.SelectedIndices[0];
                    listView_cart.Items.RemoveAt(index);
                    GlobalVar.quantityList.RemoveAt(index);
                    GlobalVar.subtotalList.RemoveAt(index);
                    GlobalVar.cartList.RemoveAt(index);
                    GlobalVar.cartFlavorList.RemoveAt(index);
                    total();
                }        
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要清空購物車嗎", "清空購物車", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                listView_cart.Items.Clear();
                GlobalVar.quantityList.Clear();
                GlobalVar.subtotalList.Clear();
                GlobalVar.cartList.Clear();
                GlobalVar.cartFlavorList.Clear();
                lbl_total.Text = "總金額：";
            }
        }
    }
}

