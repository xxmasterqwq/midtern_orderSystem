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
    public partial class detailForm : Form
    {
        public detailForm()
        {
            InitializeComponent();
        }

        private void detailForm_Load(object sender, EventArgs e)
        {
            lbl_detailInfo.Text = string.Format("訂單總金額：{0}   消費日期：{1}", GlobalVar.detailPrice.ToString(), GlobalVar.detailTime);
            showList();
        }
        private void showList()
        {
            listView_detail.Clear();
            listView_detail.LargeImageList = null;
            listView_detail.SmallImageList = null;
            listView_detail.View = View.Details;

            listView_detail.Columns.Add("", 0);
            listView_detail.Columns.Add("編號", 100);
            listView_detail.Columns.Add("品項內容", 400);
            listView_detail.Columns.Add("數量", 98);
            listView_detail.Columns.Add("金額", 100);
            foreach (ColumnHeader column in listView_detail.Columns)
            {
                column.TextAlign = HorizontalAlignment.Center;
            }
            SetHeight(listView_detail, 120);

            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();

            string sql = "select * from product right outer join flavor on product.flavorID = flavor.flavorID where orderID = @searchOrderID;";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@searchOrderID", GlobalVar.detailOrderID);
            SqlDataReader reader = cmd.ExecuteReader();
            List<int> pIDList = new List<int>();
            List<string> flavorList = new List<string>();
            List<int> pQuantityList = new List<int>();
            while (reader.Read())
            {
                pIDList.Add((int)reader["pID"]);
                flavorList.Add((string)reader["flavorName"]);
                pQuantityList.Add((int)reader["pQuantity"]);
            }
            reader.Close();

            string sql1 = "select product.pQuantity, malatang.IQuantity, ingridient.price as iPrice, ingridient.ingridientName as ingridientName, flavor.price as fPrice from product " +
                          "right outer join malatang on product.pID = malatang.pID " +
                          "right outer join ingridient on malatang.IngredientID = ingridient.ingridientID " +
                          "right outer join flavor on product.flavorID = flavor.flavorID " +
                          "where product.pID = @searchpID order by ingridient.ingridientID";

            for (int i = 0; i < pIDList.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                cmd1.Parameters.AddWithValue("@searchpID", pIDList[i]);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                int subtotalPrice = 0;
                int flavorPrice = 0;
                string detailContent = $"麻辣燙  {flavorList[i]} \n";
                while (reader1.Read())
                {
                    subtotalPrice += (int)reader1["iPrice"] * (int)reader1["IQuantity"] * (int)reader1["pQuantity"];
                    flavorPrice = (int)reader1["fPrice"] * (int)reader1["pQuantity"];
                    detailContent += $"{(string)reader1["ingridientName"]} * {reader1["IQuantity"]}  ";
                }
                subtotalPrice += flavorPrice;
                item.SubItems.Add((i + 1).ToString());
                item.SubItems.Add(detailContent);
                item.SubItems.Add(pQuantityList[i].ToString());
                item.SubItems.Add(subtotalPrice.ToString());
                listView_detail.Font = new Font("微軟正黑體", 12);
                listView_detail.Items.Add(item);
                listView_detail.Columns[2].TextAlign = HorizontalAlignment.Left;
                reader1.Close();
            }

            listView_detail.GridLines = false;
            listView_detail.FullRowSelect = true;
            con.Close();
        }

        private void SetHeight(ListView listView, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            listView.SmallImageList = imgList;
        }

        private void listView_checkList_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

    }
}
