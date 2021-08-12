using INDIVIDUAL_PROJECT_CS414SC_2020S.GUI;
using INDIVIDUAL_PROJECT_CS414SC_2020S.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S
{
    public partial class frm_main : Form
    {


        public frm_main()
        {
            InitializeComponent();
        }

        public void checkingLogin()
        {
            if (SystemConstant.USERNAME == null)
            {
                new frm_login().Show();
                this.Hide();
                toolStripDropDownButton_username.Text = null;
            }
            else
            {
                new frm_login().Close();
                this.Show();
                toolStripDropDownButton_username.Text = SystemConstant.FULLNAME;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }


        private void frm_main_Load(object sender, EventArgs e)
        {
            checkingLogin();
        }


        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.OK)
            {
                this.Close();
                frm_login LG = new frm_login();
                LG.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemConstant.USERNAME = null;
            SystemConstant.FULLNAME = null;
            SystemConstant.ROLES.Clear();
            Form[] childArray = this.MdiChildren;
            foreach (Form childForm in childArray)
            {
                childForm.Close();
            }
            new frm_login().Show();
            this.Hide();
        }

        private void dashboadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool k = false;
            frm_dashboard _Dashboard;
            foreach (string role in SystemConstant.ROLES)
            {
                if (role.Equals("CEO"))
                {
                    if (Application.OpenForms["frm_dashboard"] == null)
                    {
                        _Dashboard = new frm_dashboard();
                        _Dashboard.MdiParent = this;
                        _Dashboard.Show();
                    }
                    else
                    {
                        _Dashboard = new frm_dashboard();
                        Application.OpenForms["frm_dashboard"].Activate();
                    }
                    k = true;
                }
            }
            if (!k)
            {
                DialogResult d = MessageBox.Show("Bạn chưa được cấp quyền vào khu vực này !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nhânSựToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool k = false;
            frm_HR _HR;
            foreach (string role in SystemConstant.ROLES)
            {
                if (role.Equals("CEO") || role.Equals("MANAGER_HR"))
                {
                    if (Application.OpenForms["frm_HR"] == null)
                    {
                        _HR = new frm_HR();
                        _HR.MdiParent = this;
                        _HR.Show();
                    }
                    else
                    {
                        _HR = new frm_HR();
                        Application.OpenForms["frm_HR"].Activate();
                    }
                    k = true;
                }
            }
            if (!k)
            {
                DialogResult d = MessageBox.Show("Bạn chưa được cấp quyền vào khu vực này !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool k = false;
            frm_PR _PR;
            foreach (string role in SystemConstant.ROLES)
            {
                if (role.Equals("CEO") || role.Equals("MANAGER_PR"))
                {
                    if (Application.OpenForms["frm_PR"] == null)
                    {
                        _PR = new frm_PR();
                        _PR.MdiParent = this;
                        _PR.Show();
                    }
                    else
                    {
                        _PR = new frm_PR();
                        Application.OpenForms["frm_PR"].Activate();
                    }
                    k = true;
                }
            }
            if (!k)
            {
                DialogResult d = MessageBox.Show("Bạn chưa được cấp quyền vào khu vực này !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool k = false;
            frm_createAccount _createAccount;
            foreach (string role in SystemConstant.ROLES)
            {
                if (role.Equals("CEO") || role.Equals("MANAGER_HR"))
                {
                    if (Application.OpenForms["frm_createAccount"] == null)
                    {
                        _createAccount = new frm_createAccount();
                        _createAccount.MdiParent = this;
                        _createAccount.Show();
                    }
                    else
                    {
                        _createAccount = new frm_createAccount();
                        Application.OpenForms["frm_createAccount"].Activate();
                    }
                    k = true;
                }
            }
            if (!k)
            {
                DialogResult d = MessageBox.Show("Bạn chưa được cấp quyền vào khu vực này !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_changePass _changePass;
            if (Application.OpenForms["frm_changePass"] == null)
            {
                _changePass = new frm_changePass();
                _changePass.MdiParent = this;
                _changePass.Show();
            }
            else
            {
                _changePass = new frm_changePass();
                Application.OpenForms["frm_changePass"].Activate();
            }

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool k = false;
            frm_accList _accList;
            foreach (string role in SystemConstant.ROLES)
            {
                if (role.Equals("CEO") || role.Equals("MANAGER_HR"))
                {
                    if (Application.OpenForms["frm_accList"] == null)
                    {
                        _accList = new frm_accList();
                        _accList.MdiParent = this;
                        _accList.Show();
                    }
                    else
                    {
                        _accList = new frm_accList();
                        Application.OpenForms["frm_accList"].Activate();
                    }
                    k = true;
                }
            }
            if (!k)
            {
                DialogResult d = MessageBox.Show("Bạn chưa được cấp quyền vào khu vực này !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
