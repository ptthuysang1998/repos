using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Model;
using WindowsFormsApp3.Service;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadLop();
            var list = MonHocService.getMonHoc();
            foreach (MonHoc mon in list)
            {
                cbMH.Items.Add(mon);
            }
        }
        public void LoadLop()
        {
            var list = LopService.getLopHP();
            dataGridViewLop.AutoGenerateColumns = false;
            bdsLop.DataSource = list;
            dataGridViewLop.DataSource = bdsLop;




        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonHoc monSelected = (MonHoc)cbMH.SelectedItem;
            var list = LopService.getLopHP(monSelected.MaMonHoc);
            bdsLop.DataSource = list;
            dataGridViewLop.DataSource = bdsLop;
            txtMaLopHP.Text = monSelected.TenMonHoc;
        }

        private void dataGridViewLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var lop = bdsLop.Current as LopHocPhan;
            txtMaLopHP.Text = lop.MaLopHP;
            txtMax.Text = lop.ToiDa.ToString();
            txtMin.Text = lop.ToiThieu.ToString();
            txtGV.Text = lop.GiaoVienPT;
            txtSoLuong.Text = LopService.CountSv(lop.MaLopHP).ToString();
            LoadSV();
        }
        public void LoadSV()
        {
            var lop = bdsLop.Current as LopHocPhan;
            var list = LopService.getListMaSV(lop.MaLopHP);
            var listSV = new List<SinhVien>();
            foreach (string masv in list)
            {
                SinhVien sv = SinhVien.getSinhVienInfo(masv);
                listSV.Add(sv);
            }
            dataGridViewSV.AutoGenerateColumns = false;
            bdsSV.DataSource = listSV;
            dataGridViewSV.DataSource = bdsSV;
            txtSoLuong.Text = LopService.CountSv(lop.MaLopHP).ToString();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {

        }
    }
}
