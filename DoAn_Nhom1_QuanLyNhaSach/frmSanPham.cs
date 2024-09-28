using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom1_QuanLyNhaSach
{
    public partial class frmSanPham : Form
    {
        DBConnect dBConnect = new DBConnect();
        SqlConnection connect;
        SqlDataAdapter adapt;
        DataTable tb_SP = new DataTable();
        DataColumn[] key;
        public frmSanPham()
        {
            InitializeComponent();
            connect = dBConnect.GetConnection();
            key = new DataColumn[1];
            string SqlAdapt = "select * from SANPHAM";
            adapt = new SqlDataAdapter(SqlAdapt, connect);
            adapt.Fill(tb_SP);
            key[0] = tb_SP.Columns[0];
            tb_SP.PrimaryKey = key;

        }
        private void LoadDataGridView()
        {
            string SqlAdapt = "select * from SANPHAM";
            adapt = new SqlDataAdapter(SqlAdapt, connect);
            DataTable tb_SP_Load = new DataTable();
            adapt.Fill(tb_SP_Load);
            dgvSanPham.DataSource = tb_SP_Load;
        }
        private void Loc_DSSP()
        {
            string SqlAdapt = "select * from SANPHAM where";

            if (cmbMaLoai != null && cmbMaLoai.SelectedValue != null && cmbMaLoai.Text != "Tất cả")
            {
                SqlAdapt += " MaLoai ='" + cmbMaLoai.SelectedValue.ToString() + "' and";
            }

            if (cmbNPP != null && cmbNPP.SelectedValue != null && cmbNPP.Text != "Tất cả")
            {
                SqlAdapt += " MaNPP='" + cmbNPP.SelectedValue.ToString() + "' and";
            }

            if (cmbMaTG != null && cmbMaTG.SelectedValue != null && cmbMaTG.Text != "Tất cả")
            {
                SqlAdapt += " MaTacGia='" + cmbMaTG.SelectedValue.ToString() + "' and";
            }

            SqlAdapt = SqlAdapt.Substring(0, SqlAdapt.Length - 3);
            adapt = new SqlDataAdapter(SqlAdapt, connect);
            DataTable tb_SP_Load = new DataTable();
            adapt.Fill(tb_SP_Load);
            dgvSanPham.DataSource = tb_SP_Load;
        }


        private void LoadMaLoai()
        {
            string SqlAdapt = "select * from THELOAISANPHAM";
            adapt = new SqlDataAdapter(SqlAdapt, connect);
            DataTable tb_TL = new DataTable();
            adapt.Fill(tb_TL);
            DataRow NewRow = tb_TL.NewRow();
            NewRow["MaLoai"] = "All";
            NewRow["TenLoai"] = "Tất cả";
            tb_TL.Rows.InsertAt(NewRow, 0);
            cmbMaLoai.DataSource = tb_TL;
            cmbMaLoai.DisplayMember = "Tenloai";
            cmbMaLoai.ValueMember = "Maloai";
        }
        private void LoadMaNPP()
        {
            string SqlAdapt = "select * from NHAPHANPHOI";
            adapt = new SqlDataAdapter(SqlAdapt, connect);
            DataTable tb_NPP = new DataTable();
            adapt.Fill(tb_NPP);
            DataRow NewRow = tb_NPP.NewRow();
            NewRow["MaNPP"] = "All";
            NewRow["TenNPP"] = "Tất cả";
            tb_NPP.Rows.InsertAt(NewRow, 0);
            cmbNPP.DataSource = tb_NPP;
            cmbNPP.DisplayMember = "TenNPP";
            cmbNPP.ValueMember = "MaNPP";
        }
        private void LoadMaTacGia()
        {
            string SqlAdapt = "select * from TACGIA";
            adapt = new SqlDataAdapter(SqlAdapt, connect);
            DataTable tb_TG = new DataTable();
            adapt.Fill(tb_TG);
            DataRow NewRow = tb_TG.NewRow();
            NewRow["MaTacGia"] = "All";
            NewRow["TenTacGia"] = "Tất cả";
            tb_TG.Rows.InsertAt(NewRow, 0);
            cmbMaTG.DataSource = tb_TG;
            cmbMaTG.DisplayMember = "TenTacGia";
            cmbMaTG.ValueMember = "MaTacGia";


        }
        private void RefreshDataGirdView()
        {
            dgvSanPham.Refresh();
        }
        private void BindingData()
        {
            if (dgvSanPham.CurrentRow != null)
            {
                txtMaSP.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
                txtTenSP.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
                txtDonGia.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
                txtSoLuong.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
                txtMota.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
                cmbMaLoai.Text = dgvSanPham.CurrentRow.Cells[6].Value.ToString();
                cmbNPP.Text = dgvSanPham.CurrentRow.Cells[7].Value.ToString();
                cmbMaTG.Text = dgvSanPham.CurrentRow.Cells[8].Value.ToString();
            }
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            cmbMaLoai.SelectedValueChanged -= cmbMaLoai_SelectedValueChanged;
            cmbNPP.SelectedValueChanged -= cmbNPP_SelectedValueChanged;
            cmbMaTG.SelectedValueChanged -= cmbMaTG_SelectedValueChanged;
            dgvSanPham.SelectionChanged += dgvSanPham_SelectionChanged;
            LoadMaLoai();
            LoadMaNPP();
            LoadMaTacGia();
            LoadDataGridView();
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            BindingData();
        }
        private void Them()
        {
            if (ValidateInput())
            {
                DataRow existingRow = tb_SP.Rows.Find(txtMaSP.Text);
                if (existingRow == null)
                {
                    DataRow newRow = tb_SP.NewRow();
                    newRow["MaSP"] = txtMaSP.Text;
                    newRow["TenSP"] = txtTenSP.Text;
                    newRow["DonGia"] = float.Parse(txtDonGia.Text);
                    newRow["MoTa"] = txtMota.Text;
                    newRow["SoLuong"] = int.Parse(txtSoLuong.Text);
                    newRow["MaLoai"] = cmbMaLoai.SelectedValue.ToString();
                    newRow["MaNPP"] = cmbNPP.SelectedValue.ToString();
                    newRow["MaTacGia"] = cmbMaTG.SelectedValue.ToString();
                    tb_SP.Rows.Add(newRow);

                    SqlCommandBuilder SQLCmd = new SqlCommandBuilder(adapt);
                    int kq = adapt.Update(tb_SP);
                    if (kq != 0)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại!", "Thông báo");
                }
            }
        }
        private void Xoa()
        {
            DataRow DeleteRow = tb_SP.Rows.Find(txtMaSP.Text);
            if (DeleteRow != null)
            {
                DeleteRow.Delete();
                SqlCommandBuilder SQLCmd = new SqlCommandBuilder(adapt);
                int kq = adapt.Update(tb_SP);
                if (kq != 0)
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xoá thất bại!", "Thông báo");
                }

            }
            else
            {
                MessageBox.Show("Sản phẩm không tồn tại!", "Thông báo");
            }
        }
        private void Sua()
        {
            if (ValidateInput())
            {
                DataRow existingRow = tb_SP.Rows.Find(txtMaSP.Text);
                if (existingRow != null)
                {

                    SqlCommandBuilder SQLCmd = new SqlCommandBuilder(adapt);
                    int kq = adapt.Update(tb_SP);
                    if (kq != 0)
                    {
                        MessageBox.Show("Sửa thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại!", "Thông báo");
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Chưa nhập Mã Sản phẩm!", "Thông báo");
                return false;
            }

            if (cmbMaLoai.SelectedIndex <= 0)
            {
                MessageBox.Show("Chưa chọn Mã Loại!", "Thông báo");
                return false;
            }

            if (cmbNPP.SelectedIndex <= 0)
            {
                MessageBox.Show("Chưa chọn Mã Nhà phân phối!", "Thông báo");
                return false;
            }

            if (cmbMaTG.SelectedIndex <= 0)
            {
                MessageBox.Show("Chưa chọn Mã Tác giả!", "Thông báo");
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them();
            LoadDataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Xoa();
            LoadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sua();
            LoadDataGridView();
        }

        private void frmSanPham_Shown(object sender, EventArgs e)
        {
            cmbMaLoai.SelectedValueChanged += cmbMaLoai_SelectedValueChanged;
            cmbNPP.SelectedValueChanged += cmbNPP_SelectedValueChanged;
            cmbMaTG.SelectedValueChanged += cmbMaTG_SelectedValueChanged;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtMota.Clear();

            DateTimePicker1.Value = DateTime.Now;

            cmbMaLoai.SelectedIndex = 0;
            cmbNPP.SelectedIndex = 0;
            cmbMaTG.SelectedIndex = 0;
        }

        private void cmbMaLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            Loc_DSSP();
        }

        private void cmbNPP_SelectedValueChanged(object sender, EventArgs e)
        {
            Loc_DSSP();
        }

        private void cmbMaTG_SelectedValueChanged(object sender, EventArgs e)
        {
            Loc_DSSP();
        }
    }
}
