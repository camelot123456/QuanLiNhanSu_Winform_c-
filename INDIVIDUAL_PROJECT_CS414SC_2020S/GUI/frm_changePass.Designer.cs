namespace INDIVIDUAL_PROJECT_CS414SC_2020S.GUI
{
    partial class frm_changePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_changePass));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pass_old = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pass_new = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pass_check = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_validateChangePass = new System.Windows.Forms.Label();
            this.lbl_warnChangePass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // txt_pass_old
            // 
            this.txt_pass_old.Location = new System.Drawing.Point(158, 210);
            this.txt_pass_old.Name = "txt_pass_old";
            this.txt_pass_old.Size = new System.Drawing.Size(219, 20);
            this.txt_pass_old.TabIndex = 1;
            this.txt_pass_old.UseSystemPasswordChar = true;
            this.txt_pass_old.Validated += new System.EventHandler(this.txt_pass_old_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu mới";
            // 
            // txt_pass_new
            // 
            this.txt_pass_new.Location = new System.Drawing.Point(158, 252);
            this.txt_pass_new.Name = "txt_pass_new";
            this.txt_pass_new.Size = new System.Drawing.Size(219, 20);
            this.txt_pass_new.TabIndex = 1;
            this.txt_pass_new.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // txt_pass_check
            // 
            this.txt_pass_check.Location = new System.Drawing.Point(158, 294);
            this.txt_pass_check.Name = "txt_pass_check";
            this.txt_pass_check.Size = new System.Drawing.Size(219, 20);
            this.txt_pass_check.TabIndex = 1;
            this.txt_pass_check.UseSystemPasswordChar = true;
            this.txt_pass_check.Validated += new System.EventHandler(this.txt_pass_check_Validated);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(106, 381);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 2;
            this.btn_change.Text = "Đổi";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(251, 381);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 133);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_validateChangePass
            // 
            this.lbl_validateChangePass.AutoSize = true;
            this.lbl_validateChangePass.ForeColor = System.Drawing.Color.Red;
            this.lbl_validateChangePass.Location = new System.Drawing.Point(161, 317);
            this.lbl_validateChangePass.Name = "lbl_validateChangePass";
            this.lbl_validateChangePass.Size = new System.Drawing.Size(10, 13);
            this.lbl_validateChangePass.TabIndex = 4;
            this.lbl_validateChangePass.Text = " ";
            // 
            // lbl_warnChangePass
            // 
            this.lbl_warnChangePass.AutoSize = true;
            this.lbl_warnChangePass.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnChangePass.Location = new System.Drawing.Point(161, 233);
            this.lbl_warnChangePass.Name = "lbl_warnChangePass";
            this.lbl_warnChangePass.Size = new System.Drawing.Size(10, 13);
            this.lbl_warnChangePass.TabIndex = 4;
            this.lbl_warnChangePass.Text = " ";
            // 
            // frm_changePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 433);
            this.Controls.Add(this.lbl_warnChangePass);
            this.Controls.Add(this.lbl_validateChangePass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.txt_pass_check);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_pass_new);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pass_old);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_changePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_changePass";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txt_pass_old;
        public System.Windows.Forms.TextBox txt_pass_new;
        public System.Windows.Forms.TextBox txt_pass_check;
        public System.Windows.Forms.Button btn_change;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Label lbl_validateChangePass;
        public System.Windows.Forms.Label lbl_warnChangePass;
    }
}