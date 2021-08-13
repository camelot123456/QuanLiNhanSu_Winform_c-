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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_warnChangePass = new System.Windows.Forms.Label();
            this.lbl_validateChangePass = new System.Windows.Forms.Label();
            this.txt_pass_check = new System.Windows.Forms.TextBox();
            this.txt_pass_new = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pass_old = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_warnChangePass);
            this.panel1.Controls.Add(this.lbl_validateChangePass);
            this.panel1.Controls.Add(this.txt_pass_check);
            this.panel1.Controls.Add(this.txt_pass_new);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_pass_old);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 418);
            this.panel1.TabIndex = 1;
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
            this.btn_save.Location = new System.Drawing.Point(128, 323);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(194, 50);
            this.btn_save.TabIndex = 61;
            this.btn_save.Text = "Lưu lại";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // lbl_warnChangePass
            // 
            this.lbl_warnChangePass.AutoSize = true;
            this.lbl_warnChangePass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnChangePass.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnChangePass.Location = new System.Drawing.Point(188, 111);
            this.lbl_warnChangePass.Name = "lbl_warnChangePass";
            this.lbl_warnChangePass.Size = new System.Drawing.Size(13, 20);
            this.lbl_warnChangePass.TabIndex = 58;
            this.lbl_warnChangePass.Text = " ";
            // 
            // lbl_validateChangePass
            // 
            this.lbl_validateChangePass.AutoSize = true;
            this.lbl_validateChangePass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_validateChangePass.ForeColor = System.Drawing.Color.Red;
            this.lbl_validateChangePass.Location = new System.Drawing.Point(188, 246);
            this.lbl_validateChangePass.Name = "lbl_validateChangePass";
            this.lbl_validateChangePass.Size = new System.Drawing.Size(13, 20);
            this.lbl_validateChangePass.TabIndex = 59;
            this.lbl_validateChangePass.Text = " ";
            // 
            // txt_pass_check
            // 
            this.txt_pass_check.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass_check.Location = new System.Drawing.Point(192, 216);
            this.txt_pass_check.Name = "txt_pass_check";
            this.txt_pass_check.Size = new System.Drawing.Size(219, 27);
            this.txt_pass_check.TabIndex = 55;
            this.txt_pass_check.UseSystemPasswordChar = true;
            this.txt_pass_check.Validated += new System.EventHandler(this.txt_pass_check_Validated_1);
            // 
            // txt_pass_new
            // 
            this.txt_pass_new.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass_new.Location = new System.Drawing.Point(192, 148);
            this.txt_pass_new.Name = "txt_pass_new";
            this.txt_pass_new.Size = new System.Drawing.Size(219, 27);
            this.txt_pass_new.TabIndex = 56;
            this.txt_pass_new.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Mật khẩu mới";
            // 
            // txt_pass_old
            // 
            this.txt_pass_old.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass_old.Location = new System.Drawing.Point(192, 81);
            this.txt_pass_old.Name = "txt_pass_old";
            this.txt_pass_old.Size = new System.Drawing.Size(219, 27);
            this.txt_pass_old.TabIndex = 57;
            this.txt_pass_old.UseSystemPasswordChar = true;
            this.txt_pass_old.Validated += new System.EventHandler(this.txt_pass_old_Validated_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // frm_changePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 418);
            this.Controls.Add(this.panel1);
            this.Name = "frm_changePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_changePass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Label lbl_warnChangePass;
        public System.Windows.Forms.Label lbl_validateChangePass;
        public System.Windows.Forms.TextBox txt_pass_check;
        public System.Windows.Forms.TextBox txt_pass_new;
        public System.Windows.Forms.TextBox txt_pass_old;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
    }
}