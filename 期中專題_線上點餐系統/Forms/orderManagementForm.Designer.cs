namespace 期中專題_線上點餐系統.Forms
{
    partial class orderManagementForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reset = new FontAwesome.Sharp.IconButton();
            this.btn_refund = new FontAwesome.Sharp.IconButton();
            this.btn_check = new FontAwesome.Sharp.IconButton();
            this.listView_order = new System.Windows.Forms.ListView();
            this.txt_pay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_change = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.txt_change);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.txt_pay);
            this.panelMain.Controls.Add(this.listView_order);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(582, 476);
            this.panelMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_check);
            this.panel1.Controls.Add(this.btn_refund);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 76);
            this.panel1.TabIndex = 2;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_reset.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_reset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_reset.IconColor = System.Drawing.Color.Black;
            this.btn_reset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_reset.Location = new System.Drawing.Point(0, 0);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(194, 76);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "刷新";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_refund
            // 
            this.btn_refund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_refund.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_refund.FlatAppearance.BorderSize = 0;
            this.btn_refund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refund.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_refund.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_refund.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_refund.IconColor = System.Drawing.Color.Black;
            this.btn_refund.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_refund.Location = new System.Drawing.Point(194, 0);
            this.btn_refund.Name = "btn_refund";
            this.btn_refund.Size = new System.Drawing.Size(194, 76);
            this.btn_refund.TabIndex = 2;
            this.btn_refund.Text = "退款";
            this.btn_refund.UseVisualStyleBackColor = false;
            this.btn_refund.Click += new System.EventHandler(this.btn_refund_Click);
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_check.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_check.FlatAppearance.BorderSize = 0;
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_check.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_check.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_check.IconColor = System.Drawing.Color.Black;
            this.btn_check.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_check.Location = new System.Drawing.Point(388, 0);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(194, 76);
            this.btn_check.TabIndex = 3;
            this.btn_check.Text = "結帳";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // listView_order
            // 
            this.listView_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listView_order.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView_order.HideSelection = false;
            this.listView_order.Location = new System.Drawing.Point(0, 0);
            this.listView_order.Name = "listView_order";
            this.listView_order.Size = new System.Drawing.Size(582, 352);
            this.listView_order.TabIndex = 3;
            this.listView_order.UseCompatibleStateImageBehavior = false;
            // 
            // txt_pay
            // 
            this.txt_pay.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_pay.Location = new System.Drawing.Point(104, 359);
            this.txt_pay.Name = "txt_pay";
            this.txt_pay.Size = new System.Drawing.Size(186, 35);
            this.txt_pay.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "付款金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(334, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "找錢";
            // 
            // txt_change
            // 
            this.txt_change.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_change.Location = new System.Drawing.Point(388, 359);
            this.txt_change.Name = "txt_change";
            this.txt_change.ReadOnly = true;
            this.txt_change.Size = new System.Drawing.Size(191, 35);
            this.txt_change.TabIndex = 6;
            // 
            // orderManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(582, 475);
            this.Controls.Add(this.panelMain);
            this.Name = "orderManagementForm";
            this.Text = "orderManagementForm";
            this.Activated += new System.EventHandler(this.orderManagementForm_Activated);
            this.Load += new System.EventHandler(this.orderManagementForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_check;
        private FontAwesome.Sharp.IconButton btn_refund;
        private FontAwesome.Sharp.IconButton btn_reset;
        private System.Windows.Forms.ListView listView_order;
        private System.Windows.Forms.TextBox txt_pay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_change;
        private System.Windows.Forms.Label label1;
    }
}