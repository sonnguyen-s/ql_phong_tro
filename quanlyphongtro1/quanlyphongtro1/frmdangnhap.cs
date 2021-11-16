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
    public partial class frmdangnhap : Form
    {
        String strconn = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlyphongtro;Integrated Security = True";
        SqlConnection conn = null;
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            String tendangnhap = txttendangnhap.Text;
            String matkhau = txtmatkhau.Text;
            String quyenhan = "";
            try
            {
                conn = new SqlConnection(strconn);
                String query = String.Format("dangNhap {0},{1}", tendangnhap, matkhau);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                if (com.ExecuteScalar() == null)
                {
                    quyenhan = "";
                } else
                {
                    quyenhan = com.ExecuteScalar().ToString();
                }
                
                conn.Close();
                
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!");
            }
            if (quyenhan == "Admin")
            {
                conn = new SqlConnection(strconn);
                string query1 = String.Format("select tenDangNhap from taikhoan where tenDangNhap = '{0}' and matKhau = '{1}'", tendangnhap, matkhau);
                conn.Open();
                SqlCommand com1 = new SqlCommand(query1, conn);
                String data1 = com1.ExecuteScalar().ToString();
                conn.Close();
                frmadmin f = new frmadmin(data1);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if (quyenhan == "Nhân viên")
            {
                conn = new SqlConnection(strconn);
                String query2 = String.Format("select tenDangNhap from taikhoan where tenDangNhap = '{0}' and matKhau= '{1}'", tendangnhap, matkhau);
                conn.Open();
                SqlCommand com2 = new SqlCommand(query2, conn);
                String data2 = com2.ExecuteScalar().ToString();
                conn.Close();
                frmnhanvien f1 = new frmnhanvien(data2);
                this.Hide();
                f1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Thông báo");
                this.txttendangnhap.Clear();
                this.txtmatkhau.Clear();
                this.txttendangnhap.Focus();
            }

        }

        private void frmdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //dt_user.Dispose();
            //dt_user = null;
            conn = null;
            
        }
    }
}
