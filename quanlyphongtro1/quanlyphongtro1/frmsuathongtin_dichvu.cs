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
    public partial class frmsuathongtin_dichvu : Form
    {
        String strconn = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlyphongtro;Integrated Security = True";
        SqlConnection conn = null;
        private String tendichvu;
        public frmsuathongtin_dichvu()
        {
            InitializeComponent();
        }

        public frmsuathongtin_dichvu(String ptenDichVu)
            :this()
        {
            tendichvu = ptenDichVu;
            txttendichvu.Text = ptenDichVu;
        }
        void clear()
        {
            this.txttendichvu.Clear();
            this.txtdonvitinh.Clear();
            this.txtdongia.Clear();
            this.txttendichvu.Focus();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            String dongia = txtdongia.Text;
            String donvitinh = txtdonvitinh.Text;

            if (dongia == "" || donvitinh == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            } else
            {
                conn = new SqlConnection(strconn);
                String query = String.Format("update danhSachDichVu set donViTinh = '{0}', donGia ='{1}' where tenDichVu = '{2}'", donvitinh, dongia, tendichvu);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Cập nhật thành công");
                clear();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
