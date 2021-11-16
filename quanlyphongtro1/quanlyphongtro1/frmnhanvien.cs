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
    public partial class frmnhanvien : Form
    {
        String strconn = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlyphongtro;Integrated Security = True";
        SqlConnection conn = null;
        private String tendangnhap;
        public frmnhanvien()
        {
            InitializeComponent();
            load_phong();
        }
        public frmnhanvien(String str)
            :this()
        {
            tendangnhap = str;
            lbten.Text += str;
        }
        void load_phong()
        {
            conn = new SqlConnection(strconn);
            String query = "select * from phong";
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dgvphong.DataSource = dt;
        }

        private void btnresert_Click(object sender, EventArgs e)
        {
            load_phong();
        }

        private void btnthuephong_Click(object sender, EventArgs e)
        {
            int r = dgvphong.CurrentCell.RowIndex;
            String maphong = dgvphong.Rows[r].Cells[0].Value.ToString();
            String trangthai = dgvphong.Rows[r].Cells[1].Value.ToString();
            if (trangthai == "Trống")
            {
                conn = new SqlConnection(strconn);
                
                String query1 = String.Format("update phong set trangThai = N'Đã được thuê' where maPhong = N'{0}'", maphong);
                conn.Open();
                SqlCommand com = new SqlCommand(query1, conn);
                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thuê phòng thành công");
                load_phong();
            }
            else
            {
                MessageBox.Show("Phòng này đã được thuê!");
            }
        }

        private void btntraphong_Click(object sender, EventArgs e)
        {
            int r = dgvphong.CurrentCell.RowIndex;
            String maphong1 = dgvphong.Rows[r].Cells[0].Value.ToString();
            String trangthai1 = dgvphong.Rows[r].Cells[1].Value.ToString();
            if (trangthai1 =="Đã được thuê")
            {
                conn = new SqlConnection(strconn);
                String query = String.Format("update phong set trangThai = N'Trống' where maPhong=N'{0}'",maphong1);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Trả phòng thành công");
                load_phong();
            }
            else
            {
                MessageBox.Show("Phòng trống! Không thể trả phòng!");
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            String maphong = txttimkiem.Text;
            String query2 = String.Format("Select * from phong where maPhong like N'%{0}%'",maphong);
            conn.Open();
            SqlCommand com = new SqlCommand(query2, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dgvphong.DataSource = dt;
        }

        private void frmnhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnsudungdichvu_Click(object sender, EventArgs e)
        {
            int r = dgvphong.CurrentCell.RowIndex;
            String mp = dgvphong.Rows[r].Cells[0].Value.ToString();
            String trangthai = dgvphong.Rows[r].Cells[1].Value.ToString();
            if (trangthai == "Đã được thuê")
            {
                Form sudungdv = new frmsudungdichvu(mp);
                this.Hide();
                sudungdv.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Phòng trống! Không thể thêm","Thông báo");
            }
        }
    }
}
