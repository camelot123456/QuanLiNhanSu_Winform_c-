namespace INDIVIDUAL_PROJECT_CS414SC_2020S.GUI
{
    partial class frm_createAccount
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_validatePass = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_validateUsername = new System.Windows.Forms.Label();
            this.lbl_checkPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(174, 75);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(250, 20);
            this.txt_fullname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đăng nhập";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(174, 118);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(250, 20);
            this.txt_username.TabIndex = 2;
            this.txt_username.Validated += new System.EventHandler(this.txt_username_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật khẩu";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(174, 161);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(250, 20);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // txt_validatePass
            // 
            this.txt_validatePass.Location = new System.Drawing.Point(174, 205);
            this.txt_validatePass.Name = "txt_validatePass";
            this.txt_validatePass.Size = new System.Drawing.Size(250, 20);
            this.txt_validatePass.TabIndex = 2;
            this.txt_validatePass.UseSystemPasswordChar = true;
            // s
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(110, 280);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Tạo";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(269, 280);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_validateUsername
            // 
            this.lbl_validateUsername.AutoSize = true;
            this.lbl_validateUsername.ForeColor = System.Drawing.Color.Red;
            this.lbl_validateUsername.Location = new System.Drawing.Point(177, 141);
            this.lbl_validateUsername.Name = "lbl_validateUsername";
            this.lbl_validateUsername.Size = new System.Drawing.Size(10, 13);
            this.lbl_validateUsername.TabIndex = 4;
            this.lbl_validateUsername.Text = " ";
            // 
            // lbl_checkPass
            // 
            this.lbl_checkPass.AutoSize = true;
            this.lbl_checkPass.ForeColor = System.Drawing.Color.Red;
            this.lbl_checkPass.Location = new System.Drawing.Point(177, 228);
            this.lbl_checkPass.Name = "lbl_checkPass";
            this.lbl_checkPass.Size = new System.Drawing.Size(10, 13);
            this.lbl_checkPass.TabIndex = 4;
            this.lbl_checkPass.Text = " ";
            // 
            // frm_createAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 331);
            this.Controls.Add(this.lbl_checkPass);
            this.Controls.Add(this.lbl_validateUsername);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_validatePass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_createAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_createAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_fullname;
        public System.Windows.Forms.TextBox txt_username;
        public System.Windows.Forms.TextBox txt_pass;
        public System.Windows.Forms.TextBox txt_validatePass;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Label lbl_validateUsername;
        public System.Windows.Forms.Label lbl_checkPass;
    }
}