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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Giơi = new System.Windows.Forms.Label();
            this.txt_img = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.cb_typeJob = new System.Windows.Forms.ComboBox();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_thongBaoImg = new System.Windows.Forms.Label();
            this.btn_free = new System.Windows.Forms.Button();
            this.lbl_ThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(123, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(238, 27);
            this.txt_name.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày vào làm";
            // 
            // Giơi
            // 
            this.Giơi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Giơi.AutoSize = true;
            this.Giơi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Giơi.Location = new System.Drawing.Point(16, 100);
            this.Giơi.Name = "Giơi";
            this.Giơi.Size = new System.Drawing.Size(65, 20);
            this.Giơi.TabIndex = 1;
            this.Giơi.Text = "Giới tính";
            // 
            // txt_img
            // 
            this.txt_img.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_img.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_img.Location = new System.Drawing.Point(565, 184);
            this.txt_img.Name = "txt_img";
            this.txt_img.Size = new System.Drawing.Size(238, 27);
            this.txt_img.TabIndex = 8;
            this.txt_img.Validated += new System.EventHandler(this.txt_img_Validated);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ảnh đại diện";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Loại việc";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Phòng ban";
            // 
            // pb_img
            // 
            this.pb_img.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_img.Location = new System.Drawing.Point(565, -17);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(164, 185);
            this.pb_img.TabIndex = 11;
            this.pb_img.TabStop = false;
            this.pb_img.Click += new System.EventHandler(this.pb_img_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(794, 287);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dtp_dob
            // 
            this.dtp_dob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_dob.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dob.Location = new System.Drawing.Point(123, 57);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(238, 27);
            this.dtp_dob.TabIndex = 13;
            // 
            // cb_gender
            // 
            this.cb_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_gender.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gender.Location = new System.Drawing.Point(123, 97);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(238, 28);
            this.cb_gender.TabIndex = 14;
            // 
            // cb_typeJob
            // 
            this.cb_typeJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_typeJob.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_typeJob.FormattingEnabled = true;
            this.cb_typeJob.Items.AddRange(new object[] {
            "Fulltime",
            "Parttime"});
            this.cb_typeJob.Location = new System.Drawing.Point(123, 184);
            this.cb_typeJob.Name = "cb_typeJob";
            this.cb_typeJob.Size = new System.Drawing.Size(238, 28);
            this.cb_typeJob.TabIndex = 14;
            // 
            // cb_department
            // 
            this.cb_department.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_department.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Items.AddRange(new object[] {
            "Nhân sự",
            "Kế toán"});
            this.cb_department.Location = new System.Drawing.Point(123, 140);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(238, 28);
            this.cb_department.TabIndex = 14;
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
            this.btn_del.Location = new System.Drawing.Point(412, 261);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(194, 50);
            this.btn_del.TabIndex = 125;
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
            this.btn_update.Location = new System.Drawing.Point(212, 261);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(194, 50);
            this.btn_update.TabIndex = 126;
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
            this.btn_add.Location = new System.Drawing.Point(12, 261);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(194, 50);
            this.btn_add.TabIndex = 127;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_thongBaoImg
            // 
            this.lbl_thongBaoImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_thongBaoImg.AutoSize = true;
            this.lbl_thongBaoImg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thongBaoImg.ForeColor = System.Drawing.Color.Red;
            this.lbl_thongBaoImg.Location = new System.Drawing.Point(561, 214);
            this.lbl_thongBaoImg.Name = "lbl_thongBaoImg";
            this.lbl_thongBaoImg.Size = new System.Drawing.Size(10, 15);
            this.lbl_thongBaoImg.TabIndex = 4;
            this.lbl_thongBaoImg.Text = " ";
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
            this.btn_free.Location = new System.Drawing.Point(609, 261);
            this.btn_free.Name = "btn_free";
            this.btn_free.Size = new System.Drawing.Size(194, 50);
            this.btn_free.TabIndex = 125;
            this.btn_free.Text = "Xóa id trong bộ nhớ";
            this.btn_free.UseVisualStyleBackColor = false;
            this.btn_free.Click += new System.EventHandler(this.btn_free_Click);
            // 
            // lbl_ThongBao
            // 
            this.lbl_ThongBao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ThongBao.AutoSize = true;
            this.lbl_ThongBao.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbl_ThongBao.Location = new System.Drawing.Point(301, 313);
            this.lbl_ThongBao.Name = "lbl_ThongBao";
            this.lbl_ThongBao.Size = new System.Drawing.Size(19, 13);
            this.lbl_ThongBao.TabIndex = 4;
            this.lbl_ThongBao.Text = "    ";
            this.lbl_ThongBao.Validated += new System.EventHandler(this.label1_Validated);
            // 
            // frm_HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 639);
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
            this.Controls.Add(this.lbl_ThongBao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Giơi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Name = "frm_HR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_HR";
            this.Load += new System.EventHandler(this.frm_HR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Giơi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.TextBox txt_img;
        public System.Windows.Forms.PictureBox pb_img;
        public System.Windows.Forms.DateTimePicker dtp_dob;
        public System.Windows.Forms.ComboBox cb_gender;
        public System.Windows.Forms.ComboBox cb_typeJob;
        public System.Windows.Forms.ComboBox cb_department;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btn_del;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_thongBaoImg;
        public System.Windows.Forms.Button btn_free;
        public System.Windows.Forms.Label lbl_ThongBao;
    }
}