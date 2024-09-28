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
    public partial class frmChiTietPhieuNhap : Form
    {
        DBConnect dBConnect = new DBConnect();
        DataTable dt = new DataTable();

        private string maPhieuNhap;
        private string maSanPham;
        //private int soLuong;
        //private float donGia;
        private string tenSanPham;

        public frmChiTietPhieuNhap(string maPhieuNhap)
        {
            InitializeComponent();
            this.maPhieuNhap = maPhieuNhap;
            init();
        }

        private void init()
        {
            lblTenSP.Text = "Tên sản phẩm";
            lblDonGia.Text = "Đơn giá";
            lblSoLuong.Text = "Số lượng";
            Title.Text = "Chi Tiết Phiếu Nhập " + maPhieuNhap;
            loadComboBoxPhieuNhap();
            loadChiTietPhieuNhap();
            loadTongTien();
        }
        private void loadComboBoxPhieuNhap()
        {
            dt = dBConnect.execQuery("SELECT *FROM SANPHAM");
            cmbTenSP.DisplayMember = "TenSP";
            cmbTenSP.ValueMember = "MaSP";

            cmbTenSP.DataSource = dt;
        }
        private void cmbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox comboBox = sender as ComboBox;
            maSanPham = comboBox.SelectedValue.ToString();
            tenSanPham = comboBox.Text;
        }
        private void loadChiTietPhieuNhap()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("SELECT SANPHAM.TenSP as [Tên sản phẩm]");
            query.Append(", CHITIETPHIEUNHAP.SoLuong as [Số lượng]");
            query.Append(", CHITIETPHIEUNHAP.GiaNhap as [Đơn giá]");
            query.Append(", CHITIETPHIEUNHAP.SoLuong * CHITIETPHIEUNHAP.GiaNhap as [Thành tiền]");
            query.Append(" FROM SANPHAM, CHITIETPHIEUNHAP");
            query.Append(" WHERE SANPHAM.MaSP = CHITIETPHIEUNHAP.MaSP");
            query.Append(" AND CHITIETPHIEUNHAP.MaPhieuNhap = '" + maPhieuNhap + "'");
            dt = dBConnect.execQuery(query.ToString());
            dgvChiTietPhieuNhap.DataSource = dt;

            dgvChiTietPhieuNhap.Update();
            dgvChiTietPhieuNhap.Refresh();
        }
        private bool IsNumeric(string input)
        {
            return float.TryParse(input, out _);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maSanPham))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsNumeric(numSoluong.Text) || !IsNumeric(txtDonGia.Text))
            {
                MessageBox.Show("Số lượng và đơn giá phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (numSoluong.Value <= 0 || string.IsNullOrEmpty(txtDonGia.Text) || float.Parse(txtDonGia.Text) <= 0)
            {
                MessageBox.Show("Số lượng và đơn giá phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int dem = (int)dBConnect.execScaler("SELECT COUNT(*) FROM CHITIETPHIEUNHAP WHERE MaPhieuNhap = '" + maPhieuNhap + "' AND MaSP = '" + maSanPham + "'");

            if (dem == 0)
            {
                StringBuilder query = new StringBuilder("EXEC proc_ThemChiTietPhieuNhap ");
                query.Append("@maPhieuNhap = N'" + maPhieuNhap + "', ");
                query.Append("@maSanPham = N'" + maSanPham + "', ");
                query.Append("@soLuong = '" + numSoluong.Value + "',");
                query.Append("@giaNhap = '" + txtDonGia.Text + "'");
                int result = dBConnect.execNonQuery(query.ToString());

                if (result > 0)
                {
                    loadChiTietPhieuNhap();
                    loadTongTien();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                dem = (int)dBConnect.execScaler("SELECT SUM(SoLuong) FROM CHITIETPHIEUNHAP WHERE MaPhieuNhap = '" + maPhieuNhap + "' AND MaSP = '" + maSanPham + "'");
                upDate(dem);
            }
        }

        private void loadTongTien()
        {
            string query = "SELECT SUM(SoLuong * GiaNhap) FROM CHITIETPHIEUNHAP WHERE MaPhieuNhap = '" + maPhieuNhap + "'";
            object result = dBConnect.execScaler(query);

            if (result != DBNull.Value)
            {
                double tongTien = Convert.ToDouble(result);
                lblTongTien.Text = "Tổng tiền: " + tongTien.ToString();
            }
            else
            {
                lblTongTien.Text = "Tổng tiền: 0";
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm " + tenSanPham + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                string query = "DELETE FROM CHITIETPHIEUNHAP WHERE MaSP = @MaSP";

                using (SqlConnection connection = new SqlConnection(@"Data Source = THY; Initial Catalog = QL_NhaSach_Nhom1; User ID =sa; Password = sa"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaSP", maSanPham);

                    connection.Open();

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        loadChiTietPhieuNhap();
                        loadTongTien();
                        MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            upDate(0);
        }
        private void upDate(int soLuong)
        {
            StringBuilder query = new StringBuilder("EXEC proc_CapNhatChiTietPhieuNhap ");
            query.Append("@maPhieuNhap = N'" + maPhieuNhap + "', ");
            query.Append("@maSanPham = N'" + maSanPham + "', ");
            query.Append("@soLuong = '" + (numSoluong.Value + soLuong) + "',");
            query.Append("@giaNhap = '" + txtDonGia.Text + "'");
            int result = dBConnect.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadChiTietPhieuNhap();
                loadTongTien();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật sản phẩm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dgvChiTietPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            DataGridViewRow row = dgvChiTietPhieuNhap.Rows[rowID];

            tenSanPham = row.Cells[0].Value.ToString(); 
            cmbTenSP.Text = tenSanPham;
            numSoluong.Value = (int)row.Cells[1].Value;
            txtDonGia.Text = row.Cells[2].Value.ToString();

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            cmbTenSP.SelectedIndex = -1;
            numSoluong.Value = 0;
            txtDonGia.Clear();
        }
    }
}
