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
    public partial class frmBanHang : Form
    {
        private DataTable dtSanPham;
        private DataTable dtChiTietHoaDon;
        private DBConnect dbConnect;
        private bool CheckData = false;
        public frmBanHang()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            LoadData();
        }

        private void LoadData()
        {
            dtSanPham = dbConnect.getDatatable("SELECT MaSP, TenSP, DonGia FROM SANPHAM");
            dgvSanPham.DataSource = dtSanPham;

            DataTable dtNhanVien = dbConnect.getDatatable("SELECT MaNV, TenNV FROM NHANVIEN");
            cmbMaNV.DataSource = dtNhanVien;
            cmbMaNV.DisplayMember = "MaNV";
            cmbMaNV.ValueMember = "MaNV";

            cmbMaSP.DataSource = dtSanPham;
            cmbMaSP.DisplayMember = "MaSP";
            cmbMaSP.ValueMember = "MaSP";

            cmbTenSanPham.DataSource = dtSanPham;
            cmbTenSanPham.DisplayMember = "TenSP";
            cmbTenSanPham.ValueMember = "TenSP";

            dtChiTietHoaDon = new DataTable();
            dtChiTietHoaDon.Columns.Add("MaSP", typeof(string));
            dtChiTietHoaDon.Columns.Add("TenSP", typeof(string));
            dtChiTietHoaDon.Columns.Add("SoLuong", typeof(int));
            dtChiTietHoaDon.Columns.Add("TongTien", typeof(int));
            dgvChiTietHoaDon.DataSource = dtChiTietHoaDon;
            CheckData = true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string maHD = GenerateMaHD();
            string ngayLap = dtPickerNgayLap.Value.ToString("yyyy-MM-dd");
            string maNV = cmbMaNV.SelectedItem != null ? cmbMaNV.SelectedValue.ToString() : null;


            int tongTien = Convert.ToInt32(txtTongTien.Text);

            string insertHoaDonQuery = $"INSERT INTO HOADON(MaHD, NgayLap, MaNV) VALUES ('{maHD}', '{ngayLap}', '{maNV}')";
            dbConnect.execNonQuery(insertHoaDonQuery);

            foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
            {
                if (row.Cells["MaSP"] != null && row.Cells["MaSP"].Value != null)
                {
                    string maSP = row.Cells["MaSP"].Value.ToString();
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);

                    string insertChiTietHoaDonQuery = $"INSERT INTO CHITIETHOADON(MaHD, MaSP, SoLuong, TongTien) VALUES ('{maHD}', '{maSP}', {soLuong}, {tongTien})";
                    dbConnect.execNonQuery(insertChiTietHoaDonQuery);
                }
            }

            MessageBox.Show("Thanh toán thành công!");

            ResetForm();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (cmbMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên trước khi thêm sản phẩm vào giỏ!");
                return;
            }

            DataRowView selectedRow = (DataRowView)cmbMaSP.SelectedItem;
            string maSP = selectedRow["MaSP"].ToString();
            string tenSP = selectedRow["TenSP"].ToString();

            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm!");
                return;
            }

            int DonGia = Convert.ToInt32(txtDonGia.Text);
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            int TongTien = 0;
            string maHD = GenerateMaHD();
            txtMaHD.Text = maHD;

            DataRow[] existingRows = dtChiTietHoaDon.Select($"MaSP = '{maSP}'");
            if (existingRows.Length > 0)
            {
                TongTien = SumTongTien(soLuong, DonGia);
                existingRows[0]["SoLuong"] = Convert.ToInt32(existingRows[0]["SoLuong"]) + soLuong;
                existingRows[0]["TongTien"] = Convert.ToInt32(existingRows[0]["TongTien"]) + TongTien;
            }
            else
            {
                TongTien = SumTongTien(soLuong, DonGia);
                DataRow newRow = dtChiTietHoaDon.NewRow();
                newRow["MaSP"] = maSP;
                newRow["TenSP"] = tenSP;
                newRow["SoLuong"] = soLuong;
                newRow["TongTien"] = TongTien;
                dtChiTietHoaDon.Rows.Add(newRow);
            }
            UpdateTongSanPham();
            UpdateTongTien();
        }

        private int SumTongTien(int sl, int dongia)
        {
            return sl * dongia;
        }
        private void UpdateTongTien()
        {
            int tongtien = 0;
            foreach (DataRow row in dtChiTietHoaDon.Rows)
            {
                tongtien += Convert.ToInt32(row["TongTien"]);
            }

            txtTongTien.Text = tongtien.ToString();
        }
        private void UpdateTongSanPham()
        {
            int tongSanPham = 0;
            foreach (DataRow row in dtChiTietHoaDon.Rows)
            {
                tongSanPham += Convert.ToInt32(row["SoLuong"]);
            }

            txtTongSoLuong.Text = tongSanPham.ToString();
        }

        private void ResetForm()
        {
            dtChiTietHoaDon.Clear();
            txtTongSoLuong.Text = "";
            txtMaHD.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtTongTien.Text = "";
            cmbMaSP.SelectedIndex = -1;
            cmbTenSanPham.SelectedIndex = -1;
            cmbMaNV.SelectedIndex = -1;
            dtPickerNgayLap.Value = DateTime.Now;
        }

        private string GenerateMaHD()
        {
            string maHD = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
            return maHD;
        }
        private void BindingData()
        {
            if (dgvSanPham.CurrentRow != null)
            {
                txtDonGia.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (CheckData == true && dgvSanPham.SelectedRows != null)
            {
                BindingData();
            }
        }
    }
}
