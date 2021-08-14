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
            this.cb_roleCode = new System.Windows.Forms.ComboBox();
            this.cb_username = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Giơi = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView_roleList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_maQuyen = new System.Windows.Forms.Label();
            this.btn_free_part = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_roleList)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_roleCode
            // 
            this.cb_roleCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_roleCode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_roleCode.FormattingEnabled = true;
            this.cb_roleCode.Items.AddRange(new object[] {
            "Nhân sự",
            "Kế toán"});
            this.cb_roleCode.Location = new System.Drawing.Point(270, 98);
            this.cb_roleCode.Name = "cb_roleCode";
            this.cb_roleCode.Size = new System.Drawing.Size(232, 28);
            this.cb_roleCode.TabIndex = 124;
            // 
            // cb_username
            // 
            this.cb_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_username.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_username.FormattingEnabled = true;
            this.cb_username.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_username.Location = new System.Drawing.Point(270, 54);
            this.cb_username.Name = "cb_username";
            this.cb_username.Size = new System.Drawing.Size(232, 28);
            this.cb_username.TabIndex = 123;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(146, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 122;
            this.label9.Text = "Loại quyền";
            // 
            // Giơi
            // 
            this.Giơi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Giơi.AutoSize = true;
            this.Giơi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Giơi.Location = new System.Drawing.Point(146, 57);
            this.Giơi.Name = "Giơi";
            this.Giơi.Size = new System.Drawing.Size(107, 20);
            this.Giơi.TabIndex = 121;
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
            this.btn_del.Location = new System.Drawing.Point(412, 184);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(194, 50);
            this.btn_del.TabIndex = 118;
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
            this.btn_update.Location = new System.Drawing.Point(212, 184);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(194, 50);
            this.btn_update.TabIndex = 119;
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
            this.btn_add.Location = new System.Drawing.Point(12, 184);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(194, 50);
            this.btn_add.TabIndex = 120;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView_roleList
            // 
            this.dataGridView_roleList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_roleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_roleList.Location = new System.Drawing.Point(12, 275);
            this.dataGridView_roleList.Name = "dataGridView_roleList";
            this.dataGridView_roleList.ReadOnly = true;
            this.dataGridView_roleList.Size = new System.Drawing.Size(794, 341);
            this.dataGridView_roleList.TabIndex = 117;
            this.dataGridView_roleList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_roleList_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 121;
            this.label1.Text = "Mã quyền";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(508, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 121;
            this.label2.Text = "(Chỉ xử lý sửa hoặc xóa)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(505, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 121;
            this.label3.Text = "(Chỉ xử lý thêm)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(505, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 121;
            this.label4.Text = "(Chỉ xử lý thêm hoặc sửa)";
            // 
            // lbl_maQuyen
            // 
            this.lbl_maQuyen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_maQuyen.AutoSize = true;
            this.lbl_maQuyen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maQuyen.Location = new System.Drawing.Point(266, 11);
            this.lbl_maQuyen.Name = "lbl_maQuyen";
            this.lbl_maQuyen.Size = new System.Drawing.Size(222, 20);
            this.lbl_maQuyen.TabIndex = 125;
            this.lbl_maQuyen.Text = "Kích đúp hàng cần sửa hoặc xóa";
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
            this.btn_free_part.Location = new System.Drawing.Point(612, 184);
            this.btn_free_part.Name = "btn_free_part";
            this.btn_free_part.Size = new System.Drawing.Size(194, 50);
            this.btn_free_part.TabIndex = 196;
            this.btn_free_part.Text = "Xóa id trong bộ nhớ";
            this.btn_free_part.UseVisualStyleBackColor = false;
            this.btn_free_part.Click += new System.EventHandler(this.btn_free_part_Click);
            // 
            // frm_accList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 637);
            this.Controls.Add(this.btn_free_part);
            this.Controls.Add(this.lbl_maQuyen);
            this.Controls.Add(this.cb_roleCode);
            this.Controls.Add(this.cb_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Giơi);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView_roleList);
            this.Name = "frm_accList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_accList";
            this.Load += new System.EventHandler(this.frm_accList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_roleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cb_roleCode;
        public System.Windows.Forms.ComboBox cb_username;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label Giơi;
        public System.Windows.Forms.Button btn_del;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.DataGridView dataGridView_roleList;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_maQuyen;
        public System.Windows.Forms.Button btn_free_part;
    }
}