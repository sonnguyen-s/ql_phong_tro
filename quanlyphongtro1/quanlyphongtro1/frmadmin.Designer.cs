
namespace quanlyphongtro1
{
    partial class frmadmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcadmin = new System.Windows.Forms.TabControl();
            this.tpquanlytaikhoan = new System.Windows.Forms.TabPage();
            this.btnxoataikhoan = new System.Windows.Forms.Button();
            this.btnsuathongtintaikhoan = new System.Windows.Forms.Button();
            this.btntaotaikhoan = new System.Windows.Forms.Button();
            this.btnresert_taikhoan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txttimkiemtaikhoan = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.dgvquanlytaikhoan = new System.Windows.Forms.DataGridView();
            this.tendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyenhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpquanlydichvu = new System.Windows.Forms.TabPage();
            this.btnxoadichvu = new System.Windows.Forms.Button();
            this.btnsuathongtindichvu = new System.Windows.Forms.Button();
            this.btnthemdichvu = new System.Windows.Forms.Button();
            this.btnresert_dichvu = new System.Windows.Forms.Button();
            this.dgvquanlydichvu = new System.Windows.Forms.DataGridView();
            this.tenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btntimkiemdichvu = new System.Windows.Forms.Button();
            this.txttimkiemdichvu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tpquanluphong = new System.Windows.Forms.TabPage();
            this.btnxoa_phong = new System.Windows.Forms.Button();
            this.btnthem_phong = new System.Windows.Forms.Button();
            this.btnresert_phong = new System.Windows.Forms.Button();
            this.dgvphong = new System.Windows.Forms.DataGridView();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btntimkiem_phong = new System.Windows.Forms.Button();
            this.txttimkiem_phong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tplaphoadon = new System.Windows.Forms.TabPage();
            this.btnhoadon = new System.Windows.Forms.Button();
            this.txthoadon = new System.Windows.Forms.TextBox();
            this.dgvlaphoadon_phong = new System.Windows.Forms.DataGridView();
            this.hoadon_maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoadon_trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tcadmin.SuspendLayout();
            this.tpquanlytaikhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlytaikhoan)).BeginInit();
            this.tpquanlydichvu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlydichvu)).BeginInit();
            this.tpquanluphong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphong)).BeginInit();
            this.tplaphoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlaphoadon_phong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý phòng trọ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 65);
            this.panel1.TabIndex = 1;
            // 
            // tcadmin
            // 
            this.tcadmin.Controls.Add(this.tpquanlytaikhoan);
            this.tcadmin.Controls.Add(this.tpquanlydichvu);
            this.tcadmin.Controls.Add(this.tpquanluphong);
            this.tcadmin.Controls.Add(this.tplaphoadon);
            this.tcadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcadmin.Location = new System.Drawing.Point(4, 71);
            this.tcadmin.Name = "tcadmin";
            this.tcadmin.SelectedIndex = 0;
            this.tcadmin.Size = new System.Drawing.Size(804, 348);
            this.tcadmin.TabIndex = 2;
            // 
            // tpquanlytaikhoan
            // 
            this.tpquanlytaikhoan.Controls.Add(this.btnxoataikhoan);
            this.tpquanlytaikhoan.Controls.Add(this.btnsuathongtintaikhoan);
            this.tpquanlytaikhoan.Controls.Add(this.btntaotaikhoan);
            this.tpquanlytaikhoan.Controls.Add(this.btnresert_taikhoan);
            this.tpquanlytaikhoan.Controls.Add(this.label2);
            this.tpquanlytaikhoan.Controls.Add(this.txttimkiemtaikhoan);
            this.tpquanlytaikhoan.Controls.Add(this.btntimkiem);
            this.tpquanlytaikhoan.Controls.Add(this.dgvquanlytaikhoan);
            this.tpquanlytaikhoan.Location = new System.Drawing.Point(4, 27);
            this.tpquanlytaikhoan.Name = "tpquanlytaikhoan";
            this.tpquanlytaikhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tpquanlytaikhoan.Size = new System.Drawing.Size(796, 317);
            this.tpquanlytaikhoan.TabIndex = 0;
            this.tpquanlytaikhoan.Text = "Quản lý tài khoản";
            this.tpquanlytaikhoan.UseVisualStyleBackColor = true;
            // 
            // btnxoataikhoan
            // 
            this.btnxoataikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoataikhoan.Location = new System.Drawing.Point(569, 285);
            this.btnxoataikhoan.Name = "btnxoataikhoan";
            this.btnxoataikhoan.Size = new System.Drawing.Size(108, 23);
            this.btnxoataikhoan.TabIndex = 7;
            this.btnxoataikhoan.Text = "Xóa tài khoản";
            this.btnxoataikhoan.UseVisualStyleBackColor = true;
            this.btnxoataikhoan.Click += new System.EventHandler(this.btnxoataikhoan_Click);
            // 
            // btnsuathongtintaikhoan
            // 
            this.btnsuathongtintaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuathongtintaikhoan.Location = new System.Drawing.Point(380, 285);
            this.btnsuathongtintaikhoan.Name = "btnsuathongtintaikhoan";
            this.btnsuathongtintaikhoan.Size = new System.Drawing.Size(103, 23);
            this.btnsuathongtintaikhoan.TabIndex = 6;
            this.btnsuathongtintaikhoan.Text = "Sửa thông tin";
            this.btnsuathongtintaikhoan.UseVisualStyleBackColor = true;
            this.btnsuathongtintaikhoan.Click += new System.EventHandler(this.btnsuathongtintaikhoan_Click);
            // 
            // btntaotaikhoan
            // 
            this.btntaotaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaotaikhoan.Location = new System.Drawing.Point(198, 285);
            this.btntaotaikhoan.Name = "btntaotaikhoan";
            this.btntaotaikhoan.Size = new System.Drawing.Size(111, 23);
            this.btntaotaikhoan.TabIndex = 5;
            this.btntaotaikhoan.Text = "Tạo tài khoản";
            this.btntaotaikhoan.UseVisualStyleBackColor = true;
            this.btntaotaikhoan.Click += new System.EventHandler(this.btntaotaikhoan_Click);
            // 
            // btnresert_taikhoan
            // 
            this.btnresert_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresert_taikhoan.Location = new System.Drawing.Point(56, 285);
            this.btnresert_taikhoan.Name = "btnresert_taikhoan";
            this.btnresert_taikhoan.Size = new System.Drawing.Size(75, 23);
            this.btnresert_taikhoan.TabIndex = 4;
            this.btnresert_taikhoan.Text = "Resert";
            this.btnresert_taikhoan.UseVisualStyleBackColor = true;
            this.btnresert_taikhoan.Click += new System.EventHandler(this.btnresert_taikhoan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đăng nhập";
            // 
            // txttimkiemtaikhoan
            // 
            this.txttimkiemtaikhoan.Location = new System.Drawing.Point(513, 18);
            this.txttimkiemtaikhoan.Name = "txttimkiemtaikhoan";
            this.txttimkiemtaikhoan.Size = new System.Drawing.Size(164, 24);
            this.txttimkiemtaikhoan.TabIndex = 2;
            this.txttimkiemtaikhoan.TextChanged += new System.EventHandler(this.txttimkiemtaikhoan_TextChanged);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(713, 16);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 1;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // dgvquanlytaikhoan
            // 
            this.dgvquanlytaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvquanlytaikhoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvquanlytaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvquanlytaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tendangnhap,
            this.matkhau,
            this.quyenhan});
            this.dgvquanlytaikhoan.Location = new System.Drawing.Point(11, 62);
            this.dgvquanlytaikhoan.Name = "dgvquanlytaikhoan";
            this.dgvquanlytaikhoan.Size = new System.Drawing.Size(782, 202);
            this.dgvquanlytaikhoan.TabIndex = 0;
            // 
            // tendangnhap
            // 
            this.tendangnhap.DataPropertyName = "tendangnhap";
            this.tendangnhap.HeaderText = "Tên đăng nhập";
            this.tendangnhap.Name = "tendangnhap";
            // 
            // matkhau
            // 
            this.matkhau.DataPropertyName = "matkhau";
            this.matkhau.HeaderText = "Mật khẩu";
            this.matkhau.Name = "matkhau";
            // 
            // quyenhan
            // 
            this.quyenhan.DataPropertyName = "quyenhan";
            this.quyenhan.HeaderText = "Quyền hạn";
            this.quyenhan.Name = "quyenhan";
            // 
            // tpquanlydichvu
            // 
            this.tpquanlydichvu.Controls.Add(this.btnxoadichvu);
            this.tpquanlydichvu.Controls.Add(this.btnsuathongtindichvu);
            this.tpquanlydichvu.Controls.Add(this.btnthemdichvu);
            this.tpquanlydichvu.Controls.Add(this.btnresert_dichvu);
            this.tpquanlydichvu.Controls.Add(this.dgvquanlydichvu);
            this.tpquanlydichvu.Controls.Add(this.btntimkiemdichvu);
            this.tpquanlydichvu.Controls.Add(this.txttimkiemdichvu);
            this.tpquanlydichvu.Controls.Add(this.label3);
            this.tpquanlydichvu.Location = new System.Drawing.Point(4, 27);
            this.tpquanlydichvu.Name = "tpquanlydichvu";
            this.tpquanlydichvu.Padding = new System.Windows.Forms.Padding(3);
            this.tpquanlydichvu.Size = new System.Drawing.Size(796, 317);
            this.tpquanlydichvu.TabIndex = 1;
            this.tpquanlydichvu.Text = "Quản lý dịch vụ";
            this.tpquanlydichvu.UseVisualStyleBackColor = true;
            // 
            // btnxoadichvu
            // 
            this.btnxoadichvu.Location = new System.Drawing.Point(616, 284);
            this.btnxoadichvu.Name = "btnxoadichvu";
            this.btnxoadichvu.Size = new System.Drawing.Size(99, 23);
            this.btnxoadichvu.TabIndex = 7;
            this.btnxoadichvu.Text = "Xóa dịch vụ";
            this.btnxoadichvu.UseVisualStyleBackColor = true;
            this.btnxoadichvu.Click += new System.EventHandler(this.btnxoadichvu_Click);
            // 
            // btnsuathongtindichvu
            // 
            this.btnsuathongtindichvu.Location = new System.Drawing.Point(419, 284);
            this.btnsuathongtindichvu.Name = "btnsuathongtindichvu";
            this.btnsuathongtindichvu.Size = new System.Drawing.Size(107, 23);
            this.btnsuathongtindichvu.TabIndex = 6;
            this.btnsuathongtindichvu.Text = "Sửa thông tin";
            this.btnsuathongtindichvu.UseVisualStyleBackColor = true;
            this.btnsuathongtindichvu.Click += new System.EventHandler(this.btnsuathongtindichvu_Click);
            // 
            // btnthemdichvu
            // 
            this.btnthemdichvu.Location = new System.Drawing.Point(185, 284);
            this.btnthemdichvu.Name = "btnthemdichvu";
            this.btnthemdichvu.Size = new System.Drawing.Size(120, 23);
            this.btnthemdichvu.TabIndex = 5;
            this.btnthemdichvu.Text = "Thêm dịch vụ";
            this.btnthemdichvu.UseVisualStyleBackColor = true;
            this.btnthemdichvu.Click += new System.EventHandler(this.btnthemdichvu_Click);
            // 
            // btnresert_dichvu
            // 
            this.btnresert_dichvu.Location = new System.Drawing.Point(21, 284);
            this.btnresert_dichvu.Name = "btnresert_dichvu";
            this.btnresert_dichvu.Size = new System.Drawing.Size(75, 23);
            this.btnresert_dichvu.TabIndex = 4;
            this.btnresert_dichvu.Text = "Resert";
            this.btnresert_dichvu.UseVisualStyleBackColor = true;
            this.btnresert_dichvu.Click += new System.EventHandler(this.btnresert_dichvu_Click);
            // 
            // dgvquanlydichvu
            // 
            this.dgvquanlydichvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvquanlydichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvquanlydichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDichVu,
            this.donViTinh,
            this.donGia});
            this.dgvquanlydichvu.Location = new System.Drawing.Point(6, 61);
            this.dgvquanlydichvu.Name = "dgvquanlydichvu";
            this.dgvquanlydichvu.Size = new System.Drawing.Size(781, 204);
            this.dgvquanlydichvu.TabIndex = 3;
            // 
            // tenDichVu
            // 
            this.tenDichVu.DataPropertyName = "tenDichVu";
            this.tenDichVu.HeaderText = "Tên dịch vụ";
            this.tenDichVu.Name = "tenDichVu";
            // 
            // donViTinh
            // 
            this.donViTinh.DataPropertyName = "donViTinh";
            this.donViTinh.HeaderText = "Đơn vị tính";
            this.donViTinh.Name = "donViTinh";
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.Name = "donGia";
            // 
            // btntimkiemdichvu
            // 
            this.btntimkiemdichvu.Location = new System.Drawing.Point(689, 20);
            this.btntimkiemdichvu.Name = "btntimkiemdichvu";
            this.btntimkiemdichvu.Size = new System.Drawing.Size(90, 23);
            this.btntimkiemdichvu.TabIndex = 2;
            this.btntimkiemdichvu.Text = "Tìm kiếm";
            this.btntimkiemdichvu.UseVisualStyleBackColor = true;
            this.btntimkiemdichvu.Click += new System.EventHandler(this.btntimkiemdichvu_Click);
            // 
            // txttimkiemdichvu
            // 
            this.txttimkiemdichvu.Location = new System.Drawing.Point(484, 20);
            this.txttimkiemdichvu.Name = "txttimkiemdichvu";
            this.txttimkiemdichvu.Size = new System.Drawing.Size(182, 24);
            this.txttimkiemdichvu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên dịch vụ";
            // 
            // tpquanluphong
            // 
            this.tpquanluphong.Controls.Add(this.btnxoa_phong);
            this.tpquanluphong.Controls.Add(this.btnthem_phong);
            this.tpquanluphong.Controls.Add(this.btnresert_phong);
            this.tpquanluphong.Controls.Add(this.dgvphong);
            this.tpquanluphong.Controls.Add(this.btntimkiem_phong);
            this.tpquanluphong.Controls.Add(this.txttimkiem_phong);
            this.tpquanluphong.Controls.Add(this.label4);
            this.tpquanluphong.Location = new System.Drawing.Point(4, 27);
            this.tpquanluphong.Name = "tpquanluphong";
            this.tpquanluphong.Padding = new System.Windows.Forms.Padding(3);
            this.tpquanluphong.Size = new System.Drawing.Size(796, 317);
            this.tpquanluphong.TabIndex = 2;
            this.tpquanluphong.Text = "Quản lý phòng";
            this.tpquanluphong.UseVisualStyleBackColor = true;
            // 
            // btnxoa_phong
            // 
            this.btnxoa_phong.Location = new System.Drawing.Point(305, 277);
            this.btnxoa_phong.Name = "btnxoa_phong";
            this.btnxoa_phong.Size = new System.Drawing.Size(75, 23);
            this.btnxoa_phong.TabIndex = 7;
            this.btnxoa_phong.Text = "Xóa phòng";
            this.btnxoa_phong.UseVisualStyleBackColor = true;
            this.btnxoa_phong.Click += new System.EventHandler(this.btnxoa_phong_Click);
            // 
            // btnthem_phong
            // 
            this.btnthem_phong.Location = new System.Drawing.Point(156, 276);
            this.btnthem_phong.Name = "btnthem_phong";
            this.btnthem_phong.Size = new System.Drawing.Size(75, 23);
            this.btnthem_phong.TabIndex = 5;
            this.btnthem_phong.Text = "Thêm phòng";
            this.btnthem_phong.UseVisualStyleBackColor = true;
            this.btnthem_phong.Click += new System.EventHandler(this.btnthem_phong_Click);
            // 
            // btnresert_phong
            // 
            this.btnresert_phong.Location = new System.Drawing.Point(21, 277);
            this.btnresert_phong.Name = "btnresert_phong";
            this.btnresert_phong.Size = new System.Drawing.Size(75, 23);
            this.btnresert_phong.TabIndex = 4;
            this.btnresert_phong.Text = "Resert";
            this.btnresert_phong.UseVisualStyleBackColor = true;
            this.btnresert_phong.Click += new System.EventHandler(this.btnresert_phong_Click);
            // 
            // dgvphong
            // 
            this.dgvphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong,
            this.trangthai});
            this.dgvphong.Location = new System.Drawing.Point(6, 57);
            this.dgvphong.Name = "dgvphong";
            this.dgvphong.Size = new System.Drawing.Size(781, 203);
            this.dgvphong.TabIndex = 3;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.Name = "maphong";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // btntimkiem_phong
            // 
            this.btntimkiem_phong.Location = new System.Drawing.Point(695, 17);
            this.btntimkiem_phong.Name = "btntimkiem_phong";
            this.btntimkiem_phong.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem_phong.TabIndex = 2;
            this.btntimkiem_phong.Text = "Tìm kiếm";
            this.btntimkiem_phong.UseVisualStyleBackColor = true;
            this.btntimkiem_phong.Click += new System.EventHandler(this.btntimkiem_phong_Click);
            // 
            // txttimkiem_phong
            // 
            this.txttimkiem_phong.Location = new System.Drawing.Point(489, 17);
            this.txttimkiem_phong.Name = "txttimkiem_phong";
            this.txttimkiem_phong.Size = new System.Drawing.Size(183, 24);
            this.txttimkiem_phong.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã phòng";
            // 
            // tplaphoadon
            // 
            this.tplaphoadon.Controls.Add(this.btnhoadon);
            this.tplaphoadon.Controls.Add(this.txthoadon);
            this.tplaphoadon.Controls.Add(this.dgvlaphoadon_phong);
            this.tplaphoadon.Location = new System.Drawing.Point(4, 27);
            this.tplaphoadon.Name = "tplaphoadon";
            this.tplaphoadon.Padding = new System.Windows.Forms.Padding(3);
            this.tplaphoadon.Size = new System.Drawing.Size(796, 317);
            this.tplaphoadon.TabIndex = 3;
            this.tplaphoadon.Text = "Lập hóa đơn";
            this.tplaphoadon.UseVisualStyleBackColor = true;
            // 
            // btnhoadon
            // 
            this.btnhoadon.Location = new System.Drawing.Point(133, 278);
            this.btnhoadon.Name = "btnhoadon";
            this.btnhoadon.Size = new System.Drawing.Size(108, 32);
            this.btnhoadon.TabIndex = 2;
            this.btnhoadon.Text = "Lập hóa đơn";
            this.btnhoadon.UseVisualStyleBackColor = true;
            this.btnhoadon.Click += new System.EventHandler(this.btnhoadon_Click);
            // 
            // txthoadon
            // 
            this.txthoadon.Enabled = false;
            this.txthoadon.Location = new System.Drawing.Point(430, 7);
            this.txthoadon.Multiline = true;
            this.txthoadon.Name = "txthoadon";
            this.txthoadon.Size = new System.Drawing.Size(358, 249);
            this.txthoadon.TabIndex = 1;
            // 
            // dgvlaphoadon_phong
            // 
            this.dgvlaphoadon_phong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlaphoadon_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlaphoadon_phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoadon_maphong,
            this.hoadon_trangthai});
            this.dgvlaphoadon_phong.Location = new System.Drawing.Point(6, 6);
            this.dgvlaphoadon_phong.Name = "dgvlaphoadon_phong";
            this.dgvlaphoadon_phong.Size = new System.Drawing.Size(418, 250);
            this.dgvlaphoadon_phong.TabIndex = 0;
            // 
            // hoadon_maphong
            // 
            this.hoadon_maphong.DataPropertyName = "maPhong";
            this.hoadon_maphong.HeaderText = "Mã phòng";
            this.hoadon_maphong.Name = "hoadon_maphong";
            // 
            // hoadon_trangthai
            // 
            this.hoadon_trangthai.DataPropertyName = "trangThai";
            this.hoadon_trangthai.HeaderText = "Trạng thái";
            this.hoadon_trangthai.Name = "hoadon_trangthai";
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 420);
            this.Controls.Add(this.tcadmin);
            this.Controls.Add(this.panel1);
            this.Name = "frmadmin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmadmin_FormClosing);
            this.Load += new System.EventHandler(this.frmadmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tcadmin.ResumeLayout(false);
            this.tpquanlytaikhoan.ResumeLayout(false);
            this.tpquanlytaikhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlytaikhoan)).EndInit();
            this.tpquanlydichvu.ResumeLayout(false);
            this.tpquanlydichvu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlydichvu)).EndInit();
            this.tpquanluphong.ResumeLayout(false);
            this.tpquanluphong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphong)).EndInit();
            this.tplaphoadon.ResumeLayout(false);
            this.tplaphoadon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlaphoadon_phong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcadmin;
        private System.Windows.Forms.TabPage tpquanlytaikhoan;
        private System.Windows.Forms.TabPage tpquanlydichvu;
        private System.Windows.Forms.TabPage tpquanluphong;
        private System.Windows.Forms.TabPage tplaphoadon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttimkiemtaikhoan;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridView dgvquanlytaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyenhan;
        private System.Windows.Forms.Button btnxoataikhoan;
        private System.Windows.Forms.Button btnsuathongtintaikhoan;
        private System.Windows.Forms.Button btntaotaikhoan;
        private System.Windows.Forms.Button btnresert_taikhoan;
        private System.Windows.Forms.Button btntimkiemdichvu;
        private System.Windows.Forms.TextBox txttimkiemdichvu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnxoadichvu;
        private System.Windows.Forms.Button btnsuathongtindichvu;
        private System.Windows.Forms.Button btnthemdichvu;
        private System.Windows.Forms.Button btnresert_dichvu;
        private System.Windows.Forms.DataGridView dgvquanlydichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.Button btnxoa_phong;
        private System.Windows.Forms.Button btnthem_phong;
        private System.Windows.Forms.Button btnresert_phong;
        private System.Windows.Forms.DataGridView dgvphong;
        private System.Windows.Forms.Button btntimkiem_phong;
        private System.Windows.Forms.TextBox txttimkiem_phong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.Button btnhoadon;
        private System.Windows.Forms.TextBox txthoadon;
        private System.Windows.Forms.DataGridView dgvlaphoadon_phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoadon_maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoadon_trangthai;
    }
}