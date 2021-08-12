namespace INDIVIDUAL_PROJECT_CS414SC_2020S.GUI
{
    partial class frm_accList
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
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_roleCode = new System.Windows.Forms.ComboBox();
            this.cb_username = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.Giơi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1039, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(544, 208);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 34;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(386, 208);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 33;
            this.btn_edit.Text = "Cập nhập";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(711, 208);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 32;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(223, 208);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 31;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_roleCode
            // 
            this.cb_roleCode.FormattingEnabled = true;
            this.cb_roleCode.Items.AddRange(new object[] {
            "Nhân sự",
            "Kế toán"});
            this.cb_roleCode.Location = new System.Drawing.Point(629, 100);
            this.cb_roleCode.Name = "cb_roleCode";
            this.cb_roleCode.Size = new System.Drawing.Size(195, 21);
            this.cb_roleCode.TabIndex = 30;
            // 
            // cb_username
            // 
            this.cb_username.FormattingEnabled = true;
            this.cb_username.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_username.Location = new System.Drawing.Point(240, 100);
            this.cb_username.Name = "cb_username";
            this.cb_username.Size = new System.Drawing.Size(195, 21);
            this.cb_username.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(900, 287);
            this.dataGridView1.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(539, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Loại quyền";
            // 
            // Giơi
            // 
            this.Giơi.AutoSize = true;
            this.Giơi.Location = new System.Drawing.Point(150, 103);
            this.Giơi.Name = "Giơi";
            this.Giơi.Size = new System.Drawing.Size(81, 13);
            this.Giơi.TabIndex = 18;
            this.Giơi.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(413, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Quản lý quyền truy cập";
            // 
            // frm_accList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 562);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_roleCode);
            this.Controls.Add(this.cb_username);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Giơi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_accList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_accList";
            this.Load += new System.EventHandler(this.frm_accList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_del;
        public System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.Button btn_refresh;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.ComboBox cb_roleCode;
        public System.Windows.Forms.ComboBox cb_username;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label Giơi;
    }
}