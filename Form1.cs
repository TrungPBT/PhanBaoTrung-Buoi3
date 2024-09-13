using System.Linq.Expressions;

namespace PhanBaoTrung_Buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            HinhChuNhat hinhChuNhat = new HinhChuNhat();
            hinhChuNhat.setCd(int.Parse(txt_cd.Text));
            hinhChuNhat.setCr(int.Parse(txt_cr.Text));

            MessageBox.Show("Chiều dài: " + hinhChuNhat.getCd() + "\n Chiều rộng: " + hinhChuNhat.getCr());
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.setMssv(int.Parse(txt_mssv.Text));
            sinhVien.setHoten(int.Parse(txt_hoten.Text));
            sinhVien.setNs(int.Parse(txt_ns.Text));
            sinhVien.setSdt(int.Parse(txt_sdt.Text));
            sinhVien.setGt(int.Parse(txt_gt.Text));

            MessageBox.Show
     
        }
    }
}
