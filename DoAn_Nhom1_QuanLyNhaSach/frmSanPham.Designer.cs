namespace DoAn_Nhom1_QuanLyNhaSach
{
    partial class frmSanPham
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
            this.DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbMaTG = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbNPP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbMaLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMaTG = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaNPP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMoTa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaLoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSoLuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDonGia = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMota = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenSP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaSP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvSanPham = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
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
            this.Panel1.Size = new System.Drawing.Size(991, 696);
            this.Panel1.TabIndex = 0;
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.Controls.Add(this.DateTimePicker1);
            this.Panel3.Controls.Add(this.cmbMaTG);
            this.Panel3.Controls.Add(this.cmbNPP);
            this.Panel3.Controls.Add(this.cmbMaLoai);
            this.Panel3.Controls.Add(this.lblMaTG);
            this.Panel3.Controls.Add(this.lblMaNPP);
            this.Panel3.Controls.Add(this.lblMoTa);
            this.Panel3.Controls.Add(this.lblMaLoai);
            this.Panel3.Controls.Add(this.lblSoLuong);
            this.Panel3.Controls.Add(this.lblDonGia);
            this.Panel3.Controls.Add(this.txtMota);
            this.Panel3.Controls.Add(this.txtSoLuong);
            this.Panel3.Controls.Add(this.txtTenSP);
            this.Panel3.Controls.Add(this.lblTenSP);
            this.Panel3.Controls.Add(this.lblMaSP);
            this.Panel3.Controls.Add(this.txtDonGia);
            this.Panel3.Controls.Add(this.txtMaSP);
            this.Panel3.Controls.Add(this.btnThem);
            this.Panel3.Controls.Add(this.btnSua);
            this.Panel3.Controls.Add(this.btnXoa);
            this.Panel3.Location = new System.Drawing.Point(12, 3);
            this.Panel3.Name = "Panel3";
            this.Panel3.ShadowDecoration.Parent = this.Panel3;
            this.Panel3.Size = new System.Drawing.Size(956, 269);
            this.Panel3.TabIndex = 25;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTimePicker1.BorderRadius = 15;
            this.DateTimePicker1.CheckedState.Parent = this.DateTimePicker1;
            this.DateTimePicker1.FillColor = System.Drawing.Color.Gainsboro;
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker1.HoverState.Parent = this.DateTimePicker1;
            this.DateTimePicker1.Location = new System.Drawing.Point(492, 193);
            this.DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.ShadowDecoration.Parent = this.DateTimePicker1;
            this.DateTimePicker1.Size = new System.Drawing.Size(208, 36);
            this.DateTimePicker1.TabIndex = 58;
            this.DateTimePicker1.Value = new System.DateTime(2023, 11, 11, 1, 32, 18, 66);
            // 
            // cmbMaTG
            // 
            this.cmbMaTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMaTG.BackColor = System.Drawing.Color.Transparent;
            this.cmbMaTG.BorderRadius = 15;
            this.cmbMaTG.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaTG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaTG.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMaTG.FocusedState.Parent = this.cmbMaTG;
            this.cmbMaTG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMaTG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMaTG.FormattingEnabled = true;
            this.cmbMaTG.HoverState.Parent = this.cmbMaTG;
            this.cmbMaTG.ItemHeight = 30;
            this.cmbMaTG.ItemsAppearance.Parent = this.cmbMaTG;
            this.cmbMaTG.Location = new System.Drawing.Point(512, 132);
            this.cmbMaTG.Name = "cmbMaTG";
            this.cmbMaTG.ShadowDecoration.Parent = this.cmbMaTG;
            this.cmbMaTG.Size = new System.Drawing.Size(187, 36);
            this.cmbMaTG.TabIndex = 57;
            // 
            // cmbNPP
            // 
            this.cmbNPP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbNPP.BackColor = System.Drawing.Color.Transparent;
            this.cmbNPP.BorderRadius = 15;
            this.cmbNPP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNPP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNPP.FocusedColor = System.Drawing.Color.Empty;
            this.cmbNPP.FocusedState.Parent = this.cmbNPP;
            this.cmbNPP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNPP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbNPP.FormattingEnabled = true;
            this.cmbNPP.HoverState.Parent = this.cmbNPP;
            this.cmbNPP.ItemHeight = 30;
            this.cmbNPP.ItemsAppearance.Parent = this.cmbNPP;
            this.cmbNPP.Location = new System.Drawing.Point(512, 80);
            this.cmbNPP.Name = "cmbNPP";
            this.cmbNPP.ShadowDecoration.Parent = this.cmbNPP;
            this.cmbNPP.Size = new System.Drawing.Size(187, 36);
            this.cmbNPP.TabIndex = 56;
            // 
            // cmbMaLoai
            // 
            this.cmbMaLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMaLoai.BackColor = System.Drawing.Color.Transparent;
            this.cmbMaLoai.BorderRadius = 15;
            this.cmbMaLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaLoai.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMaLoai.FocusedState.Parent = this.cmbMaLoai;
            this.cmbMaLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMaLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMaLoai.FormattingEnabled = true;
            this.cmbMaLoai.HoverState.Parent = this.cmbMaLoai;
            this.cmbMaLoai.ItemHeight = 30;
            this.cmbMaLoai.ItemsAppearance.Parent = this.cmbMaLoai;
            this.cmbMaLoai.Location = new System.Drawing.Point(512, 28);
            this.cmbMaLoai.Name = "cmbMaLoai";
            this.cmbMaLoai.ShadowDecoration.Parent = this.cmbMaLoai;
            this.cmbMaLoai.Size = new System.Drawing.Size(187, 36);
            this.cmbMaLoai.TabIndex = 55;
            // 
            // lblMaTG
            // 
            this.lblMaTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaTG.BackColor = System.Drawing.Color.Transparent;
            this.lblMaTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTG.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMaTG.Location = new System.Drawing.Point(431, 141);
            this.lblMaTG.Name = "lblMaTG";
            this.lblMaTG.Size = new System.Drawing.Size(75, 18);
            this.lblMaTG.TabIndex = 49;
            this.lblMaTG.Text = "Mã tác giả";
            // 
            // lblMaNPP
            // 
            this.lblMaNPP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaNPP.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNPP.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMaNPP.Location = new System.Drawing.Point(431, 89);
            this.lblMaNPP.Name = "lblMaNPP";
            this.lblMaNPP.Size = new System.Drawing.Size(59, 18);
            this.lblMaNPP.TabIndex = 50;
            this.lblMaNPP.Text = "Mã NPP";
            // 
            // lblMoTa
            // 
            this.lblMoTa.BackColor = System.Drawing.Color.Transparent;
            this.lblMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMoTa.Location = new System.Drawing.Point(22, 194);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(41, 18);
            this.lblMoTa.TabIndex = 51;
            this.lblMoTa.Text = "Mô tả";
            // 
            // lblMaLoai
            // 
            this.lblMaLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaLoai.BackColor = System.Drawing.Color.Transparent;
            this.lblMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoai.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMaLoai.Location = new System.Drawing.Point(431, 37);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(54, 18);
            this.lblMaLoai.TabIndex = 54;
            this.lblMaLoai.Text = "Mã loại";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSoLuong.Location = new System.Drawing.Point(22, 148);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(64, 18);
            this.lblSoLuong.TabIndex = 52;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblDonGia
            // 
            this.lblDonGia.BackColor = System.Drawing.Color.Transparent;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDonGia.Location = new System.Drawing.Point(22, 105);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(56, 18);
            this.lblDonGia.TabIndex = 53;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // txtMota
            // 
            this.txtMota.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtMota.BorderRadius = 10;
            this.txtMota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMota.DefaultText = "";
            this.txtMota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMota.DisabledState.Parent = this.txtMota;
            this.txtMota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMota.FocusedState.Parent = this.txtMota;
            this.txtMota.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMota.ForeColor = System.Drawing.Color.Black;
            this.txtMota.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMota.HoverState.Parent = this.txtMota;
            this.txtMota.Location = new System.Drawing.Point(145, 187);
            this.txtMota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMota.Name = "txtMota";
            this.txtMota.PasswordChar = '*';
            this.txtMota.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMota.PlaceholderText = "";
            this.txtMota.SelectedText = "";
            this.txtMota.ShadowDecoration.Parent = this.txtMota;
            this.txtMota.Size = new System.Drawing.Size(232, 64);
            this.txtMota.TabIndex = 46;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSoLuong.BorderRadius = 10;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DefaultText = "";
            this.txtSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.DisabledState.Parent = this.txtSoLuong;
            this.txtSoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.FocusedState.Parent = this.txtSoLuong;
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.HoverState.Parent = this.txtSoLuong;
            this.txtSoLuong.Location = new System.Drawing.Point(145, 144);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '*';
            this.txtSoLuong.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.ShadowDecoration.Parent = this.txtSoLuong;
            this.txtSoLuong.Size = new System.Drawing.Size(232, 27);
            this.txtSoLuong.TabIndex = 47;
            // 
            // txtTenSP
            // 
            this.txtTenSP.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtTenSP.BorderRadius = 10;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.DefaultText = "";
            this.txtTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.DisabledState.Parent = this.txtTenSP;
            this.txtTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.FocusedState.Parent = this.txtTenSP;
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.ForeColor = System.Drawing.Color.Black;
            this.txtTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.HoverState.Parent = this.txtTenSP;
            this.txtTenSP.Location = new System.Drawing.Point(145, 58);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PasswordChar = '*';
            this.txtTenSP.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTenSP.PlaceholderText = "";
            this.txtTenSP.SelectedText = "";
            this.txtTenSP.ShadowDecoration.Parent = this.txtTenSP;
            this.txtTenSP.Size = new System.Drawing.Size(232, 27);
            this.txtTenSP.TabIndex = 48;
            // 
            // lblTenSP
            // 
            this.lblTenSP.BackColor = System.Drawing.Color.Transparent;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTenSP.Location = new System.Drawing.Point(22, 62);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(101, 18);
            this.lblTenSP.TabIndex = 44;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // lblMaSP
            // 
            this.lblMaSP.BackColor = System.Drawing.Color.Transparent;
            this.lblMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMaSP.Location = new System.Drawing.Point(22, 19);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(95, 18);
            this.lblMaSP.TabIndex = 45;
            this.lblMaSP.Text = "Mã sản phẩm";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtDonGia.BorderRadius = 10;
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.DefaultText = "";
            this.txtDonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.DisabledState.Parent = this.txtDonGia;
            this.txtDonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.FocusedState.Parent = this.txtDonGia;
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.Black;
            this.txtDonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.HoverState.Parent = this.txtDonGia;
            this.txtDonGia.Location = new System.Drawing.Point(145, 101);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '*';
            this.txtDonGia.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.ShadowDecoration.Parent = this.txtDonGia;
            this.txtDonGia.Size = new System.Drawing.Size(232, 27);
            this.txtDonGia.TabIndex = 42;
            // 
            // txtMaSP
            // 
            this.txtMaSP.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtMaSP.BorderRadius = 10;
            this.txtMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSP.DefaultText = "";
            this.txtMaSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSP.DisabledState.Parent = this.txtMaSP;
            this.txtMaSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSP.FocusedState.Parent = this.txtMaSP;
            this.txtMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.ForeColor = System.Drawing.Color.Black;
            this.txtMaSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSP.HoverState.Parent = this.txtMaSP;
            this.txtMaSP.Location = new System.Drawing.Point(145, 15);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.PasswordChar = '*';
            this.txtMaSP.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMaSP.PlaceholderText = "";
            this.txtMaSP.SelectedText = "";
            this.txtMaSP.ShadowDecoration.Parent = this.txtMaSP;
            this.txtMaSP.Size = new System.Drawing.Size(232, 27);
            this.txtMaSP.TabIndex = 43;
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
            this.btnThem.Location = new System.Drawing.Point(773, 47);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(151, 42);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
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
            this.btnSua.Location = new System.Drawing.Point(773, 187);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(151, 42);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
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
            this.btnXoa.Location = new System.Drawing.Point(773, 117);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(151, 42);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xoá";
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.Controls.Add(this.dgvSanPham);
            this.Panel2.Location = new System.Drawing.Point(12, 292);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(956, 392);
            this.Panel2.TabIndex = 24;
            // 
            // dgvSanPham
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSanPham.Location = new System.Drawing.Point(21, 9);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(914, 360);
            this.dgvSanPham.TabIndex = 23;
            this.dgvSanPham.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSanPham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSanPham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSanPham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSanPham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSanPham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSanPham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSanPham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSanPham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSanPham.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvSanPham.ThemeStyle.ReadOnly = false;
            this.dgvSanPham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSanPham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSanPham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvSanPham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSanPham.ThemeStyle.RowsStyle.Height = 22;
            this.dgvSanPham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSanPham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 696);
            this.Controls.Add(this.Panel1);
            this.Name = "frmSanPham";
            this.Text = "frmQuanLySanPham";
            this.Panel1.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2Panel Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSanPham;
        private Guna.UI2.WinForms.Guna2Panel Panel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMaTG;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNPP;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMaLoai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaTG;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaNPP;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMoTa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaLoai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoLuong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDonGia;
        internal Guna.UI2.WinForms.Guna2TextBox txtMota;
        internal Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
        internal Guna.UI2.WinForms.Guna2TextBox txtTenSP;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenSP;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaSP;
        internal Guna.UI2.WinForms.Guna2TextBox txtDonGia;
        internal Guna.UI2.WinForms.Guna2TextBox txtMaSP;
        internal Guna.UI2.WinForms.Guna2Button btnThem;
        internal Guna.UI2.WinForms.Guna2Button btnSua;
        internal Guna.UI2.WinForms.Guna2Button btnXoa;
    }
}