namespace 期中專題_線上點餐系統.Forms
{
    partial class memberManagementForm
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
            this.btn_search = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_staff = new FontAwesome.Sharp.IconButton();
            this.btn_member = new FontAwesome.Sharp.IconButton();
            this.panel_list = new System.Windows.Forms.Panel();
            this.listView_member = new System.Windows.Forms.ListView();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_edit = new System.Windows.Forms.TextBox();
            this.btn_edit = new FontAwesome.Sharp.IconButton();
            this.btn_save = new FontAwesome.Sharp.IconButton();
            this.btn_detailInfo = new FontAwesome.Sharp.IconButton();
            this.btn_remove = new FontAwesome.Sharp.IconButton();
            this.btn_suspension = new FontAwesome.Sharp.IconButton();
            this.btn_newStaff = new FontAwesome.Sharp.IconButton();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_list.SuspendLayout();
            this.panel_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelMain.Controls.Add(this.btn_detailInfo);
            this.panelMain.Controls.Add(this.panel_edit);
            this.panelMain.Controls.Add(this.btn_search);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.txt_phone);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.txt_name);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panel_list);
            this.panelMain.Controls.Add(this.btn_newStaff);
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(582, 476);
            this.panelMain.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_search.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_search.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_search.IconColor = System.Drawing.Color.Black;
            this.btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_search.Location = new System.Drawing.Point(388, 324);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(194, 76);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "查詢";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(405, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "電話";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_phone.Location = new System.Drawing.Point(409, 282);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(161, 35);
            this.txt_phone.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(405, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "姓名";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_name.Location = new System.Drawing.Point(409, 211);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(161, 35);
            this.txt_name.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_staff);
            this.panel1.Controls.Add(this.btn_member);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 76);
            this.panel1.TabIndex = 2;
            // 
            // btn_staff
            // 
            this.btn_staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_staff.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_staff.FlatAppearance.BorderSize = 0;
            this.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staff.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_staff.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_staff.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_staff.IconColor = System.Drawing.Color.Black;
            this.btn_staff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_staff.Location = new System.Drawing.Point(388, 0);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Size = new System.Drawing.Size(194, 76);
            this.btn_staff.TabIndex = 2;
            this.btn_staff.Text = "員工表單";
            this.btn_staff.UseVisualStyleBackColor = false;
            this.btn_staff.Click += new System.EventHandler(this.btn_staff_Click);
            // 
            // btn_member
            // 
            this.btn_member.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_member.FlatAppearance.BorderSize = 0;
            this.btn_member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_member.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_member.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_member.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_member.IconColor = System.Drawing.Color.Black;
            this.btn_member.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_member.Location = new System.Drawing.Point(0, 0);
            this.btn_member.Name = "btn_member";
            this.btn_member.Size = new System.Drawing.Size(390, 76);
            this.btn_member.TabIndex = 1;
            this.btn_member.Text = "會員表單";
            this.btn_member.UseVisualStyleBackColor = false;
            this.btn_member.Click += new System.EventHandler(this.btn_member_Click);
            // 
            // panel_list
            // 
            this.panel_list.Controls.Add(this.listView_member);
            this.panel_list.Location = new System.Drawing.Point(0, 0);
            this.panel_list.Name = "panel_list";
            this.panel_list.Size = new System.Drawing.Size(390, 325);
            this.panel_list.TabIndex = 9;
            // 
            // listView_member
            // 
            this.listView_member.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listView_member.HideSelection = false;
            this.listView_member.Location = new System.Drawing.Point(0, 0);
            this.listView_member.Name = "listView_member";
            this.listView_member.Size = new System.Drawing.Size(390, 325);
            this.listView_member.TabIndex = 3;
            this.listView_member.UseCompatibleStateImageBehavior = false;
            // 
            // panel_edit
            // 
            this.panel_edit.Controls.Add(this.btn_remove);
            this.panel_edit.Controls.Add(this.btn_suspension);
            this.panel_edit.Controls.Add(this.btn_save);
            this.panel_edit.Controls.Add(this.btn_edit);
            this.panel_edit.Controls.Add(this.txt_edit);
            this.panel_edit.Controls.Add(this.label3);
            this.panel_edit.Location = new System.Drawing.Point(405, 13);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(165, 305);
            this.panel_edit.TabIndex = 10;
            this.panel_edit.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "編輯";
            // 
            // txt_edit
            // 
            this.txt_edit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edit.Location = new System.Drawing.Point(12, 36);
            this.txt_edit.Name = "txt_edit";
            this.txt_edit.Size = new System.Drawing.Size(138, 29);
            this.txt_edit.TabIndex = 7;
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_edit.IconColor = System.Drawing.Color.Black;
            this.btn_edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_edit.Location = new System.Drawing.Point(12, 71);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(138, 39);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "修改";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_save.IconColor = System.Drawing.Color.Black;
            this.btn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_save.Location = new System.Drawing.Point(12, 116);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(138, 39);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "儲存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_detailInfo
            // 
            this.btn_detailInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_detailInfo.FlatAppearance.BorderSize = 0;
            this.btn_detailInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detailInfo.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_detailInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_detailInfo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_detailInfo.IconColor = System.Drawing.Color.Black;
            this.btn_detailInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_detailInfo.Location = new System.Drawing.Point(0, 324);
            this.btn_detailInfo.Name = "btn_detailInfo";
            this.btn_detailInfo.Size = new System.Drawing.Size(390, 76);
            this.btn_detailInfo.TabIndex = 11;
            this.btn_detailInfo.Text = "詳細資料";
            this.btn_detailInfo.UseVisualStyleBackColor = false;
            this.btn_detailInfo.Click += new System.EventHandler(this.btn_detailInfo_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_remove.IconColor = System.Drawing.Color.Black;
            this.btn_remove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_remove.Location = new System.Drawing.Point(12, 201);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(138, 39);
            this.btn_remove.TabIndex = 14;
            this.btn_remove.Text = "刪除此會員";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_suspension
            // 
            this.btn_suspension.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suspension.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_suspension.IconColor = System.Drawing.Color.Black;
            this.btn_suspension.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_suspension.Location = new System.Drawing.Point(12, 246);
            this.btn_suspension.Name = "btn_suspension";
            this.btn_suspension.Size = new System.Drawing.Size(138, 39);
            this.btn_suspension.TabIndex = 13;
            this.btn_suspension.Text = "停權";
            this.btn_suspension.UseVisualStyleBackColor = true;
            this.btn_suspension.Click += new System.EventHandler(this.btn_suspension_Click);
            // 
            // btn_newStaff
            // 
            this.btn_newStaff.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newStaff.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_newStaff.IconColor = System.Drawing.Color.Black;
            this.btn_newStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_newStaff.Location = new System.Drawing.Point(409, 114);
            this.btn_newStaff.Name = "btn_newStaff";
            this.btn_newStaff.Size = new System.Drawing.Size(138, 39);
            this.btn_newStaff.TabIndex = 12;
            this.btn_newStaff.Text = "新增員工資料";
            this.btn_newStaff.UseVisualStyleBackColor = true;
            this.btn_newStaff.Click += new System.EventHandler(this.btn_newStaff_Click);
            // 
            // memberManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 476);
            this.Controls.Add(this.panelMain);
            this.Name = "memberManagementForm";
            this.Text = "memberManagementForm";
            this.Load += new System.EventHandler(this.memberManagementForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel_list.ResumeLayout(false);
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ListView listView_member;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_member;
        private FontAwesome.Sharp.IconButton btn_search;
        private FontAwesome.Sharp.IconButton btn_staff;
        private System.Windows.Forms.Panel panel_list;
        private System.Windows.Forms.Panel panel_edit;
        private FontAwesome.Sharp.IconButton btn_edit;
        private System.Windows.Forms.TextBox txt_edit;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btn_save;
        private FontAwesome.Sharp.IconButton btn_detailInfo;
        private FontAwesome.Sharp.IconButton btn_remove;
        private FontAwesome.Sharp.IconButton btn_suspension;
        private FontAwesome.Sharp.IconButton btn_newStaff;
    }
}