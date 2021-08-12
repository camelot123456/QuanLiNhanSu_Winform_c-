namespace INDIVIDUAL_PROJECT_CS414SC_2020S
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânSựToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton_username = new System.Windows.Forms.ToolStripDropDownButton();
            this.thôngTinNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboadToolStripMenuItem,
            this.nhânSựToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboadToolStripMenuItem
            // 
            this.dashboadToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dashboadToolStripMenuItem.Name = "dashboadToolStripMenuItem";
            this.dashboadToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.dashboadToolStripMenuItem.Text = "&Thống kê";
            this.dashboadToolStripMenuItem.Click += new System.EventHandler(this.dashboadToolStripMenuItem_Click);
            // 
            // nhânSựToolStripMenuItem
            // 
            this.nhânSựToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânSựToolStripMenuItem1,
            this.lươngToolStripMenuItem,
            this.tạoTàiKhoảnToolStripMenuItem});
            this.nhânSựToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nhânSựToolStripMenuItem.Name = "nhânSựToolStripMenuItem";
            this.nhânSựToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.nhânSựToolStripMenuItem.Text = "&Quản lý";
            // 
            // nhânSựToolStripMenuItem1
            // 
            this.nhânSựToolStripMenuItem1.Name = "nhânSựToolStripMenuItem1";
            this.nhânSựToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.nhânSựToolStripMenuItem1.Text = "&Nhân sự";
            this.nhânSựToolStripMenuItem1.Click += new System.EventHandler(this.nhânSựToolStripMenuItem1_Click);
            // 
            // lươngToolStripMenuItem
            // 
            this.lươngToolStripMenuItem.Name = "lươngToolStripMenuItem";
            this.lươngToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.lươngToolStripMenuItem.Text = "&Lương";
            this.lươngToolStripMenuItem.Click += new System.EventHandler(this.lươngToolStripMenuItem_Click);
            // 
            // tạoTàiKhoảnToolStripMenuItem
            // 
            this.tạoTàiKhoảnToolStripMenuItem.Name = "tạoTàiKhoảnToolStripMenuItem";
            this.tạoTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.tạoTàiKhoảnToolStripMenuItem.Text = "Tạo tài khoản";
            this.tạoTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tạoTàiKhoảnToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel1.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton_username,
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton_username
            // 
            this.toolStripDropDownButton_username.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton_username.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_username.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNgườiDùngToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.toolStripSeparator1,
            this.đăngXuấtToolStripMenuItem});
            this.toolStripDropDownButton_username.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripDropDownButton_username.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_username.Image")));
            this.toolStripDropDownButton_username.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_username.Name = "toolStripDropDownButton_username";
            this.toolStripDropDownButton_username.Size = new System.Drawing.Size(213, 25);
            this.toolStripDropDownButton_username.Text = "toolStripDropDownButton1";
            // 
            // thôngTinNgườiDùngToolStripMenuItem
            // 
            this.thôngTinNgườiDùngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thôngTinNgườiDùngToolStripMenuItem.Image")));
            this.thôngTinNgườiDùngToolStripMenuItem.Name = "thôngTinNgườiDùngToolStripMenuItem";
            this.thôngTinNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.thôngTinNgườiDùngToolStripMenuItem.Text = "Thông tin người dùng";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đổiMậtKhẩuToolStripMenuItem.Image")));
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 25);
            this.toolStripLabel1.Text = "Xin chào,";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 25);
            this.toolStripLabel2.Text = "toolStripLabel2";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 25);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 25);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 25);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(149, 25);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QUẢN LÝ NHÂN SỰ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânSựToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lươngToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem tạoTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_username;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
    }
}