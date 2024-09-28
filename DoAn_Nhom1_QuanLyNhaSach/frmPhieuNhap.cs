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
    public partial class frmPhieuNhap : Form
    {

        DBConnect dBConnect = new DBConnect();
        DataTable dt = new DataTable();
        private string maPN;
        private DateTime ngayTaoPhieu;
        private string maNPP;
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            loadPhieuNhap();
            LoadDataToComboBox();
        }
        private bool kiemTraTrungKhoa(string maPN)
        {
            string query = "SELECT COUNT(*) FROM PHIEUNHAP WHERE MaPhieuNhap = @MaPhieuNhap";
            using (SqlConnection connection = new SqlConnection(@"Data Source = THY; Initial Catalog = DB_QL_NHASACH_NHOM1; User ID =sa; Password = sa"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaPhieuNhap", txtMaPN.Text);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPN.Text))
            {
                MessageBox.Show("Mã phiếu nhập không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (kiemTraTrungKhoa(maPN))
            {
                MessageBox.Show("Mã phiếu nhập đã tồn tại. Vui lòng nhập mã phiếu nhập khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            StringBuilder query = new StringBuilder("EXEC pro_themPhieuNhap ");
            query.Append("@maPN = N'" + txtMaPN.Text + "', ");
            query.Append("@ngayTaoPhieu = N'" + dtPickerNgayTaoPhieu.Value + "', ");
            query.Append("@nhaPP = N'" + cmbMaNPP.SelectedValue.ToString() + "'");
            int result = dBConnect.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadPhieuNhap();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Thêm phiếu nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập " + txtMaPN.Text + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                string query = "DELETE FROM PHIEUNHAP WHERE MaPhieuNhap = @MaPhieuNhap";

                using (SqlConnection connection = new SqlConnection(@"Data Source = THY; Initial Catalog = DB_QL_NHASACH_NHOM1; User ID =sa; Password = sa"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaPhieuNhap", txtMaPN.Text);

                    connection.Open();

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        loadPhieuNhap();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPN.Text))
            {
                MessageBox.Show("Mã phiếu nhập không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            StringBuilder query = new StringBuilder("EXEC proc_CapNhatPhieuNhap ");
            query.Append("@maPN = N'" + txtMaPN.Text + "',");
            query.Append("@ngayTaoPhieu = N'" + dtPickerNgayTaoPhieu.Value + "', ");
            query.Append("@maNPP = N'" + cmbMaNPP.SelectedValue.ToString() + "'");
            int result = dBConnect.execNonQuery(query.ToString());
            if (result > 0)
            {
                loadPhieuNhap();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Sửa phiếu nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void loadPhieuNhap()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("SELECT MaPhieuNhap as [Mã phiếu nhập]");
            query.Append(",NgayTaoPhieu as [Ngày tạo phiếu]");
            query.Append(",MaNPP as [Mã nhà phân phối]");
            query.Append("FROM PHIEUNHAP");
            dt = dBConnect.execQuery(query.ToString());
            dgvPhieuNhap.DataSource = dt;
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID >= 0 && rowID < dgvPhieuNhap.Rows.Count)
            {
                DataGridViewRow row = dgvPhieuNhap.Rows[rowID];

                if (row.Cells[0].Value != null)
                {
                    txtMaPN.Text = row.Cells[0].Value?.ToString();
                    if (DateTime.TryParse(row.Cells[1].Value?.ToString(), out DateTime ngayTaoPhieu))
                    {
                        dtPickerNgayTaoPhieu.Value = ngayTaoPhieu;
                    }

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        cmbMaNPP.DisplayMember = "TenNPP";
                        cmbMaNPP.ValueMember = "MaNPP";
                        cmbMaNPP.DataSource = dt;

                        string selectedValue = row.Cells[2].Value?.ToString();
                        if (dt.Rows.Cast<DataRow>().Any(r => r["MaNPP"].ToString() == selectedValue))
                        {
                            cmbMaNPP.SelectedValue = selectedValue;
                        }
                        else
                        {
                            cmbMaNPP.SelectedIndex = -1;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Dòng chọn không có dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void LoadDataToComboBox()
        {
            dt = dBConnect.execQuery("SELECT *FROM NHAPHANPHOI");
            cmbMaNPP.DisplayMember = "TenNPP";
            cmbMaNPP.ValueMember = "MaNPP";

            cmbMaNPP.DataSource = dt;
        }
        private void cmbMaNPP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null && comboBox.SelectedValue != null)
            {
                maNPP = comboBox.SelectedValue.ToString();
            }
            else
            {
                maNPP = ""; 
            }
        }

        private void btnChiTietPhieuNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPN.Text))
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmChiTietPhieuNhap chiTietForm = new frmChiTietPhieuNhap(txtMaPN.Text);
            this.Hide();
            chiTietForm.Show();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtMaPN.Clear();
            dtPickerNgayTaoPhieu.Value = DateTime.Now;

            cmbMaNPP.SelectedIndex = 0;
        }

    }
}
