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

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.GUI
{
    public partial class frm_createAccount : Form
    {
        UserService userService;

        public frm_createAccount()
        {
            userService = new UserService(this);
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            userService.handlerAddAccount();
        }

        private void txt_username_Validated(object sender, EventArgs e)
        {
            userService.handlerValidateUsername();
        }

        private void txt_validatePass_Validated(object sender, EventArgs e)
        {
            userService.handlerValidatePassword();
        }
    }
}
