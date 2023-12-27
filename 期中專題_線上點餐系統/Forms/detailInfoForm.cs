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

namespace 期中專題_線上點餐系統.Forms
{
    public partial class detailInfoForm : Form
    {
        public detailInfoForm()
        {
            InitializeComponent();
        }

        private void detailInfoForm_Load(object sender, EventArgs e)
        {
          
        }

        //void showMList()
        //{
        //    listView_info.Clear();
        //    listView_info.LargeImageList = null;
        //    listView_info.SmallImageList = null;
        //    listView_info.View = View.Details;

        //    SetHeight(listView_info, 20);

        //    SqlConnection con = new SqlConnection(GlobalVar.strDBconnectionString);
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(memberManagementForm.search, con);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    cmd.Parameters.AddWithValue("@searchID", )

        //    //while (reader.Read())
        //    //{
        //    //    ListViewItem item = new ListViewItem();
        //    //    item.SubItems.Add(reader["id"].ToString());
        //    //    item.SubItems.Add((string)reader["name"]);
        //    //    item.SubItems.Add((string)reader["phone"]);
        //    //    listView_member.Font = new Font("微軟正黑體", 12);
        //    //    listView_member.Items.Add(item);
        //    //}

        //    //listView_member.GridLines = false;
        //    //listView_member.FullRowSelect = true;
        //    //reader.Close();
        //    //con.Close();
        //}

        //private void SetHeight(ListView listView, int height)
        //{
        //    ImageList imgList = new ImageList();
        //    imgList.ImageSize = new Size(1, height);
        //    listView.SmallImageList = imgList;
        //}

    }
}
