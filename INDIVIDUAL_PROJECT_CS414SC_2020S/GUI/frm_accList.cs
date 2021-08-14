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

        private void btn_update_Click(object sender, EventArgs e)
        {
            roleService.handlerBtnUpdate();
            roleService.findUserAndRole();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            roleService.handlerBtnDelete();
            roleService.findUserAndRole();
        }

        private void dataGridView_roleList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SystemConstant.ROLE_MEMORY = new models.Role();
            SystemConstant.ROLE_MEMORY.Id = dataGridView_roleList.CurrentRow.Cells["IDROLE"].Value.ToString();
            cb_username.Text = dataGridView_roleList.CurrentRow.Cells["USERNAME"].Value.ToString();  // hoặc .Cells[0]  //[chỉ mục]
            cb_roleCode.Text = dataGridView_roleList.CurrentRow.Cells["ROLECODE"].Value.ToString();
            lbl_maQuyen.Text = SystemConstant.ROLE_MEMORY.Id;
        }

        private void btn_free_part_Click(object sender, EventArgs e)
        {
            roleService.freeMemory();
        }
    }
}
