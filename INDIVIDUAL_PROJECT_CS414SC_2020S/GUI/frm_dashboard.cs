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
    public partial class frm_dashboard : Form
    {

        DashService dashService;
        public frm_dashboard()
        {
            InitializeComponent();
            dashService = new DashService(this);
        }

        private void frm_dashboard_Load(object sender, EventArgs e)
        {
            dashService.loadData();
        }
    }
}
