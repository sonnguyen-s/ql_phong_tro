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
    public partial class frmdangky : Form
    {
        String strconn = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlyphongtro;Integrated Security = True";
        SqlConnection conn = null;
        public frmdangky()
        {
            InitializeComponent();
        }
        private void btndangky_Click(object sender, EventArgs e)
        {
            //lay thong tin nhap tu ban phim
            String tendangnhap = txttendangnhap.Text;
            String matkhau = txtmatkhau.Text;
            String nhaplaimatkhau = txtnhaplaimatkhau.Text;
            String tenhienthi = txttenhienthi.Text;
            //ket noi co so du lieu
            conn = new SqlConnection(strconn);
            String query = String.Format("select tenDangNhap from taikhoan where tenDangNhap=N'{0}'",tendangnhap);
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable data = new DataTable();
            adapter.Fill(data);
            conn.Close();
            bool datontai;
            int sodongdata = data.Rows.Count;
            if (sodongdata == 0)
            {
                datontai = false;
            }
            else
            {
                datontai = true;
            }

            if(tendangnhap == ""||tenhienthi==""||matkhau==""||nhaplaimatkhau=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            } 
            else if (matkhau != nhaplaimatkhau)
            {
                MessageBox.Show("Mật khẩu không giống nhau!");
            }
            else if (datontai == true)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
            } 
            else
            {
                conn = new SqlConnection(strconn);
                String query1 = String.Format("insert into taikhoan (tenDangNhap,tenHienThi,matKhau,quyenHan) values('{0}',N'{1}','{2}',N'Nhân viên')",tendangnhap,tenhienthi,matkhau);
                conn.Open();
                SqlCommand com1 = new SqlCommand(query1,conn);
                com1.ExecuteNonQuery();
                conn.Close();
                this.txttendangnhap.Clear();
                this.txttenhienthi.Clear();
                this.txtmatkhau.Clear();
                this.txtnhaplaimatkhau.Clear();
                this.txttendangnhap.Focus();
                MessageBox.Show("Đã tạo tài khoản thành công!");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            this.txttendangnhap.Clear();
            this.txttenhienthi.Clear();
            this.txtmatkhau.Clear();
            this.txtnhaplaimatkhau.Clear();
            this.txttendangnhap.Focus();
        }
    }
}
