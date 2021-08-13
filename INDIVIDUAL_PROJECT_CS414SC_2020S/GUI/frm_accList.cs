﻿using INDIVIDUAL_PROJECT_CS414SC_2020S.service;
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
        HomeService homeService;

        public frm_accList()
        {
            roleService = new RoleService(this);
            homeService = new HomeService(new frm_main());
            InitializeComponent();
        }

        private void frm_accList_Load(object sender, EventArgs e)
        {
            roleService.findUserAndRole();
            roleService.loadComboBoxRoleCode();
            roleService.loadComboBoxUsername();
            roleService.loadComboBoxRoleId();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            roleService.handlerBtnAdd();
            roleService.findUserAndRole();
            homeService.openChildForms(new frm_dashboard());
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            roleService.handlerBtnUpdate();
            roleService.findUserAndRole();
            homeService.openChildForms(new frm_accList());
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            roleService.handlerBtnDelete();
            roleService.findUserAndRole();
            homeService.openChildForms(new frm_accList());
        }
    }
}