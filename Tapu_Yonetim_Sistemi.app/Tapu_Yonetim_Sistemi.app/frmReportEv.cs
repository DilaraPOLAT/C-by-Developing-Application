﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tapu_Yonetim_Sistemi.app
{
    public partial class frmReportEv : Form
    {
        public frmReportEv()
        {
            InitializeComponent();
        }

        private void frmReportEv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TapuVeriTabaniDataSet21.Ev' table. You can move, or remove it, as needed.
            this.EvTableAdapter.Fill(this.TapuVeriTabaniDataSet21.Ev);

            this.reportViewer1.RefreshReport();
        }
    }
}
