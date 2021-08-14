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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_validateUsername = new System.Windows.Forms.Label();
            this.lbl_checkPass = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_changePass = new System.Windows.Forms.Button();
            this.pb_avatar = new System.Windows.Forms.PictureBox();
            this.txt_validatePass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fullname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.Location = new System.Drawing.Point(746, 50);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(250, 27);
            this.txt_fullname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(598, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đăng nhập";
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(746, 107);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(250, 27);
            this.txt_username.TabIndex = 2;
            this.txt_username.Validated += new System.EventHandler(this.txt_username_Validated);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(598, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật khẩu";
            // 
            // txt_pass
            // 
            this.txt_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(746, 165);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(250, 27);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(598, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // lbl_validateUsername
            // 
            this.lbl_validateUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_validateUsername.AutoSize = true;
            this.lbl_validateUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_validateUsername.ForeColor = System.Drawing.Color.Red;
            this.lbl_validateUsername.Location = new System.Drawing.Point(749, 137);
            this.lbl_validateUsername.Name = "lbl_validateUsername";
            this.lbl_validateUsername.Size = new System.Drawing.Size(10, 15);
            this.lbl_validateUsername.TabIndex = 4;
            this.lbl_validateUsername.Text = " ";
            this.lbl_validateUsername.Validated += new System.EventHandler(this.txt_username_Validated);
            // 
            // lbl_checkPass
            // 
            this.lbl_checkPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_checkPass.AutoSize = true;
            this.lbl_checkPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkPass.ForeColor = System.Drawing.Color.Red;
            this.lbl_checkPass.Location = new System.Drawing.Point(749, 248);
            this.lbl_checkPass.Name = "lbl_checkPass";
            this.lbl_checkPass.Size = new System.Drawing.Size(10, 15);
            this.lbl_checkPass.TabIndex = 4;
            this.lbl_checkPass.Text = " ";
            this.lbl_checkPass.Validated += new System.EventHandler(this.txt_validatePass_Validated);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(28)))));
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_save.Location = new System.Drawing.Point(602, 481);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(194, 50);
            this.btn_save.TabIndex = 112;
            this.btn_save.Text = "Thêm mới";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_changePass
            // 
            this.btn_changePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_changePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(28)))));
            this.btn_changePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_changePass.FlatAppearance.BorderSize = 0;
            this.btn_changePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.btn_changePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changePass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changePass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_changePass.Location = new System.Drawing.Point(802, 481);
            this.btn_changePass.Name = "btn_changePass";
            this.btn_changePass.Size = new System.Drawing.Size(194, 50);
            this.btn_changePass.TabIndex = 113;
            this.btn_changePass.Text = "Làm mới";
            this.btn_changePass.UseVisualStyleBackColor = false;
            this.btn_changePass.Click += new System.EventHandler(this.btn_changePass_Click);
            // 
            // pb_avatar
            // 
            this.pb_avatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_avatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_avatar.Location = new System.Drawing.Point(76, 50);
            this.pb_avatar.Name = "pb_avatar";
            this.pb_avatar.Size = new System.Drawing.Size(381, 481);
            this.pb_avatar.TabIndex = 114;
            this.pb_avatar.TabStop = false;
            this.pb_avatar.Click += new System.EventHandler(this.pb_avatar_Click);
            // 
            // txt_validatePass
            // 
            this.txt_validatePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_validatePass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_validatePass.Location = new System.Drawing.Point(746, 218);
            this.txt_validatePass.Name = "txt_validatePass";
            this.txt_validatePass.Size = new System.Drawing.Size(250, 27);
            this.txt_validatePass.TabIndex = 115;
            this.txt_validatePass.UseSystemPasswordChar = true;
            this.txt_validatePass.Validated += new System.EventHandler(this.txt_validatePass_Validated);
            // 
            // frm_createAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 585);
            this.Controls.Add(this.txt_validatePass);
            this.Controls.Add(this.pb_avatar);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_changePass);
            this.Controls.Add(this.lbl_checkPass);
            this.Controls.Add(this.lbl_validateUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.label2);
            this.Name = "frm_createAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_createAccount";
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_fullname;
        public System.Windows.Forms.TextBox txt_username;
        public System.Windows.Forms.TextBox txt_pass;
        public System.Windows.Forms.Label lbl_validateUsername;
        public System.Windows.Forms.Label lbl_checkPass;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_changePass;
        public System.Windows.Forms.PictureBox pb_avatar;
        public System.Windows.Forms.TextBox txt_validatePass;
    }
}