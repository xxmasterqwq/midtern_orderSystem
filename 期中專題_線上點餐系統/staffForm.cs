using FontAwesome.Sharp;
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
using 期中專題_線上點餐系統.Forms;

namespace 期中專題_線上點餐系統
{
    public partial class staffForm : Form
    {

        private IconButton currBtn;
        private Panel leftBorderBtn;
        private Form currChildForm;
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        public staffForm()
        {
            InitializeComponent();
        }

        private void staffForm_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "orderdb";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBconnectionString = scsb.ConnectionString;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 95);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        private struct RGBColors
        {
            public static Color color3 = Color.FromArgb(187, 255, 255);
            public static Color color2 = Color.FromArgb(67, 205, 128);
            public static Color color1 = Color.FromArgb(255, 236, 139);
            public static Color color4 = Color.FromArgb(230, 230, 250);
            public static Color color5 = Color.FromArgb(255, 192, 192);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currBtn = (IconButton)senderBtn;
                currBtn.BackColor = Color.FromArgb(37, 36, 81);
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
                currBtn.BackColor = Color.FromArgb(67, 35, 48);
                currBtn.ForeColor = Color.Gainsboro;
                currBtn.TextAlign = ContentAlignment.MiddleLeft;
                currBtn.IconColor = Color.FromArgb(255, 255, 192);
                currBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
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
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
         
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new checkForm());
        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new productForm());
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new memberManagementForm());
        }

        private void btn_orderManagement_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new orderManagementForm());
        }
    }
}
