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
    public partial class frm_changePass : Form
    {
        UserService userService;

        public frm_changePass()
        {
            InitializeComponent();
            userService = new UserService(this);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            userService.handlerCancelBtn();
        }

        private void txt_pass_old_Validated_1(object sender, EventArgs e)
        {
            userService.handlerValidatePassOld();
        }

        private void txt_pass_check_Validated_1(object sender, EventArgs e)
        {
            userService.handlerValidatePassNew();
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            userService.validateChangePass();
        }
    }
}
