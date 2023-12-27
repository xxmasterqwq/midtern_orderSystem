namespace 期中專題_線上點餐系統
{
    partial class staffForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_orderManagement = new FontAwesome.Sharp.IconButton();
            this.btn_edit = new FontAwesome.Sharp.IconButton();
            this.btn_stock = new FontAwesome.Sharp.IconButton();
            this.btn_chart = new FontAwesome.Sharp.IconButton();
            this.btn_check = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.panelMenu.Controls.Add(this.btn_orderManagement);
            this.panelMenu.Controls.Add(this.btn_edit);
            this.panelMenu.Controls.Add(this.btn_stock);
            this.panelMenu.Controls.Add(this.btn_chart);
            this.panelMenu.Controls.Add(this.btn_check);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Black;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(218, 552);
            this.panelMenu.TabIndex = 6;
            // 
            // btn_orderManagement
            // 
            this.btn_orderManagement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_orderManagement.FlatAppearance.BorderSize = 0;
            this.btn_orderManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orderManagement.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btn_orderManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_orderManagement.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btn_orderManagement.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_orderManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_orderManagement.IconSize = 36;
            this.btn_orderManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_orderManagement.Location = new System.Drawing.Point(0, 457);
            this.btn_orderManagement.Name = "btn_orderManagement";
            this.btn_orderManagement.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btn_orderManagement.Size = new System.Drawing.Size(218, 95);
            this.btn_orderManagement.TabIndex = 9;
            this.btn_orderManagement.Text = "訂單管理";
            this.btn_orderManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_orderManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_orderManagement.UseVisualStyleBackColor = true;
            this.btn_orderManagement.Click += new System.EventHandler(this.btn_orderManagement_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btn_edit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_edit.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.btn_edit.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_edit.IconSize = 36;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(0, 361);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btn_edit.Size = new System.Drawing.Size(218, 95);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "會員管理";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_stock.FlatAppearance.BorderSize = 0;
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btn_stock.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_stock.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btn_stock.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_stock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_stock.IconSize = 36;
            this.btn_stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stock.Location = new System.Drawing.Point(0, 266);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btn_stock.Size = new System.Drawing.Size(218, 95);
            this.btn_stock.TabIndex = 7;
            this.btn_stock.Text = "商品管理";
            this.btn_stock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_chart
            // 
            this.btn_chart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_chart.FlatAppearance.BorderSize = 0;
            this.btn_chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chart.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btn_chart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_chart.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btn_chart.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_chart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_chart.IconSize = 36;
            this.btn_chart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chart.Location = new System.Drawing.Point(0, 171);
            this.btn_chart.Name = "btn_chart";
            this.btn_chart.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btn_chart.Size = new System.Drawing.Size(218, 95);
            this.btn_chart.TabIndex = 6;
            this.btn_chart.Text = "報表";
            this.btn_chart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_chart.UseVisualStyleBackColor = true;
            this.btn_chart.Click += new System.EventHandler(this.btn_chart_Click);
            // 
            // btn_check
            // 
            this.btn_check.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_check.FlatAppearance.BorderSize = 0;
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btn_check.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_check.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btn_check.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_check.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_check.IconSize = 36;
            this.btn_check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_check.Location = new System.Drawing.Point(0, 76);
            this.btn_check.Name = "btn_check";
            this.btn_check.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btn_check.Size = new System.Drawing.Size(218, 95);
            this.btn_check.TabIndex = 5;
            this.btn_check.Text = "打卡系統";
            this.btn_check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 76);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.lbl_title);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(218, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 76);
            this.panel3.TabIndex = 9;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_title.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_title.Location = new System.Drawing.Point(15, 24);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(110, 31);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "員工頁面";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(218, 76);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(582, 476);
            this.panelMain.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "未來的麻辣燙店LOGO";
            // 
            // staffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.Name = "staffForm";
            this.Text = "staffForm";
            this.Load += new System.EventHandler(this.staffForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_orderManagement;
        private FontAwesome.Sharp.IconButton btn_edit;
        private FontAwesome.Sharp.IconButton btn_stock;
        private FontAwesome.Sharp.IconButton btn_chart;
        private FontAwesome.Sharp.IconButton btn_check;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
    }
}