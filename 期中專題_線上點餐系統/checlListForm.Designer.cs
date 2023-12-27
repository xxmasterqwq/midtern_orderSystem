namespace 期中專題_線上點餐系統
{
    partial class checlListForm
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
            this.listView_checkList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView_checkList
            // 
            this.listView_checkList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listView_checkList.HideSelection = false;
            this.listView_checkList.Location = new System.Drawing.Point(12, 47);
            this.listView_checkList.Name = "listView_checkList";
            this.listView_checkList.OwnerDraw = true;
            this.listView_checkList.Size = new System.Drawing.Size(485, 470);
            this.listView_checkList.TabIndex = 0;
            this.listView_checkList.UseCompatibleStateImageBehavior = false;
            this.listView_checkList.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView_checkList_DrawColumnHeader);
            this.listView_checkList.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView_checkList_DrawItem);
            this.listView_checkList.DoubleClick += new System.EventHandler(this.listView_checkList_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(201, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "訂單記錄";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(286, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "*僅能查看到六個月內的消費記錄";
            // 
            // checlListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(509, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_checkList);
            this.Name = "checlListForm";
            this.Text = "checlListForm";
            this.Load += new System.EventHandler(this.checlListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_checkList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}