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
        Authentication userService;

        public frm_login()
        {
            userService = new Authentication(this, new frm_main());
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            userService.handlerLogin();
        }

        internal void ShowInTaskbar()
        {
            throw new NotImplementedException();
        }
    }
}
