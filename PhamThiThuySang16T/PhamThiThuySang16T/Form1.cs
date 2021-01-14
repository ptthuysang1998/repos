using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamThiThuySang16T
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadlist();

        }

        private void loadlist()
        {
            using (QLEntities db = new QLEntities())
            {
                var result = from s in db.Khoa select s;
                lvshowTT.Items.Clear();
                foreach( var data in result)// doc nd trong result
                {
                    ListViewItem listView = new ListViewItem(data.makhoa+"");// lay thong tin theo lua chon vd(tensv)
                   listView.SubItems.Add(data.tenkhoa);//add dchi cho tung Sv
                    
                    lvshowTT.Items.Add(listView);//show TT ra;
                   
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int idkhoa=0;
        private void lvshowTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem list in lvshowTT.SelectedItems)// chon Imtem trong bang
            {
                idkhoa = Int32.Parse(list.SubItems[0].Text);// the same list view , hi kich tt ben bang nhay qua o
                
            }
            loadkhoa();
        }
        void loadkhoa()
        {
            using (QLEntities db = new QLEntities())
            {
                var result = from s in db.Table_TTSV
                             where s.makhoa == idkhoa
                             select s;
                lvKhoa.Items.Clear();
                foreach (var data in result)
                {
                    ListViewItem listView = new ListViewItem(data.tensv);
                    listView.SubItems.Add(data.diachi);
                    listView.SubItems.Add(data.masv + "");
                    lvKhoa.Items.Add(listView);
                }
            }
        }
        int mk =0;
        private void btnthem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listView in lvshowTT.SelectedItems)
            {
                mk = Int32.Parse(listView.SubItems[0].Text);//lay id sv
            }
            QLEntities db = new QLEntities();
            Table_TTSV sv = new Table_TTSV();
            sv.tensv = txtTen.Text;
            sv.diachi = txtDiaChi.Text;
            sv.makhoa = mk;
            db.Table_TTSV.Add(sv);
            db.SaveChanges();
            loadkhoa();
            loadlist();





        }

        int id = 0;//khoi tao id
        private void btnsua_Click(object sender, EventArgs e)
        {
            foreach( ListViewItem listView in lvKhoa.SelectedItems)
            {
                id = Int32.Parse(listView.SubItems[2].Text);//lay id sv
            }

            QLEntities db = new QLEntities();
            Table_TTSV sv = db.Table_TTSV.Where(p => p.masv == id).SingleOrDefault();
            sv.tensv = txtTen.Text;
            sv.diachi = txtDiaChi.Text;
            db.SaveChanges();
            loadlist();



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
            txtTen.Text = "";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listView in lvKhoa.SelectedItems)
            {
                id = Int32.Parse(listView.SubItems[2].Text);//lay id sv
            }

            QLEntities db = new QLEntities();
            Table_TTSV sv = db.Table_TTSV.Where(p => p.masv == id).SingleOrDefault();
            db.Table_TTSV.Remove(sv);
            db.SaveChanges();
            loadlist();

        }

        private void lvKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listView in lvKhoa.SelectedItems)
            {
                //id = Int32.Parse(listView.SubItems[2].Text);//lay id sv
                txtTen.Text = listView.SubItems[0].Text;
                txtDiaChi.Text = listView.SubItems[1].Text;
            }

        }
    }
}
