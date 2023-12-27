namespace 期中專題_線上點餐系統.Forms
{
    partial class productForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_create = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_save = new FontAwesome.Sharp.IconButton();
            this.btn_delete = new FontAwesome.Sharp.IconButton();
            this.listView_product = new System.Windows.Forms.ListView();
            this.btn_vege = new FontAwesome.Sharp.IconButton();
            this.btn_prot = new FontAwesome.Sharp.IconButton();
            this.btn_main = new FontAwesome.Sharp.IconButton();
            this.btn_other = new FontAwesome.Sharp.IconButton();
            this.btn_5 = new FontAwesome.Sharp.IconButton();
            this.btn_10 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_10);
            this.panel1.Controls.Add(this.btn_5);
            this.panel1.Controls.Add(this.btn_other);
            this.panel1.Controls.Add(this.btn_main);
            this.panel1.Controls.Add(this.btn_prot);
            this.panel1.Controls.Add(this.btn_vege);
            this.panel1.Controls.Add(this.listView_product);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 476);
            this.panel1.TabIndex = 0;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btn_create.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_create.IconColor = System.Drawing.Color.Black;
            this.btn_create.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_create.Location = new System.Drawing.Point(0, 0);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(194, 46);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "新增";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txt_price);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbox_category);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 151);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "新增商品";
            // 
            // cbox_category
            // 
            this.cbox_category.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox_category.FormattingEnabled = true;
            this.cbox_category.Items.AddRange(new object[] {
            "",
            "青菜",
            "肉品",
            "主食/飯",
            "其他",
            "火鍋料/10元",
            "火鍋料/5元"});
            this.cbox_category.Location = new System.Drawing.Point(65, 56);
            this.cbox_category.Name = "cbox_category";
            this.cbox_category.Size = new System.Drawing.Size(110, 32);
            this.cbox_category.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "類別";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(179, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "商品名稱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(419, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "價格";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_name.Location = new System.Drawing.Point(265, 55);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(153, 33);
            this.txt_name.TabIndex = 5;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_price.Location = new System.Drawing.Point(467, 55);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(104, 33);
            this.txt_price.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.btn_create);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 46);
            this.panel3.TabIndex = 7;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_save.IconColor = System.Drawing.Color.Black;
            this.btn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_save.Location = new System.Drawing.Point(194, 0);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(194, 46);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "儲存編輯";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_delete.IconColor = System.Drawing.Color.Black;
            this.btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_delete.Location = new System.Drawing.Point(388, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(194, 46);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "移除商品";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // listView_product
            // 
            this.listView_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listView_product.HideSelection = false;
            this.listView_product.Location = new System.Drawing.Point(202, 0);
            this.listView_product.Name = "listView_product";
            this.listView_product.Size = new System.Drawing.Size(352, 326);
            this.listView_product.TabIndex = 2;
            this.listView_product.UseCompatibleStateImageBehavior = false;
            this.listView_product.SelectedIndexChanged += new System.EventHandler(this.listView_product_SelectedIndexChanged);
            // 
            // btn_vege
            // 
            this.btn_vege.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btn_vege.FlatAppearance.BorderSize = 0;
            this.btn_vege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vege.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_vege.IconColor = System.Drawing.Color.Black;
            this.btn_vege.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_vege.Location = new System.Drawing.Point(18, 12);
            this.btn_vege.Name = "btn_vege";
            this.btn_vege.Size = new System.Drawing.Size(162, 46);
            this.btn_vege.TabIndex = 3;
            this.btn_vege.Text = "青菜";
            this.btn_vege.UseVisualStyleBackColor = false;
            this.btn_vege.Click += new System.EventHandler(this.btn_vege_Click);
            // 
            // btn_prot
            // 
            this.btn_prot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btn_prot.FlatAppearance.BorderSize = 0;
            this.btn_prot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prot.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_prot.IconColor = System.Drawing.Color.Black;
            this.btn_prot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_prot.Location = new System.Drawing.Point(18, 61);
            this.btn_prot.Name = "btn_prot";
            this.btn_prot.Size = new System.Drawing.Size(162, 46);
            this.btn_prot.TabIndex = 4;
            this.btn_prot.Text = "肉品";
            this.btn_prot.UseVisualStyleBackColor = false;
            this.btn_prot.Click += new System.EventHandler(this.btn_prot_Click);
            // 
            // btn_main
            // 
            this.btn_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btn_main.FlatAppearance.BorderSize = 0;
            this.btn_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_main.IconColor = System.Drawing.Color.Black;
            this.btn_main.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_main.Location = new System.Drawing.Point(18, 111);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(162, 46);
            this.btn_main.TabIndex = 5;
            this.btn_main.Text = "主食/飯";
            this.btn_main.UseVisualStyleBackColor = false;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // btn_other
            // 
            this.btn_other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btn_other.FlatAppearance.BorderSize = 0;
            this.btn_other.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_other.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_other.IconColor = System.Drawing.Color.Black;
            this.btn_other.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_other.Location = new System.Drawing.Point(18, 161);
            this.btn_other.Name = "btn_other";
            this.btn_other.Size = new System.Drawing.Size(162, 46);
            this.btn_other.TabIndex = 6;
            this.btn_other.Text = "其他";
            this.btn_other.UseVisualStyleBackColor = false;
            this.btn_other.Click += new System.EventHandler(this.btn_other_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btn_5.FlatAppearance.BorderSize = 0;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_5.IconColor = System.Drawing.Color.Black;
            this.btn_5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_5.Location = new System.Drawing.Point(18, 261);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(162, 46);
            this.btn_5.TabIndex = 7;
            this.btn_5.Text = "火鍋料/5元";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_10
            // 
            this.btn_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btn_10.FlatAppearance.BorderSize = 0;
            this.btn_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_10.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_10.IconColor = System.Drawing.Color.Black;
            this.btn_10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_10.Location = new System.Drawing.Point(18, 211);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(162, 46);
            this.btn_10.TabIndex = 8;
            this.btn_10.Text = "火鍋料/10元";
            this.btn_10.UseVisualStyleBackColor = false;
            this.btn_10.Click += new System.EventHandler(this.btn_10_Click);
            // 
            // productForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 476);
            this.Controls.Add(this.panel1);
            this.Name = "productForm";
            this.Text = "productForm";
            this.Load += new System.EventHandler(this.productForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_create;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_category;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btn_delete;
        private FontAwesome.Sharp.IconButton btn_save;
        private FontAwesome.Sharp.IconButton btn_10;
        private FontAwesome.Sharp.IconButton btn_5;
        private FontAwesome.Sharp.IconButton btn_other;
        private FontAwesome.Sharp.IconButton btn_main;
        private FontAwesome.Sharp.IconButton btn_prot;
        private FontAwesome.Sharp.IconButton btn_vege;
        private System.Windows.Forms.ListView listView_product;
    }
}