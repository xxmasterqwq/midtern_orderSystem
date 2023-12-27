namespace 期中專題_線上點餐系統
{
    partial class cart
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
            this.listView_cart = new System.Windows.Forms.ListView();
            this.btn_check = new FontAwesome.Sharp.IconButton();
            this.btn_add = new FontAwesome.Sharp.IconButton();
            this.btn_minus = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radio_takeout = new System.Windows.Forms.RadioButton();
            this.btn_remove = new FontAwesome.Sharp.IconButton();
            this.btn_clear = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_cart
            // 
            this.listView_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listView_cart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_cart.HideSelection = false;
            this.listView_cart.Location = new System.Drawing.Point(12, 56);
            this.listView_cart.Name = "listView_cart";
            this.listView_cart.OwnerDraw = true;
            this.listView_cart.Size = new System.Drawing.Size(773, 329);
            this.listView_cart.TabIndex = 1;
            this.listView_cart.UseCompatibleStateImageBehavior = false;
            this.listView_cart.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView_cart_DrawColumnHeader_1);
            this.listView_cart.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView_cart_DrawItem_1);
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_check.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_check.IconColor = System.Drawing.Color.Black;
            this.btn_check.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_check.Location = new System.Drawing.Point(563, 510);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(218, 58);
            this.btn_check.TabIndex = 2;
            this.btn_check.Text = "結帳";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_add.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_add.IconColor = System.Drawing.Color.Black;
            this.btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_add.Location = new System.Drawing.Point(98, 409);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(45, 45);
            this.btn_add.TabIndex = 124;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_minus.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_minus.IconColor = System.Drawing.Color.Black;
            this.btn_minus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_minus.Location = new System.Drawing.Point(25, 409);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(45, 45);
            this.btn_minus.TabIndex = 123;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio_takeout);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(177, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 156);
            this.panel1.TabIndex = 125;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(76, 56);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "內用桌號";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(169, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(169, 106);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(76, 106);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(49, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(49, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(142, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(142, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(255, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "外帶";
            // 
            // radio_takeout
            // 
            this.radio_takeout.AutoSize = true;
            this.radio_takeout.Location = new System.Drawing.Point(313, 80);
            this.radio_takeout.Name = "radio_takeout";
            this.radio_takeout.Size = new System.Drawing.Size(14, 13);
            this.radio_takeout.TabIndex = 10;
            this.radio_takeout.TabStop = true;
            this.radio_takeout.UseVisualStyleBackColor = true;
            this.radio_takeout.CheckedChanged += new System.EventHandler(this.radio_takeout_CheckedChanged);
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btn_remove.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_remove.IconColor = System.Drawing.Color.Black;
            this.btn_remove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_remove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_remove.Location = new System.Drawing.Point(25, 471);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(118, 45);
            this.btn_remove.TabIndex = 126;
            this.btn_remove.Text = "移除";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn_clear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_clear.IconColor = System.Drawing.Color.Black;
            this.btn_clear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clear.Location = new System.Drawing.Point(25, 523);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(118, 45);
            this.btn_clear.TabIndex = 127;
            this.btn_clear.Text = "清空購物車";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(351, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 35);
            this.label7.TabIndex = 128;
            this.label7.Text = "購物車";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_total.Location = new System.Drawing.Point(557, 445);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(123, 35);
            this.lbl_total.TabIndex = 129;
            this.lbl_total.Text = "總金額：";
            // 
            // cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(797, 579);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.listView_cart);
            this.Name = "cart";
            this.Text = " ";
            this.Load += new System.EventHandler(this.cart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_cart;
        private FontAwesome.Sharp.IconButton btn_check;
        private FontAwesome.Sharp.IconButton btn_add;
        private FontAwesome.Sharp.IconButton btn_minus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_takeout;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btn_remove;
        private FontAwesome.Sharp.IconButton btn_clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_total;
    }
}