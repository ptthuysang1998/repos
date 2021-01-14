using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DAO;

namespace WindowsFormsApp3.Model
{
    class SinhVien
    {
        public int MaSV { get; set; }
        public string HoTen { get; set; }

        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }


        public SinhVien(int masv, string hoten, DateTime ngaysinh, string quequan)
        {
            this.MaSV = masv;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.QueQuan = quequan;

        }
        public SinhVien(DataRow r)
        {
            this.MaSV =  int.Parse( r["MaSV"].ToString());
            this.HoTen = r["HoTen"].ToString();
            /*  this.GioiTinh = Boolean.Parse(r["gioitinh"].ToString());*/
            this.NgaySinh = DateTime.Parse(r["NgaySinh"].ToString());
            
            this.QueQuan = r["QueQuan"].ToString();
        }
        public override string ToString()
        {
            return this.HoTen;
        }
        public static SinhVien getSinhVienInfo(string masv)
        {
            string sql = "select * from SINHVIEN where MaSV= @masv ";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql, new object[] { masv });
            //DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            var list = new List<SinhVien>();
            foreach (DataRow r in data.Rows)
            {
                SinhVien sv = new SinhVien(r);
                list.Add(sv);
            }
            /* index = list.Count();
             int ma = int.Parse(list[index - 1].MaLopHP.ToString());*/
            return list[0];
        }
    }
}
