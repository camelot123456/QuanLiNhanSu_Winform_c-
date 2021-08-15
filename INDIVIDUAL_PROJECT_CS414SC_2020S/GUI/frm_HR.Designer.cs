namespace INDIVIDUAL_PROJECT_CS414SC_2020S.GUI
{
    partial class frm_HR
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
            this.btn_free = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.cb_typeJob = new System.Windows.Forms.ComboBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.txt_img = new System.Windows.Forms.TextBox();
            this.lbl_thongBaoImg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Giơi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_manv = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_free
            // 
            this.btn_free.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_free.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(28)))));
            this.btn_free.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_free.FlatAppearance.BorderSize = 0;
            this.btn_free.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.btn_free.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_free.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_free.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_free.Location = new System.Drawing.Point(609, 322);
            this.btn_free.Name = "btn_free";
            this.btn_free.Size = new System.Drawing.Size(194, 50);
            this.btn_free.TabIndex = 145;
            this.btn_free.Text = "Xóa id trong bộ nhớ";
            this.btn_free.UseVisualStyleBackColor = false;
            this.btn_free.Click += new System.EventHandler(this.btn_free_Click);
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
            this.btn_del.Location = new System.Drawing.Point(412, 322);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(194, 50);
            this.btn_del.TabIndex = 144;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(28)))));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_update.Location = new System.Drawing.Point(212, 322);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(194, 50);
            this.btn_update.TabIndex = 146;
            this.btn_update.Text = "Cập nhập";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(28)))));
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add.Location = new System.Drawing.Point(12, 322);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(194, 50);
            this.btn_add.TabIndex = 147;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_department
            // 
            this.cb_department.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_department.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Items.AddRange(new object[] {
            "Nhân sự",
            "Kế toán"});
            this.cb_department.Location = new System.Drawing.Point(123, 201);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(238, 28);
            this.cb_department.TabIndex = 143;
            // 
            // cb_typeJob
            // 
            this.cb_typeJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_typeJob.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_typeJob.FormattingEnabled = true;
            this.cb_typeJob.Items.AddRange(new object[] {
            "Fulltime",
            "Parttime"});
            this.cb_typeJob.Location = new System.Drawing.Point(123, 245);
            this.cb_typeJob.Name = "cb_typeJob";
            this.cb_typeJob.Size = new System.Drawing.Size(238, 28);
            this.cb_typeJob.TabIndex = 142;
            // 
            // cb_gender
            // 
            this.cb_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_gender.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gender.Location = new System.Drawing.Point(123, 158);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(238, 28);
            this.cb_gender.TabIndex = 141;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_dob.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dob.Location = new System.Drawing.Point(123, 118);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(238, 27);
            this.dtp_dob.TabIndex = 140;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(794, 287);
            this.dataGridView1.TabIndex = 139;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pb_img
            // 
            this.pb_img.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_img.Location = new System.Drawing.Point(565, 44);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(164, 185);
            this.pb_img.TabIndex = 138;
            this.pb_img.TabStop = false;
            this.pb_img.Click += new System.EventHandler(this.pb_img_Click);
            // 
            // txt_img
            // 
            this.txt_img.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_img.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_img.Location = new System.Drawing.Point(565, 245);
            this.txt_img.Name = "txt_img";
            this.txt_img.Size = new System.Drawing.Size(238, 27);
            this.txt_img.TabIndex = 137;
            // 
            // lbl_thongBaoImg
            // 
            this.lbl_thongBaoImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_thongBaoImg.AutoSize = true;
            this.lbl_thongBaoImg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thongBaoImg.ForeColor = System.Drawing.Color.Red;
            this.lbl_thongBaoImg.Location = new System.Drawing.Point(561, 275);
            this.lbl_thongBaoImg.Name = "lbl_thongBaoImg";
            this.lbl_thongBaoImg.Size = new System.Drawing.Size(10, 15);
            this.lbl_thongBaoImg.TabIndex = 134;
            this.lbl_thongBaoImg.Text = " ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 132;
            this.label7.Text = "Ảnh đại diện";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 135;
            this.label8.Text = "Loại việc";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 136;
            this.label9.Text = "Phòng ban";
            // 
            // Giơi
            // 
            this.Giơi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Giơi.AutoSize = true;
            this.Giơi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Giơi.Location = new System.Drawing.Point(16, 161);
            this.Giơi.Name = "Giơi";
            this.Giơi.Size = new System.Drawing.Size(65, 20);
            this.Giơi.TabIndex = 130;
            this.Giơi.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 129;
            this.label4.Text = "Ngày vào làm";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(123, 73);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(238, 27);
            this.txt_name.TabIndex = 131;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 128;
            this.label3.Text = "Tên";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 128;
            this.label1.Text = "Mã nhân viên";
            // 
            // lbl_manv
            // 
            this.lbl_manv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_manv.AutoSize = true;
            this.lbl_manv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manv.Location = new System.Drawing.Point(119, 29);
            this.lbl_manv.Name = "lbl_manv";
            this.lbl_manv.Size = new System.Drawing.Size(222, 20);
            this.lbl_manv.TabIndex = 148;
            this.lbl_manv.Text = "Kích đúp hàng cần sửa hoặc xóa";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(347, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 15);
            this.label5.TabIndex = 149;
            this.label5.Text = "(Chỉ xử lý sửa hoặc xóa)";
            // 
            // frm_HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 675);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_manv);
            this.Controls.Add(this.btn_free);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_department);
            this.Controls.Add(this.cb_typeJob);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.dtp_dob);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pb_img);
            this.Controls.Add(this.txt_img);
            this.Controls.Add(this.lbl_thongBaoImg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Giơi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Name = "frm_HR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_HR";
            this.Load += new System.EventHandler(this.frm_HR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_free;
        public System.Windows.Forms.Button btn_del;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.ComboBox cb_department;
        public System.Windows.Forms.ComboBox cb_typeJob;
        public System.Windows.Forms.ComboBox cb_gender;
        public System.Windows.Forms.DateTimePicker dtp_dob;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.PictureBox pb_img;
        public System.Windows.Forms.TextBox txt_img;
        private System.Windows.Forms.Label lbl_thongBaoImg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Giơi;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbl_manv;
    }
}