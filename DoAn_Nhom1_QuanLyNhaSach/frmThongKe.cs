using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom1_QuanLyNhaSach
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnInThongKe_Click(object sender, EventArgs e)
        {            
            try
            {
                if (cmbLoaiThongKe.Text == "")
                {
                    MessageBox.Show("Loại thống kê không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbLoaiThongKe.Focus();
                    return;
                }

                if (cmbLoaiThongKe.Text == "Thống kê phiếu nhập")
                {
                    cptPhieuNhap rpt = new cptPhieuNhap();
                    crystalReportViewer1.ReportSource = rpt;
                    rpt.SetDatabaseLogon("sa", "sa", "THY", "QLNhaSach");

                    crystalReportViewer1.Refresh();
                    crystalReportViewer1.DisplayToolbar = false;
                    crystalReportViewer1.DisplayStatusBar = false;
                }

                if (cmbLoaiThongKe.Text == "Thống kê tồn kho")
                {
                    cptTonKho rpt = new cptTonKho();
                    crystalReportViewer1.ReportSource = rpt;
                    rpt.SetDatabaseLogon("sa", "sa", "THY", "QLNhaSach");

                    crystalReportViewer1.Refresh();
                    crystalReportViewer1.DisplayToolbar = false;
                    crystalReportViewer1.DisplayStatusBar = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cmbLoaiThongKe.SelectedIndex = -1;
            dtPickerPhamViThongKe.Value = DateTime.Now;
            crystalReportViewer1.ReportSource = null;
        }
    }
}
