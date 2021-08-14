namespace INDIVIDUAL_PROJECT_CS414SC_2020S.GUI
{
    partial class frm_myAcc
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
            this.pb_avatar = new System.Windows.Forms.PictureBox();
            this.lbl_account = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_avatar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_changePass = new System.Windows.Forms.Button();
            this.txt_avatar = new System.Windows.Forms.TextBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_avatar
            // 
            this.pb_avatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_avatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_avatar.Location = new System.Drawing.Point(102, 52);
            this.pb_avatar.Name = "pb_avatar";
            this.pb_avatar.Size = new System.Drawing.Size(381, 481);
            this.pb_avatar.TabIndex = 101;
            this.pb_avatar.TabStop = false;
            this.pb_avatar.Click += new System.EventHandler(this.pb_avatar_Click);
            // 
            // lbl_account
            // 
            this.lbl_account.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_account.AutoSize = true;
            this.lbl_account.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account.Location = new System.Drawing.Point(720, 148);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(84, 20);
            this.lbl_account.TabIndex = 102;
            this.lbl_account.Text = "lbl_account";
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(596, 148);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(97, 20);
            this.lbl_username.TabIndex = 103;
            this.lbl_username.Text = "Tên tài khoản";
            // 
            // lbl_id
            // 
            this.lbl_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(720, 104);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(45, 20);
            this.lbl_id.TabIndex = 104;
            this.lbl_id.Text = "lbl_id";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 105;
            this.label2.Text = "Mã tài khoản";
            // 
            // lbl_avatar
            // 
            this.lbl_avatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_avatar.AutoSize = true;
            this.lbl_avatar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avatar.Location = new System.Drawing.Point(596, 193);
            this.lbl_avatar.Name = "lbl_avatar";
            this.lbl_avatar.Size = new System.Drawing.Size(60, 20);
            this.lbl_avatar.TabIndex = 106;
            this.lbl_avatar.Text = "Tên ảnh";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 107;
            this.label1.Text = "Họ và tên";
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
            this.btn_save.Location = new System.Drawing.Point(595, 483);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(194, 50);
            this.btn_save.TabIndex = 110;
            this.btn_save.Text = "Lưu lại";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            this.btn_changePass.Location = new System.Drawing.Point(795, 483);
            this.btn_changePass.Name = "btn_changePass";
            this.btn_changePass.Size = new System.Drawing.Size(194, 50);
            this.btn_changePass.TabIndex = 111;
            this.btn_changePass.Text = "Đổi mật khẩu";
            this.btn_changePass.UseVisualStyleBackColor = false;
            this.btn_changePass.Click += new System.EventHandler(this.btn_changePass_Click);
            // 
            // txt_avatar
            // 
            this.txt_avatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_avatar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_avatar.Location = new System.Drawing.Point(723, 190);
            this.txt_avatar.Multiline = true;
            this.txt_avatar.Name = "txt_avatar";
            this.txt_avatar.Size = new System.Drawing.Size(266, 221);
            this.txt_avatar.TabIndex = 108;
            // 
            // txt_fullname
            // 
            this.txt_fullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fullname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.Location = new System.Drawing.Point(723, 52);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(266, 27);
            this.txt_fullname.TabIndex = 109;
            // 
            // frm_myAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 585);
            this.Controls.Add(this.pb_avatar);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_avatar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_changePass);
            this.Controls.Add(this.txt_avatar);
            this.Controls.Add(this.txt_fullname);
            this.Name = "frm_myAcc";
            this.Text = "frm_myAcc";
            this.Load += new System.EventHandler(this.frm_myAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pb_avatar;
        public System.Windows.Forms.Label lbl_account;
        public System.Windows.Forms.Label lbl_username;
        public System.Windows.Forms.Label lbl_id;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_avatar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_changePass;
        public System.Windows.Forms.TextBox txt_avatar;
        public System.Windows.Forms.TextBox txt_fullname;
    }
}