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

namespace 期中專題_線上點餐系統.Forms
{
    public partial class orderManagementForm : Form
    {
        public orderManagementForm()
        {
            InitializeComponent();
        }

        private void orderManagementForm_Load(object sender, EventArgs e)
        {
            showList();
        }

        private void showList()
        {
            listView_order.Clear();
            listView_order.LargeImageList = null;
            listView_order.SmallImageList = null;
            listView_order.View = View.Details;

            listView_order.Columns.Add("", 0);
            listView_order.Columns.Add("訂單編號", 100);
            listView_order.Columns.Add("日期", 150);
            listView_order.Columns.Add("金額", 100);
            listView_order.Columns.Add("桌號/外帶", 100);
            listView_order.Columns.Add("狀態", 98);
            foreach (ColumnHeader column in listView_order.Columns)
            {
                column.TextAlign = HorizontalAlignment.Center;
            }
            SetHeight(listView_order, 120);

            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();
            string sql = "select * from orders inner join status on orders.statusID = status.statusID order by orderID desc;";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            List<int> orderIDList = new List<int>();
            List<string> datetimeList = new List<string>();
            List<string> statusList = new List<string>();
            List<string> takeOutList = new List<string>();
            while (reader.Read())
            {
                int orderID = (int)reader["orderID"];
                orderIDList.Add(orderID);
                statusList.Add((string)reader["status"]);
                DateTime datetimeValue = (DateTime)reader["datetime"];
                string formattedDate = datetimeValue.ToString("yyyy-MM-dd");
                datetimeList.Add(formattedDate);
                takeOutList.Add((bool)reader["isTakeOut"] ? "外帶" : $"{reader["[table"]}");
            }
            reader.Close();
            string sql1 = "select product.pQuantity, malatang.IQuantity, ingridient.price as iPrice, flavor.price as fPrice from product " +
                          "right outer join malatang on product.pID = malatang.pID " +
                          "right outer join ingridient on malatang.IngredientID = ingridient.ingridientID " +
                          "right outer join flavor on product.flavorID = flavor.flavorID " +
                          "where orderID = @searchOrderID;";

            for (int i = 0; i < orderIDList.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                cmd1.Parameters.AddWithValue("@searchOrderID", orderIDList[i]);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                int totalPrice = 0;
                int flavorPrice = 0;

                while (reader1.Read())
                {
                    totalPrice += (int)reader1["iPrice"] * (int)reader1["IQuantity"] * (int)reader1["pQuantity"];
                    flavorPrice = (int)reader1["fPrice"] * (int)reader1["pQuantity"];
                }
                totalPrice += flavorPrice;
                item.SubItems.Add(orderIDList[i].ToString());
                item.SubItems.Add(datetimeList[i]);
                item.SubItems.Add(totalPrice.ToString());
                item.SubItems.Add(takeOutList[i].ToString());
                item.SubItems.Add(statusList[i]);
                listView_order.Font = new Font("微軟正黑體", 12);
                listView_order.Items.Add(item);
                reader1.Close();
            }

            listView_order.GridLines = false;
            listView_order.FullRowSelect = true;
            reader.Close();
            con.Close();
        }

        private void SetHeight(ListView listView, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            listView.SmallImageList = imgList;
        }

        private void orderManagementForm_Activated(object sender, EventArgs e)
        {
            showList();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            showList();
        }

        private void btn_refund_Click(object sender, EventArgs e)
        {
            if (listView_order.SelectedItems.Count == 0)
            {
                MessageBox.Show("請先選取訂單");
                return;
            }
            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();
            string sql = "update orders set statusID = 3 where orderID = @searchOrderID;";
            SqlCommand cmd = new SqlCommand(sql, con);
            int orderID = 0;
            Int32.TryParse(listView_order.SelectedItems[0].SubItems[1].Text, out orderID);
            cmd.Parameters.AddWithValue("@searchOrderID", orderID);
            int row = cmd.ExecuteNonQuery();
            con.Close();
            showList();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if(listView_order.SelectedItems.Count == 0)
            {
                MessageBox.Show("請先選取訂單");
            }
            if(txt_pay.Text == "")
            {
                MessageBox.Show("請輸入金額");
            }
            int pay = 0;
            if(Int32.TryParse(txt_pay.Text, out pay))
            {
                int price = 0;
                Int32.TryParse(listView_order.SelectedItems[0].SubItems[3].Text, out price);
                txt_change.Text = (pay - price).ToString();

                SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
                con.Open();
                string sql = "update orders set statusID = 2 where orderID = @searchOrderID;";
                SqlCommand cmd = new SqlCommand(sql, con);
                int orderID = 0;
                Int32.TryParse(listView_order.SelectedItems[0].SubItems[1].Text,out orderID);
                cmd.Parameters.AddWithValue("@searchOrderID", orderID);
                int row = cmd.ExecuteNonQuery();
                con.Close();
                showList();
            }
        }
    }
}
