
namespace DoAn_Nhom1_QuanLyNhaSach
{
    partial class frmThongKe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.cmbLoaiThongKe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPhamViThongKe = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLoaiThongKe = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtPickerPhamViThongKe = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnInThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cptPhieuNhap1 = new DoAn_Nhom1_QuanLyNhaSach.cptPhieuNhap();
            this.cptTonKho1 = new DoAn_Nhom1_QuanLyNhaSach.cptTonKho();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 616);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnLamMoi);
            this.panel3.Controls.Add(this.cmbLoaiThongKe);
            this.panel3.Controls.Add(this.lblPhamViThongKe);
            this.panel3.Controls.Add(this.lblLoaiThongKe);
            this.panel3.Controls.Add(this.dtPickerPhamViThongKe);
            this.panel3.Controls.Add(this.btnInThongKe);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(978, 147);
            this.panel3.TabIndex = 20;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.BorderRadius = 12;
            this.btnLamMoi.CheckedState.Parent = this.btnLamMoi;
            this.btnLamMoi.CustomImages.Parent = this.btnLamMoi;
            this.btnLamMoi.FillColor = System.Drawing.Color.DarkOrange;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.HoverState.Parent = this.btnLamMoi;
            this.btnLamMoi.Location = new System.Drawing.Point(737, 77);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShadowDecoration.Parent = this.btnLamMoi;
            this.btnLamMoi.Size = new System.Drawing.Size(132, 42);
            this.btnLamMoi.TabIndex = 83;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cmbLoaiThongKe
            // 
            this.cmbLoaiThongKe.BackColor = System.Drawing.Color.Transparent;
            this.cmbLoaiThongKe.BorderRadius = 15;
            this.cmbLoaiThongKe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiThongKe.FocusedColor = System.Drawing.Color.Empty;
            this.cmbLoaiThongKe.FocusedState.Parent = this.cmbLoaiThongKe;
            this.cmbLoaiThongKe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLoaiThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbLoaiThongKe.FormattingEnabled = true;
            this.cmbLoaiThongKe.HoverState.Parent = this.cmbLoaiThongKe;
            this.cmbLoaiThongKe.ItemHeight = 30;
            this.cmbLoaiThongKe.Items.AddRange(new object[] {
            "Thống kê phiếu nhập",
            "Thống kê tồn kho"});
            this.cmbLoaiThongKe.ItemsAppearance.Parent = this.cmbLoaiThongKe;
            this.cmbLoaiThongKe.Location = new System.Drawing.Point(248, 20);
            this.cmbLoaiThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLoaiThongKe.Name = "cmbLoaiThongKe";
            this.cmbLoaiThongKe.ShadowDecoration.Parent = this.cmbLoaiThongKe;
            this.cmbLoaiThongKe.Size = new System.Drawing.Size(246, 36);
            this.cmbLoaiThongKe.TabIndex = 82;
            // 
            // lblPhamViThongKe
            // 
            this.lblPhamViThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhamViThongKe.BackColor = System.Drawing.Color.Transparent;
            this.lblPhamViThongKe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhamViThongKe.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPhamViThongKe.Location = new System.Drawing.Point(66, 92);
            this.lblPhamViThongKe.Name = "lblPhamViThongKe";
            this.lblPhamViThongKe.Size = new System.Drawing.Size(117, 19);
            this.lblPhamViThongKe.TabIndex = 80;
            this.lblPhamViThongKe.Text = "Phạm vi thống kê";
            // 
            // lblLoaiThongKe
            // 
            this.lblLoaiThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoaiThongKe.BackColor = System.Drawing.Color.Transparent;
            this.lblLoaiThongKe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiThongKe.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLoaiThongKe.Location = new System.Drawing.Point(66, 29);
            this.lblLoaiThongKe.Name = "lblLoaiThongKe";
            this.lblLoaiThongKe.Size = new System.Drawing.Size(94, 19);
            this.lblLoaiThongKe.TabIndex = 81;
            this.lblLoaiThongKe.Text = "Loại thống kê";
            // 
            // dtPickerPhamViThongKe
            // 
            this.dtPickerPhamViThongKe.BorderRadius = 15;
            this.dtPickerPhamViThongKe.CheckedState.Parent = this.dtPickerPhamViThongKe;
            this.dtPickerPhamViThongKe.FillColor = System.Drawing.Color.Gainsboro;
            this.dtPickerPhamViThongKe.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtPickerPhamViThongKe.HoverState.Parent = this.dtPickerPhamViThongKe;
            this.dtPickerPhamViThongKe.Location = new System.Drawing.Point(248, 83);
            this.dtPickerPhamViThongKe.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPickerPhamViThongKe.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPickerPhamViThongKe.Name = "dtPickerPhamViThongKe";
            this.dtPickerPhamViThongKe.ShadowDecoration.Parent = this.dtPickerPhamViThongKe;
            this.dtPickerPhamViThongKe.Size = new System.Drawing.Size(246, 36);
            this.dtPickerPhamViThongKe.TabIndex = 62;
            this.dtPickerPhamViThongKe.Value = new System.DateTime(2023, 11, 11, 1, 32, 18, 66);
            // 
            // btnInThongKe
            // 
            this.btnInThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInThongKe.BorderRadius = 15;
            this.btnInThongKe.CheckedState.Parent = this.btnInThongKe;
            this.btnInThongKe.CustomImages.Parent = this.btnInThongKe;
            this.btnInThongKe.FillColor = System.Drawing.Color.SkyBlue;
            this.btnInThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnInThongKe.ForeColor = System.Drawing.Color.White;
            this.btnInThongKe.HoverState.Parent = this.btnInThongKe;
            this.btnInThongKe.ImageSize = new System.Drawing.Size(35, 35);
            this.btnInThongKe.Location = new System.Drawing.Point(737, 20);
            this.btnInThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnInThongKe.Name = "btnInThongKe";
            this.btnInThongKe.ShadowDecoration.Parent = this.btnInThongKe;
            this.btnInThongKe.Size = new System.Drawing.Size(132, 42);
            this.btnInThongKe.TabIndex = 18;
            this.btnInThongKe.Text = "In thống kê";
            this.btnInThongKe.Click += new System.EventHandler(this.btnInThongKe_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.crystalReportViewer1);
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 434);
            this.panel2.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1002, 434);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 616);
            this.Controls.Add(this.panel1);
            this.Name = "frmThongKe";
            this.Text = "frmBaoCaoPhieuNhap";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnInThongKe;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtPickerPhamViThongKe;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhamViThongKe;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLoaiThongKe;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLoaiThongKe;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private cptPhieuNhap cptPhieuNhap1;
        private cptTonKho cptTonKho1;
        internal Guna.UI2.WinForms.Guna2Button btnLamMoi;
    }
}