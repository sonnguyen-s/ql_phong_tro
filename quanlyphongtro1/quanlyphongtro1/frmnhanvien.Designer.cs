
namespace quanlyphongtro1
{
    partial class frmnhanvien
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
            this.dgvphong = new System.Windows.Forms.DataGridView();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbten = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnresert = new System.Windows.Forms.Button();
            this.btnsudungdichvu = new System.Windows.Forms.Button();
            this.btnthuephong = new System.Windows.Forms.Button();
            this.btntraphong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphong)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(800, 65);
            this.panel1.TabIndex = 2;
            // 
            // dgvphong
            // 
            this.dgvphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong,
            this.trangThai});
            this.dgvphong.Location = new System.Drawing.Point(12, 122);
            this.dgvphong.Name = "dgvphong";
            this.dgvphong.Size = new System.Drawing.Size(776, 265);
            this.dgvphong.TabIndex = 3;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.Name = "maphong";
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.Name = "trangThai";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbten.Location = new System.Drawing.Point(12, 82);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(81, 18);
            this.lbten.TabIndex = 4;
            this.lbten.Text = "Nhân viên: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(513, 79);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(155, 24);
            this.txttimkiem.TabIndex = 6;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(692, 79);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(83, 24);
            this.btntimkiem.TabIndex = 7;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnresert
            // 
            this.btnresert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresert.Location = new System.Drawing.Point(228, 411);
            this.btnresert.Name = "btnresert";
            this.btnresert.Size = new System.Drawing.Size(75, 27);
            this.btnresert.TabIndex = 8;
            this.btnresert.Text = "Resert";
            this.btnresert.UseVisualStyleBackColor = true;
            this.btnresert.Click += new System.EventHandler(this.btnresert_Click);
            // 
            // btnsudungdichvu
            // 
            this.btnsudungdichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsudungdichvu.Location = new System.Drawing.Point(352, 411);
            this.btnsudungdichvu.Name = "btnsudungdichvu";
            this.btnsudungdichvu.Size = new System.Drawing.Size(125, 27);
            this.btnsudungdichvu.TabIndex = 9;
            this.btnsudungdichvu.Text = "Sử dụng dịch vụ";
            this.btnsudungdichvu.UseVisualStyleBackColor = true;
            this.btnsudungdichvu.Click += new System.EventHandler(this.btnsudungdichvu_Click);
            // 
            // btnthuephong
            // 
            this.btnthuephong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthuephong.Location = new System.Drawing.Point(531, 411);
            this.btnthuephong.Name = "btnthuephong";
            this.btnthuephong.Size = new System.Drawing.Size(102, 27);
            this.btnthuephong.TabIndex = 10;
            this.btnthuephong.Text = "Thuê phòng";
            this.btnthuephong.UseVisualStyleBackColor = true;
            this.btnthuephong.Click += new System.EventHandler(this.btnthuephong_Click);
            // 
            // btntraphong
            // 
            this.btntraphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntraphong.Location = new System.Drawing.Point(677, 411);
            this.btntraphong.Name = "btntraphong";
            this.btntraphong.Size = new System.Drawing.Size(87, 27);
            this.btntraphong.TabIndex = 11;
            this.btntraphong.Text = "Trả phòng";
            this.btntraphong.UseVisualStyleBackColor = true;
            this.btntraphong.Click += new System.EventHandler(this.btntraphong_Click);
            // 
            // frmnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntraphong);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.btnthuephong);
            this.Controls.Add(this.btnsudungdichvu);
            this.Controls.Add(this.btnresert);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvphong);
            this.Controls.Add(this.panel1);
            this.Name = "frmnhanvien";
            this.Text = "Nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmnhanvien_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnresert;
        private System.Windows.Forms.Button btnsudungdichvu;
        private System.Windows.Forms.Button btnthuephong;
        private System.Windows.Forms.Button btntraphong;
    }
}