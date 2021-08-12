using INDIVIDUAL_PROJECT_CS414SC_2020S.GUI;
using INDIVIDUAL_PROJECT_CS414SC_2020S.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S.service
{
    class RoleService
    {

        RoleRepository roleRepository;
        frm_accList _AccList;

        public RoleService(frm_accList accList)
        {
            _AccList = accList;
            roleRepository = new RoleRepository();
        }

        public void findUserAndRole()
        {
            _AccList.dataGridView1.DataSource = roleRepository.findUserAndRole();
        }

        public void loadComboBoxUsername()
        {
            _AccList.cb_username.DataSource = roleRepository.findUser();
            _AccList.cb_username.DisplayMember = "USERNAME";
            _AccList.cb_username.ValueMember = "USERNAME";
        }

        public void loadComboBoxRoleCode()
        {
            _AccList.cb_roleCode.DataSource = roleRepository.findRole();
            _AccList.cb_roleCode.DisplayMember = "ROLECODE";
            _AccList.cb_roleCode.ValueMember = "ROLECODE";
        }

        public void handlerBtnAdd()
        {
            frm_createAccount _CreateAccount;
            if (Application.OpenForms["frm_createAccount"] == null)
            {
                _CreateAccount = new frm_createAccount();
                _CreateAccount.MdiParent = frm_main.ActiveForm;
                _CreateAccount.Show();
            }
            else
            {
                _CreateAccount = new frm_createAccount();
                Application.OpenForms["frm_createAccount"].Activate();
            }
        }
    }
}
