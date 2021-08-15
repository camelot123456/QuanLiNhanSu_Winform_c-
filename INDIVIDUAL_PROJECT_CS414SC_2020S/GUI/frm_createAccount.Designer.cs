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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_validatePass = new System.Windows.Forms.TextBox();
            this.pb_avatar = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_changePass = new System.Windows.Forms.Button();
            this.lbl_checkPass = new System.Windows.Forms.Label();
            this.lbl_validateUsername = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tenAnh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_free_part = new System.Windows.Forms.Button();
            this.lbl_maTK_del = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Giơi = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.dataGridView_del = new System.Windows.Forms.DataGridView();
            this.lbl_username_del = new System.Windows.Forms.Label();
            this.pb_img_del = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_del)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img_del)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 585);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_validatePass);
            this.tabPage1.Controls.Add(this.pb_avatar);
            this.tabPage1.Controls.Add(this.btn_save);
            this.tabPage1.Controls.Add(this.btn_changePass);
            this.tabPage1.Controls.Add(this.lbl_checkPass);
            this.tabPage1.Controls.Add(this.lbl_validateUsername);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_pass);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_username);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_tenAnh);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_fullname);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1056, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tạo tài khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.pb_img_del);
            this.tabPage2.Controls.Add(this.btn_free_part);
            this.tabPage2.Controls.Add(this.lbl_username_del);
            this.tabPage2.Controls.Add(this.lbl_maTK_del);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.Giơi);
            this.tabPage2.Controls.Add(this.btn_del);
            this.tabPage2.Controls.Add(this.dataGridView_del);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1056, 552);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xóa tài khoản";
            // 
            // txt_validatePass
            // 
            this.txt_validatePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_validatePass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_validatePass.Location = new System.Drawing.Point(738, 204);
            this.txt_validatePass.Name = "txt_validatePass";
            this.txt_validatePass.Size = new System.Drawing.Size(250, 27);
            this.txt_validatePass.TabIndex = 130;
            this.txt_validatePass.UseSystemPasswordChar = true;
            // 
            // pb_avatar
            // 
            this.pb_avatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_avatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_avatar.Location = new System.Drawing.Point(68, 36);
            this.pb_avatar.Name = "pb_avatar";
            this.pb_avatar.Size = new System.Drawing.Size(381, 481);
            this.pb_avatar.TabIndex = 129;
            this.pb_avatar.TabStop = false;
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
            this.btn_save.Location = new System.Drawing.Point(594, 467);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(194, 50);
            this.btn_save.TabIndex = 127;
            this.btn_save.Text = "Thêm mới";
            this.btn_save.UseVisualStyleBackColor = false;
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
            this.btn_changePass.Location = new System.Drawing.Point(794, 467);
            this.btn_changePass.Name = "btn_changePass";
            this.btn_changePass.Size = new System.Drawing.Size(194, 50);
            this.btn_changePass.TabIndex = 128;
            this.btn_changePass.Text = "Làm mới";
            this.btn_changePass.UseVisualStyleBackColor = false;
            // 
            // lbl_checkPass
            // 
            this.lbl_checkPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_checkPass.AutoSize = true;
            this.lbl_checkPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkPass.ForeColor = System.Drawing.Color.Red;
            this.lbl_checkPass.Location = new System.Drawing.Point(741, 234);
            this.lbl_checkPass.Name = "lbl_checkPass";
            this.lbl_checkPass.Size = new System.Drawing.Size(10, 15);
            this.lbl_checkPass.TabIndex = 125;
            this.lbl_checkPass.Text = " ";
            // 
            // lbl_validateUsername
            // 
            this.lbl_validateUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_validateUsername.AutoSize = true;
            this.lbl_validateUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_validateUsername.ForeColor = System.Drawing.Color.Red;
            this.lbl_validateUsername.Location = new System.Drawing.Point(741, 123);
            this.lbl_validateUsername.Name = "lbl_validateUsername";
            this.lbl_validateUsername.Size = new System.Drawing.Size(10, 15);
            this.lbl_validateUsername.TabIndex = 126;
            this.lbl_validateUsername.Text = " ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(590, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 116;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // txt_pass
            // 
            this.txt_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(738, 151);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(250, 27);
            this.txt_pass.TabIndex = 121;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(590, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 117;
            this.label4.Text = "Mật khẩu";
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(738, 93);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(250, 27);
            this.txt_username.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(590, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 118;
            this.label3.Text = "Tên đăng nhập";
            // 
            // txt_tenAnh
            // 
            this.txt_tenAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tenAnh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenAnh.Location = new System.Drawing.Point(738, 252);
            this.txt_tenAnh.Name = "txt_tenAnh";
            this.txt_tenAnh.Size = new System.Drawing.Size(250, 27);
            this.txt_tenAnh.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 119;
            this.label1.Text = "Tên ảnh";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fullname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.Location = new System.Drawing.Point(738, 36);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(250, 27);
            this.txt_fullname.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(590, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 120;
            this.label2.Text = "Họ và tên";
            // 
            // btn_free_part
            // 
            this.btn_free_part.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_free_part.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(28)))));
            this.btn_free_part.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_free_part.FlatAppearance.BorderSize = 0;
            this.btn_free_part.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.btn_free_part.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_free_part.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_free_part.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_free_part.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_free_part.Location = new System.Drawing.Point(732, 128);
            this.btn_free_part.Name = "btn_free_part";
            this.btn_free_part.Size = new System.Drawing.Size(194, 50);
            this.btn_free_part.TabIndex = 210;
            this.btn_free_part.Text = "Xóa id trong bộ nhớ";
            this.btn_free_part.UseVisualStyleBackColor = false;
            this.btn_free_part.Click += new System.EventHandler(this.btn_free_part_Click);
            // 
            // lbl_maTK_del
            // 
            this.lbl_maTK_del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_maTK_del.AutoSize = true;
            this.lbl_maTK_del.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maTK_del.Location = new System.Drawing.Point(434, 3);
            this.lbl_maTK_del.Name = "lbl_maTK_del";
            this.lbl_maTK_del.Size = new System.Drawing.Size(159, 20);
            this.lbl_maTK_del.TabIndex = 209;
            this.lbl_maTK_del.Text = "Kích đúp hàng cần xóa";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(321, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 204;
            this.label9.Text = "Mã tài khoản";
            // 
            // Giơi
            // 
            this.Giơi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Giơi.AutoSize = true;
            this.Giơi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Giơi.Location = new System.Drawing.Point(321, 45);
            this.Giơi.Name = "Giơi";
            this.Giơi.Size = new System.Drawing.Size(107, 20);
            this.Giơi.TabIndex = 205;
            this.Giơi.Text = "Tên đăng nhập";
            // 
            // btn_del
            // 
            this.btn_del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(28)))));
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_del.Location = new System.Drawing.Point(532, 128);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(194, 50);
            this.btn_del.TabIndex = 198;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // dataGridView_del
            // 
            this.dataGridView_del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_del.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_del.Location = new System.Drawing.Point(132, 207);
            this.dataGridView_del.Name = "dataGridView_del";
            this.dataGridView_del.ReadOnly = true;
            this.dataGridView_del.Size = new System.Drawing.Size(794, 341);
            this.dataGridView_del.TabIndex = 197;
            this.dataGridView_del.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_del_CellDoubleClick);
            // 
            // lbl_username_del
            // 
            this.lbl_username_del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_username_del.AutoSize = true;
            this.lbl_username_del.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username_del.Location = new System.Drawing.Point(434, 45);
            this.lbl_username_del.Name = "lbl_username_del";
            this.lbl_username_del.Size = new System.Drawing.Size(159, 20);
            this.lbl_username_del.TabIndex = 209;
            this.lbl_username_del.Text = "Kích đúp hàng cần xóa";
            // 
            // pb_img_del
            // 
            this.pb_img_del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_img_del.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_img_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_img_del.Location = new System.Drawing.Point(132, -7);
            this.pb_img_del.Name = "pb_img_del";
            this.pb_img_del.Size = new System.Drawing.Size(164, 185);
            this.pb_img_del.TabIndex = 211;
            this.pb_img_del.TabStop = false;
            // 
            // frm_createAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 585);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_createAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_createAccount";
            this.Load += new System.EventHandler(this.frm_createAccount_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_del)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img_del)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox txt_validatePass;
        public System.Windows.Forms.PictureBox pb_avatar;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_changePass;
        public System.Windows.Forms.Label lbl_checkPass;
        public System.Windows.Forms.Label lbl_validateUsername;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_tenAnh;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button btn_free_part;
        public System.Windows.Forms.Label lbl_username_del;
        public System.Windows.Forms.Label lbl_maTK_del;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label Giơi;
        public System.Windows.Forms.Button btn_del;
        public System.Windows.Forms.DataGridView dataGridView_del;
        public System.Windows.Forms.PictureBox pb_img_del;
    }
}