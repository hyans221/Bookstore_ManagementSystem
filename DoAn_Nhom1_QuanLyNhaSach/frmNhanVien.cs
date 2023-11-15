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
    public partial class frmNhanVien : Form
    {
        DBConnect dbConnect = new DBConnect();
        public frmNhanVien()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM NHANVIEN";
            DataTable dt = dbConnect.getDatatable(sql);
            dgvNhanVien.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            string diaChi = txtDiaChi.Text;
            string sql = $"INSERT INTO NHANVIEN (MaNV, TenNV, DiaChi) VALUES ('{maNV}', '{tenNV}', '{diaChi}')";
            dbConnect.getNonQuery(sql);
            LoadData();
            ResetFormControls();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string sql = $"DELETE FROM NHANVIEN WHERE MaNV = '{maNV}'";
            dbConnect.getNonQuery(sql);
            LoadData();
            ResetFormControls();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            string diaChi = txtDiaChi.Text;
            string sql = $"UPDATE NHANVIEN SET TenNV = '{tenNV}', DiaChi = '{diaChi}' WHERE MaNV = '{maNV}'";
            dbConnect.getNonQuery(sql);
            LoadData();
            ResetFormControls();
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiaChi.Clear();
        }
    }
}
