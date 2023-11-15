namespace DoAn_Nhom1_QuanLyNhaSach
{
    partial class frmPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvPhieuNhap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.cmbMaNPP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtPickerNgayTaoPhieu = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.lblSoLuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaPN = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNgayTaoPhieu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaPN = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(800, 541);
            this.Panel1.TabIndex = 2;
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.Controls.Add(this.dgvPhieuNhap);
            this.Panel3.Location = new System.Drawing.Point(26, 260);
            this.Panel3.Name = "Panel3";
            this.Panel3.ShadowDecoration.Parent = this.Panel3;
            this.Panel3.Size = new System.Drawing.Size(747, 261);
            this.Panel3.TabIndex = 1;
            // 
            // dgvPhieuNhap
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhieuNhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieuNhap.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhieuNhap.EnableHeadersVisualStyles = false;
            this.dgvPhieuNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhieuNhap.Location = new System.Drawing.Point(26, 15);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.RowHeadersVisible = false;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(701, 227);
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPhieuNhap.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhieuNhap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPhieuNhap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPhieuNhap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPhieuNhap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPhieuNhap.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPhieuNhap.ThemeStyle.ReadOnly = false;
            this.dgvPhieuNhap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhieuNhap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPhieuNhap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPhieuNhap.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPhieuNhap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhieuNhap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.Controls.Add(this.btnSua);
            this.Panel2.Controls.Add(this.cmbMaNPP);
            this.Panel2.Controls.Add(this.dtPickerNgayTaoPhieu);
            this.Panel2.Controls.Add(this.btnThem);
            this.Panel2.Controls.Add(this.btnXoa);
            this.Panel2.Controls.Add(this.lblSoLuong);
            this.Panel2.Controls.Add(this.txtMaPN);
            this.Panel2.Controls.Add(this.lblNgayTaoPhieu);
            this.Panel2.Controls.Add(this.lblMaPN);
            this.Panel2.Location = new System.Drawing.Point(26, 12);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(747, 229);
            this.Panel2.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BorderRadius = 12;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Location = new System.Drawing.Point(505, 165);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(169, 42);
            this.btnSua.TabIndex = 61;
            this.btnSua.Text = "Sửa";
            // 
            // cmbMaNPP
            // 
            this.cmbMaNPP.BackColor = System.Drawing.Color.Transparent;
            this.cmbMaNPP.BorderRadius = 15;
            this.cmbMaNPP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaNPP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaNPP.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMaNPP.FocusedState.Parent = this.cmbMaNPP;
            this.cmbMaNPP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMaNPP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMaNPP.FormattingEnabled = true;
            this.cmbMaNPP.HoverState.Parent = this.cmbMaNPP;
            this.cmbMaNPP.ItemHeight = 30;
            this.cmbMaNPP.ItemsAppearance.Parent = this.cmbMaNPP;
            this.cmbMaNPP.Location = new System.Drawing.Point(214, 147);
            this.cmbMaNPP.Name = "cmbMaNPP";
            this.cmbMaNPP.ShadowDecoration.Parent = this.cmbMaNPP;
            this.cmbMaNPP.Size = new System.Drawing.Size(208, 36);
            this.cmbMaNPP.TabIndex = 60;
            // 
            // dtPickerNgayTaoPhieu
            // 
            this.dtPickerNgayTaoPhieu.BorderRadius = 15;
            this.dtPickerNgayTaoPhieu.CheckedState.Parent = this.dtPickerNgayTaoPhieu;
            this.dtPickerNgayTaoPhieu.FillColor = System.Drawing.Color.Gainsboro;
            this.dtPickerNgayTaoPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtPickerNgayTaoPhieu.HoverState.Parent = this.dtPickerNgayTaoPhieu;
            this.dtPickerNgayTaoPhieu.Location = new System.Drawing.Point(214, 91);
            this.dtPickerNgayTaoPhieu.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPickerNgayTaoPhieu.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPickerNgayTaoPhieu.Name = "dtPickerNgayTaoPhieu";
            this.dtPickerNgayTaoPhieu.ShadowDecoration.Parent = this.dtPickerNgayTaoPhieu;
            this.dtPickerNgayTaoPhieu.Size = new System.Drawing.Size(208, 36);
            this.dtPickerNgayTaoPhieu.TabIndex = 59;
            this.dtPickerNgayTaoPhieu.Value = new System.DateTime(2023, 11, 11, 1, 32, 18, 66);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BorderRadius = 12;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.SteelBlue;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(505, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(169, 44);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BorderRadius = 12;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.IndianRed;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(505, 95);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(169, 44);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xoá";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSoLuong.Location = new System.Drawing.Point(58, 155);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(136, 20);
            this.lblSoLuong.TabIndex = 49;
            this.lblSoLuong.Text = "Mã nhà phân phối";
            // 
            // txtMaPN
            // 
            this.txtMaPN.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtMaPN.BorderRadius = 10;
            this.txtMaPN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPN.DefaultText = "";
            this.txtMaPN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaPN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaPN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPN.DisabledState.Parent = this.txtMaPN;
            this.txtMaPN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPN.FocusedState.Parent = this.txtMaPN;
            this.txtMaPN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.ForeColor = System.Drawing.Color.Black;
            this.txtMaPN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPN.HoverState.Parent = this.txtMaPN;
            this.txtMaPN.Location = new System.Drawing.Point(214, 35);
            this.txtMaPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.PasswordChar = '*';
            this.txtMaPN.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMaPN.PlaceholderText = "";
            this.txtMaPN.SelectedText = "";
            this.txtMaPN.ShadowDecoration.Parent = this.txtMaPN;
            this.txtMaPN.Size = new System.Drawing.Size(208, 36);
            this.txtMaPN.TabIndex = 48;
            // 
            // lblNgayTaoPhieu
            // 
            this.lblNgayTaoPhieu.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayTaoPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTaoPhieu.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNgayTaoPhieu.Location = new System.Drawing.Point(58, 99);
            this.lblNgayTaoPhieu.Name = "lblNgayTaoPhieu";
            this.lblNgayTaoPhieu.Size = new System.Drawing.Size(115, 20);
            this.lblNgayTaoPhieu.TabIndex = 44;
            this.lblNgayTaoPhieu.Text = "Ngày tạo phiếu";
            // 
            // lblMaPN
            // 
            this.lblMaPN.BackColor = System.Drawing.Color.Transparent;
            this.lblMaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPN.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMaPN.Location = new System.Drawing.Point(58, 43);
            this.lblMaPN.Name = "lblMaPN";
            this.lblMaPN.Size = new System.Drawing.Size(112, 20);
            this.lblMaPN.TabIndex = 45;
            this.lblMaPN.Text = "Mã phiếu nhập";
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.Panel1);
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.Panel1.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2Panel Panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhieuNhap;
        private Guna.UI2.WinForms.Guna2Panel Panel2;
        internal Guna.UI2.WinForms.Guna2Button btnThem;
        internal Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoLuong;
        internal Guna.UI2.WinForms.Guna2TextBox txtMaPN;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayTaoPhieu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaPN;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtPickerNgayTaoPhieu;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMaNPP;
        internal Guna.UI2.WinForms.Guna2Button btnSua;
    }
}