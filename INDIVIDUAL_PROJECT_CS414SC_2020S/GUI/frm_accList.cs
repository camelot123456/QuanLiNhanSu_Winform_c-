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
    public partial class frm_accList : Form
    {
        RoleService roleService;

        public frm_accList()
        {
            roleService = new RoleService(this);
            InitializeComponent();
        }

        private void frm_accList_Load(object sender, EventArgs e)
        {
            roleService.findUserAndRole();
            roleService.loadComboBoxRoleCode();
            roleService.loadComboBoxUsername();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            roleService.handlerBtnAdd();
            roleService.findUserAndRole();
        }
    }
}
