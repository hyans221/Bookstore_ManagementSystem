using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAn_Nhom1_QuanLyNhaSach
{
    public partial class frmHoaDon : Form
    {
        DBConnect db = new DBConnect();
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public void loadDGV()
        {
            string sql;
            sql = "SELECT * FROM HOADON ";
            DataTable dt = db.getDatatable(sql);
            dgvHoaDon.DataSource = dt;
        }
        private bool kiemtra(string mahd)
        {
            string sql = "SELECT COUNT(*) FROM HOADON WHERE MAHD='" + mahd + "'";
            int dem = (int)db.getScalar(sql);
            if (dem == 0)
            {
                return true;
            }
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
            if (kiemtra(mahd))
            {
                string sql = $"INSERT INTO HOADON(MaHD, NgayLap, MaNV) VALUES ('{mahd}', '{dtPickerNgayLap.Value.ToString("yyyy-MM-dd")}', '{cmbMaNV.SelectedItem.ToString()}')";
                int kq = db.getNonQuery(sql);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm hóa đơn thành công");
                    loadDGV();
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại");
                }
            }
            else
            {
                MessageBox.Show("Đã có mã hóa đơn này rồi không thêm được");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
            if (!kiemtra(mahd))
            {
                string sql = $"DELETE FROM HOADON WHERE MaHD = '{mahd}'";
                int result = db.getNonQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("Xóa hóa đơn thành công");
                    loadDGV();
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn thất bại");
                }
            }
            else
            {
                MessageBox.Show("Không có mã hóa đơn này rồi không thể xóa");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE HOADON SET NgayLap = '{dtPickerNgayLap.Value.ToString("yyyy-MM-dd")}', MaNV = '{cmbMaNV.SelectedItem.ToString()}' WHERE MaHD = '{txtMaHD.Text}'";
            int result = db.getNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("Cập nhật hóa đơn thành công");
                loadDGV();
            }
            else
            {
                MessageBox.Show("Cập nhật hóa đơn thất bại");
            }
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dtPickerNgayLap.Value = DateTime.Now;
            cmbMaNV.Items.Add("Tất cả");
            string sql = "SELECT MaNV FROM NHANVIEN";

            SqlDataReader dr = db.getDataReader(sql);
            while (dr.Read())
            {
                cmbMaNV.Items.Add(dr["MaNV"].ToString());
            }
            dr.Close();
            loadDGV();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvHoaDon.Rows.Count)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];

                if (row.Cells["MaHD"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["MaHD"].Value.ToString()))
                {
                    txtMaHD.Text = row.Cells["MaHD"].Value.ToString();

                    DateTime ngayLap = DateTime.Parse(row.Cells["NgayLap"].Value.ToString());

                    DateTime ngayBatDau = new DateTime(2020, 01, 01);

                    if (ngayLap >= ngayBatDau)
                    {
                        dtPickerNgayLap.Value = ngayLap;
                    }
                    else
                    {
                        MessageBox.Show("Ngày lập hoá đơn không được nhỏ hơn " + ngayBatDau.ToString("yyyy-MM-dd"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    string maNV = row.Cells["MaNV"].Value.ToString();
                    cmbMaNV.SelectedItem = cmbMaNV.Items.Cast<string>().FirstOrDefault(item => item == maNV);
                }
                else
                {
                    MessageBox.Show("Dòng chọn không có dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon chiTietHD = new frmChiTietHoaDon();
            chiTietHD.Show();
        }

        private void dtPickerNgayLap_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayChon = dtPickerNgayLap.Value;
            DateTime ngayBatDau = new DateTime(2020, 01, 01);
            DateTime ngayHienTai = DateTime.Now;
            if (ngayChon < ngayBatDau)
            {
                MessageBox.Show("Hóa đơn không hợp lệ.");
                dtPickerNgayLap.Value = ngayBatDau;
            }
            else if (ngayChon > ngayHienTai)
            {
                MessageBox.Show("Hóa đơn không hợp lệ.");
                dtPickerNgayLap.Value = ngayHienTai;
            }
        }

        private void txtMaHD_Leave(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập Mã Hóa đơn");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtMaHD.Clear();

            dtPickerNgayLap.Value = DateTime.Now;

            cmbMaNV.SelectedIndex = -1;
        }
    }
}
