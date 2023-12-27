namespace 期中專題_線上點餐系統
{
    partial class detailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView_detail = new System.Windows.Forms.ListView();
            this.lbl_detailInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "詳細訂單資訊";
            // 
            // listView_detail
            // 
            this.listView_detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listView_detail.HideSelection = false;
            this.listView_detail.Location = new System.Drawing.Point(18, 59);
            this.listView_detail.Name = "listView_detail";
            this.listView_detail.Size = new System.Drawing.Size(702, 221);
            this.listView_detail.TabIndex = 1;
            this.listView_detail.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_detailInfo
            // 
            this.lbl_detailInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_detailInfo.Location = new System.Drawing.Point(391, 35);
            this.lbl_detailInfo.Name = "lbl_detailInfo";
            this.lbl_detailInfo.Size = new System.Drawing.Size(332, 21);
            this.lbl_detailInfo.TabIndex = 2;
            this.lbl_detailInfo.Text = "訂單總金額：   消費日期：";
            // 
            // detailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(735, 292);
            this.Controls.Add(this.lbl_detailInfo);
            this.Controls.Add(this.listView_detail);
            this.Controls.Add(this.label1);
            this.Name = "detailForm";
            this.Text = "detailForm";
            this.Load += new System.EventHandler(this.detailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_detail;
        private System.Windows.Forms.Label lbl_detailInfo;
    }
}