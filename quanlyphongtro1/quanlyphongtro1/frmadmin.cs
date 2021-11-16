using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlyphongtro1
{
    public partial class frmadmin : Form
    {
        String strconn = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlyphongtro;Integrated Security = True";
        SqlConnection conn = null;
        private String _str;
        public frmadmin()
        {
            InitializeComponent();
        }

        public frmadmin(String str)
            :this()
        {
            _str = str;
            this.Text += "(" + _str + ")";
        }

        private void frmadmin_Load(object sender, EventArgs e)
        {
            load_nhanvien();
            load_dichvu();
            load_phong();
            load_hoadonphong();
        }

        void load_nhanvien()
        {
            conn = new SqlConnection(strconn);
            String query = "select * from taikhoan order by quyenhan asc";
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dgvquanlytaikhoan.DataSource = dt;
        }
        void load_dichvu()
        {
            conn = new SqlConnection(strconn);
            String query = "Select * from danhSachDichVu order by tenDichVu asc";
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dgvquanlydichvu.DataSource = dt;
        }
        void load_phong()
        {
            conn = new SqlConnection(strconn);
            String query = "select * from phong order by maPhong asc";
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dgvphong.DataSource = dt;
        }
        void load_hoadonphong()
        {
            conn = new SqlConnection(strconn);
            String query = "select * from phong order by maPhong asc";
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dgvlaphoadon_phong.DataSource = dt;
        }

        private void btnresert_taikhoan_Click(object sender, EventArgs e)
        {
            load_nhanvien();
            this.txttimkiemtaikhoan.Clear();
        }

        private void btntaotaikhoan_Click(object sender, EventArgs e)
        {
            Form frmdk = new frmdangky();
            this.Hide();
            frmdk.ShowDialog();
            this.Show();
        }

        private void btnsuathongtintaikhoan_Click(object sender, EventArgs e)
        {
            //lay so thu tu duong hien hanh
            int r = dgvquanlytaikhoan.CurrentCell.RowIndex;
            //lay ten dang nhap hien hanh
            String tendangnhap = dgvquanlytaikhoan.Rows[r].Cells[0].Value.ToString();
            Form frmsuatk = new frmsuathongtin_taikhoan(tendangnhap);
            this.Hide();
            frmsuatk.ShowDialog();
            this.Show();
        }

        private void btnxoataikhoan_Click(object sender, EventArgs e)
        {
            //lay chi so dong hien hanh
            int r = dgvquanlytaikhoan.CurrentCell.RowIndex;
            //lay ten dang nhap cua dong hien hanh
            String tendangnhap = dgvquanlytaikhoan.Rows[r].Cells[0].Value.ToString();
            String quyenhan = "";
            conn = new SqlConnection(strconn);
            //cau lenh truy van quyen han
            String query = String.Format("select quyenHan from taikhoan where tenDangNhap='{0}'",tendangnhap);
            //cau lenh xoa tai khoan
            String query1 = String.Format("delete from taikhoan where tenDangNhap = '{0}'",tendangnhap);
            //mo ket noi
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            quyenhan = com.ExecuteScalar().ToString();
            //MessageBox.Show(quyenhan);
            conn.Close();
            if (quyenhan == "Admin")
            {
                MessageBox.Show("Không thể xóa tài khoản Admin", "Thông báo");
            } else if (quyenhan=="Nhân viên")
            {
                conn.Open();
                SqlCommand com1 = new SqlCommand(query1, conn);
                com1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa tài khoản thành công");
                load_nhanvien();
            } else
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            //lay chuoi tim kiem
            String str_timkiem = txttimkiemtaikhoan.Text;
            //tao ket noi
            conn = new SqlConnection(strconn);
            //cau lenh truy van
            String query = String.Format("select * from taikhoan where tenDangNhap like N'%{0}%'",str_timkiem);
            //mo ket noi
            conn.Open();
            //tao doi tuong dbcommand
            SqlCommand com = new SqlCommand(query, conn);
            //tao adapter
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            //tao datatable
            DataTable dt1 = new DataTable();
            //chuyen du lieu tu adapter sang datatable 
            adapter.Fill(dt1);
            //dong ket noi
            conn.Close();
            //xuat du lieu ra datagitview
            dgvquanlytaikhoan.DataSource = dt1;

        }

        private void btnresert_dichvu_Click(object sender, EventArgs e)
        {
            load_dichvu();
        }

        private void btnthemdichvu_Click(object sender, EventArgs e)
        {
            Form frmthemdv = new frmthemdichvu();
            this.Hide();
            frmthemdv.ShowDialog();
            this.Show();
        }

        private void btnsuathongtindichvu_Click(object sender, EventArgs e)
        {
            //lay vi tri dong hien tai
            int r = dgvquanlydichvu.CurrentCell.RowIndex;
            //lay ten dich vu cua dong hien tai
            String tendichvu = dgvquanlydichvu.Rows[r].Cells[0].Value.ToString();
            Form frmsuadv = new frmsuathongtin_dichvu(tendichvu);
            this.Hide();
            frmsuadv.ShowDialog();
            this.Show();
        }

        private void btnxoadichvu_Click(object sender, EventArgs e)
        {
            int r = dgvquanlydichvu.CurrentCell.RowIndex;
            String tendichvu = dgvquanlydichvu.Rows[r].Cells[0].Value.ToString();
            conn = new SqlConnection(strconn);
            String query = String.Format("Delete from danhSachDichVu where tendichvu ='{0}'",tendichvu);
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Xóa dịch vụ thành công");
            load_dichvu();
        }

        private void btntimkiemdichvu_Click(object sender, EventArgs e)
        {
            String timkiem_dv = txttimkiemdichvu.Text;
            conn = new SqlConnection(strconn);
            String query = String.Format("select * from danhSachDichVu where tenDichVu like N'%{0}%' ", timkiem_dv);
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dgvquanlydichvu.DataSource = dt;
        }

        private void btnresert_phong_Click(object sender, EventArgs e)
        {
            load_phong();
        }

        private void btnthem_phong_Click(object sender, EventArgs e)
        {
            Form frmthemphong = new frmthemphong();
            this.Hide();
            frmthemphong.ShowDialog();
            this.Show();
        }

        private void frmadmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnxoa_phong_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvphong.CurrentCell.RowIndex;
                String maphong = dgvphong.Rows[r].Cells[0].Value.ToString();
                conn = new SqlConnection(strconn);
                String query = String.Format("delete from phong where maPhong = '{0}'", maphong);
                DialogResult traloi = MessageBox.Show("Bạn có chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (traloi == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand com = new SqlCommand(query, conn);
                    com.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Xóa thành công!");
                    load_phong();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn phòng");
            }
            
            
        }

        private void btntimkiem_phong_Click(object sender, EventArgs e)
        {
            String timphong = txttimkiem_phong.Text;
            conn = new SqlConnection(strconn);
            String query = String.Format("select * from phong where maPhong like N'%{0}%'",timphong);
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dgvphong.DataSource = dt;
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            int r = dgvlaphoadon_phong.CurrentCell.RowIndex;
            String maphong = dgvlaphoadon_phong.Rows[r].Cells[0].Value.ToString();
            String trangthai = dgvlaphoadon_phong.Rows[r].Cells[1].Value.ToString();
            if (trangthai == "Đã được thuê")
            {
                txthoadon.Text = "Hóa đơn phòng " + maphong + "\r\n";
                txthoadon.Text += "---------------------------------\r\n";
                txthoadon.Text += "Tiền thuê phòng: 1.200.000 đ\r\n";
                txthoadon.Text += "Dịch vụ: \r\n";
                int row = dgvlaphoadon_phong.CurrentCell.RowIndex;
                String maphong1 = dgvlaphoadon_phong.Rows[r].Cells[0].Value.ToString();
                conn = new SqlConnection(strconn);
                String query = String.Format("select * from hoaDonDichVu where maPhong = '{0}'",maphong);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                long tongtien = 1200000;
                
                foreach (DataRow row1  in dt.Rows) 
                {
                    String query1 = String.Format("select donGia from danhSachDichVu where tenDichVu = N'{0}'",row1["tenDichVu"]);
                    SqlCommand com1 = new SqlCommand(query1,conn);
                    long dongia = Convert.ToInt64(com1.ExecuteScalar().ToString());
                    long tiendichvu = Convert.ToInt64(row1["soLuong"].ToString()) * dongia;
                    tongtien += tiendichvu;
                    String tendv = row1["tenDichVu"].ToString();
                    txthoadon.Text += tendv + " " + row1["soLuong"] + " x " + String.Format("{0:n0}", dongia) + " = " + String.Format("{0:n0}", tiendichvu) + "đ" + "\r\n";
                }
                txthoadon.Text += "------------------------------\r\n";
                txthoadon.Text += "Tổng cộng: " + String.Format("{0:n0}", tongtien) + "đ";
                conn.Close();
            } else
            {
                MessageBox.Show("Phòng này chưa được thuê!");
            }
        }

        private void txttimkiemtaikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
