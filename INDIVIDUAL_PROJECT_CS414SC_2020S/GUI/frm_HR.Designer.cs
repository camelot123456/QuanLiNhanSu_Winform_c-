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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Giơi = new System.Windows.Forms.Label();
            this.txt_img = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cb_TypeJob = new System.Windows.Forms.ComboBox();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(430, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhân viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày vào làm";
            // 
            // Giơi
            // 
            this.Giơi.AutoSize = true;
            this.Giơi.Location = new System.Drawing.Point(62, 136);
            this.Giơi.Name = "Giơi";
            this.Giơi.Size = new System.Drawing.Size(47, 13);
            this.Giơi.TabIndex = 1;
            this.Giơi.Text = "Giới tính";
            // 
            // txt_img
            // 
            this.txt_img.Location = new System.Drawing.Point(520, 136);
            this.txt_img.Name = "txt_img";
            this.txt_img.Size = new System.Drawing.Size(195, 20);
            this.txt_img.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ảnh đại diện";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Loại việc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Phòng ban";
            // 
            // pb_img
            // 
            this.pb_img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_img.Location = new System.Drawing.Point(810, 54);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(155, 144);
            this.pb_img.TabIndex = 11;
            this.pb_img.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(900, 287);
            this.dataGridView1.TabIndex = 12;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Location = new System.Drawing.Point(152, 94);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(195, 20);
            this.dtp_dob.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox1.Location = new System.Drawing.Point(152, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // cb_TypeJob
            // 
            this.cb_TypeJob.FormattingEnabled = true;
            this.cb_TypeJob.Items.AddRange(new object[] {
            "Fulltime",
            "Parttime"});
            this.cb_TypeJob.Location = new System.Drawing.Point(520, 94);
            this.cb_TypeJob.Name = "cb_TypeJob";
            this.cb_TypeJob.Size = new System.Drawing.Size(195, 21);
            this.cb_TypeJob.TabIndex = 14;
            // 
            // cb_department
            // 
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Items.AddRange(new object[] {
            "Nhân sự",
            "Kế toán"});
            this.cb_department.Location = new System.Drawing.Point(520, 54);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(195, 21);
            this.cb_department.TabIndex = 14;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(152, 221);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(640, 221);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 15;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(315, 221);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "Cập nhập";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(473, 221);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 15;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // frm_HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 562);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_department);
            this.Controls.Add(this.cb_TypeJob);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtp_dob);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pb_img);
            this.Controls.Add(this.txt_img);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Giơi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Giơi;
        private System.Windows.Forms.TextBox txt_img;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pb_img;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cb_TypeJob;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
    }
}