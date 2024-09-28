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
    public partial class frmChiTietHoaDon : Form
    {
        DBConnect db = new DBConnect();
        public frmChiTietHoaDon()
        {
            InitializeComponent();
            LoadHoaDon();
        }
        private void load(string sql)
        {
            DataTable dt = db.getDatatable(sql);
            dgvChiTietHoaDon.DataSource = dt;
        }
        private void LoadHoaDon()
        {
            cmbMaSP.DataSource = db.getDatatable("SELECT * FROM SANPHAM");
            cmbMaSP.DisplayMember = "MaSP";
            cmbMaSP.ValueMember = "MaSP";

            cmbMaHD.DataSource = db.getDatatable("SELECT * FROM HOADON");
            cmbMaHD.DisplayMember = "MaHD";
            cmbMaHD.ValueMember = "MaHD";

            string sql = "SELECT CHITIETHOADON.MAHD, CHITIETHOADON.MASP, SANPHAM.TenSP, CHITIETHOADON.SoLuong, CHITIETHOADON.TongTien " +
                         "FROM CHITIETHOADON " +
                         "INNER JOIN SANPHAM ON CHITIETHOADON.MASP = SANPHAM.MaSP";
            LoadData(sql);
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHoaDon.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvChiTietHoaDon.SelectedRows)
                {
                    string maSP = row.Cells["MaSP"].Value.ToString();
                    db.getNonQuery($"DELETE FROM CHITIETHOADON WHERE MaSP = '{maSP}'");
                    dgvChiTietHoaDon.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("Không xóa được");
            }
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void cmbMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHD = cmbMaHD.SelectedValue.ToString();
            string sql = $"SELECT CHITIETHOADON.MAHD, CHITIETHOADON.MASP, SANPHAM.TenSP, CHITIETHOADON.SoLuong, CHITIETHOADON.TongTien " +
                         $"FROM CHITIETHOADON " +
                         $"INNER JOIN SANPHAM ON CHITIETHOADON.MASP = SANPHAM.MaSP " +
                         $"WHERE CHITIETHOADON.MAHD = '{maHD}'";
            LoadData(sql);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbMaSP.SelectedIndex = -1;
            cmbMaSP.Text = "";

            cmbMaHD.SelectedIndex = -1;
            cmbMaHD.Text = "";

            txtSoLuong.Clear();
            txtTongTien.Clear();
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (txtSoLuong.Text == "")
            {
                this.errorProvider1.SetError(ctr, "Bạn chưa nhập số lượng");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private string loadsql()
        {
            string sql = "SELECT CHITIETHOADON.MAHD, CHITIETHOADON.MASP, SANPHAM.TenSP, CHITIETHOADON.SoLuong, CHITIETHOADON.TongTien " +
                         "FROM CHITIETHOADON " +
                         "INNER JOIN SANPHAM ON CHITIETHOADON.MASP = SANPHAM.MaSP";
            return sql;
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTietHoaDon.Rows[e.RowIndex];

                if (dgvChiTietHoaDon.Columns.Contains("SoLuong"))
                {
                    cmbMaSP.SelectedValue = row.Cells["MaSP"].Value.ToString();
                    cmbMaHD.SelectedValue = row.Cells["MaHD"].Value.ToString();
                    txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                    txtTongTien.Text = row.Cells["TongTien"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Cột SoLuong không tồn tại trong DataGridView");
                }
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (!KiemTraSo(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng chỉ nhập số.");
                txtSoLuong.Text = txtSoLuong.Text.TrimEnd(txtSoLuong.Text[txtSoLuong.Text.Length - 1]);
            }
        }

        private void LoadData(string sql)
        {
            DataTable dt = db.getDatatable(sql);
            dgvChiTietHoaDon.DataSource = dt;
        }

        private bool KiemTraSo(string input)
        {
            foreach (char c in input)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }


    }
}
