namespace 期中專題_線上點餐系統.Forms
{
    partial class detailInfoForm
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
            this.listView_info = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView_info);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 325);
            this.panel1.TabIndex = 0;
            // 
            // listView_info
            // 
            this.listView_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listView_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_info.HideSelection = false;
            this.listView_info.Location = new System.Drawing.Point(0, 0);
            this.listView_info.Name = "listView_info";
            this.listView_info.Size = new System.Drawing.Size(390, 325);
            this.listView_info.TabIndex = 0;
            this.listView_info.UseCompatibleStateImageBehavior = false;
            // 
            // detailInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(391, 324);
            this.Controls.Add(this.panel1);
            this.Name = "detailInfoForm";
            this.Text = "detailInfoForm";
            this.Load += new System.EventHandler(this.detailInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView_info;
    }
}