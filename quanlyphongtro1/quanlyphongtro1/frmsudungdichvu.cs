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
    public partial class frmsudungdichvu : Form
    {
        String strconn = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlyphongtro;Integrated Security = True";
        SqlConnection conn = null;
        private String maphong;
        public frmsudungdichvu()
        {
            InitializeComponent();
            load_dichvu();
        }
        public frmsudungdichvu(String str)
            :this()
        {
            maphong = str;
            lbmaphong.Text += str;
        }
       
        void load_dichvu()
        {
            conn = new SqlConnection(strconn);
            String query = "select * from danhSachDichVu";
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dgvdichvu.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = dgvdichvu.CurrentCell.RowIndex;
            String tendv = dgvdichvu.Rows[r].Cells[0].Value.ToString();
            String soluong = txtsoluong.Text;
            conn = new SqlConnection(strconn);
            String query = String.Format("insert into hoaDonDichVu (maPhong,tenDichVu,soLuong) values ('{0}',N'{1}','{2}')",maphong,tendv,soluong);
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Thêm dịch vụ thành công");
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strconn);
            int r = dgvdichvu.CurrentCell.RowIndex;
            String tendv = txttimkiem.Text;
            String query = String.Format("select * from danhSachDichVu where tenDichVu like N'%{0}%'",tendv);
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dgvdichvu.DataSource = dt;
        }

        private void btnresert_Click(object sender, EventArgs e)
        {
            load_dichvu();
        }
    }
}
