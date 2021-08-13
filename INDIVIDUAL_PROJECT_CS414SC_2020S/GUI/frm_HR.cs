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
    public partial class frm_HR : Form
    {

        HRService hRService;

        public frm_HR()
        {
            InitializeComponent();
            hRService = new HRService(this);
        }

        private void frm_HR_Load(object sender, EventArgs e)
        {
            hRService.handlerLoadData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            hRService.handlerBtnAdd();
            hRService.handlerLoadData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            hRService.handlerBtnUpdate();
            hRService.handlerLoadData();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            hRService.handlerBtnDelete();
            hRService.handlerLoadData();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            hRService.handlerBtnRefresh();
            hRService.handlerLoadData();
        }

        private void pb_img_Click(object sender, EventArgs e)
        {
            hRService.handlerUploadImg();
        }

        private void txt_img_Validated(object sender, EventArgs e)
        {
            if (txt_img.Text == "" || txt_img.Text == null)
            {
                lbl_thongBaoImg.Text = "Trường này không được để trống !";
            }
            else
            {
                lbl_thongBaoImg.Text = "";
            }
        }
    }
}
