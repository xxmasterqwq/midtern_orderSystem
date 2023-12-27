namespace 期中專題_線上點餐系統
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_forget = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_visit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_login.Location = new System.Drawing.Point(554, 202);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(108, 44);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "登入";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(232, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "手機 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(232, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼 :";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_phone.Location = new System.Drawing.Point(326, 168);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(193, 39);
            this.txt_phone.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_password.Location = new System.Drawing.Point(326, 236);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(193, 39);
            this.txt_password.TabIndex = 4;
            // 
            // btn_forget
            // 
            this.btn_forget.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_forget.Location = new System.Drawing.Point(430, 325);
            this.btn_forget.Name = "btn_forget";
            this.btn_forget.Size = new System.Drawing.Size(118, 44);
            this.btn_forget.TabIndex = 5;
            this.btn_forget.Text = "忘記密碼";
            this.btn_forget.UseVisualStyleBackColor = true;
            this.btn_forget.Click += new System.EventHandler(this.btn_forget_Click);
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_register.Location = new System.Drawing.Point(306, 325);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(118, 44);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "帳號申請";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_visit
            // 
            this.btn_visit.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_visit.Location = new System.Drawing.Point(554, 325);
            this.btn_visit.Name = "btn_visit";
            this.btn_visit.Size = new System.Drawing.Size(119, 44);
            this.btn_visit.TabIndex = 7;
            this.btn_visit.Text = "訪客登入";
            this.btn_visit.UseVisualStyleBackColor = true;
            this.btn_visit.Click += new System.EventHandler(this.btn_visit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.btn_visit);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_forget);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_forget;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_visit;
    }
}

