using INDIVIDUAL_PROJECT_CS414SC_2020S.service;
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
    public partial class frm_login : Form
    {
        Authentication authentication;

        public frm_login()
        {
            authentication = new Authentication(this, new frm_main());
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            authentication.handlerLogin();
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
