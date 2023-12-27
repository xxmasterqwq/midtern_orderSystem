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
using System.CodeDom.Compiler;
using System.Net.Http;

namespace 期中專題_線上點餐系統
{
    public partial class checlListForm : Form
    {
        public checlListForm()
        {
            InitializeComponent();
        }

        private void checlListForm_Load(object sender, EventArgs e)
        {
            showList();
            Console.WriteLine("hi");
        }

        private void showList()
        {

            listView_checkList.Clear();
            listView_checkList.LargeImageList = null;
            listView_checkList.SmallImageList = null;
            listView_checkList.View = View.Details;

            listView_checkList.Columns.Add("", 0);
            listView_checkList.Columns.Add("訂單編號", 100);
            listView_checkList.Columns.Add("日期", 183);
            listView_checkList.Columns.Add("金額", 100);
            listView_checkList.Columns.Add("狀態", 98);
            foreach (ColumnHeader column in listView_checkList.Columns)
            {
                column.TextAlign = HorizontalAlignment.Center;
            }
            SetHeight(listView_checkList, 120);

            SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
            con.Open();
            string sql = "select * from orders right outer join status on orders.statusID = status.statusID where customerID = @searchID  order by orderID desc;";
            //string sql = "select * from orders right outer join product on orders.orderID = product.orderID " +
            //             "right outer join malatang on product.pID = malatang.pID " +
            //             "right outer join ingridient on malatang.IngredientID = ingridient.ingridientID " +
            //             "right outer join flavor on product.flavorID = flavor.flavorID " +
            //             "right outer join status on orders.statusID = status.statusID " +
            //             "where customerID = @searchID;";
            SqlCommand cmd = new SqlCommand(sql, con);
            
            cmd.Parameters.AddWithValue("@searchID", GlobalVar.userID);
            SqlDataReader reader = cmd.ExecuteReader();
            List<int> orderIDList = new List<int>();
            List<string> datetimeList = new List<string>();
            List<string> statusList = new List<string>();
            while (reader.Read())
            {
                int orderID = (int)reader["orderID"];
                orderIDList.Add(orderID);
                statusList.Add((string)reader["status"]);
                DateTime datetimeValue = (DateTime)reader["datetime"];
                string formattedDate = datetimeValue.ToString("yyyy-MM-dd");
                datetimeList.Add(formattedDate);
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
                item.SubItems.Add(statusList[i]);
                listView_checkList.Font = new Font("微軟正黑體", 12);
                listView_checkList.Items.Add(item);
                reader1.Close();
            }
            
            listView_checkList.GridLines = false;
            listView_checkList.FullRowSelect = true;
            reader.Close();
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
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 192, 192)), e.Bounds);
            Font headerFont = new Font("微軟正黑體", 16, FontStyle.Bold);

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.Black, e.Bounds, format);
        }

        private void listView_checkList_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView_checkList_DoubleClick(object sender, EventArgs e)
        {
            if (listView_checkList.SelectedItems.Count > 0)
            {
                Int32.TryParse(listView_checkList.SelectedItems[0].SubItems[1].Text, out GlobalVar.detailOrderID);
                Int32.TryParse(listView_checkList.SelectedItems[0].SubItems[3].Text, out GlobalVar.detailPrice);
                GlobalVar.detailTime = listView_checkList.SelectedItems[0].SubItems[2].Text;
                detailForm detailForm = new detailForm();
                detailForm.ShowDialog();
            }
        }
    }
}
