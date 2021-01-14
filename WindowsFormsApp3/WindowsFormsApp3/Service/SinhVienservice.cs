using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DAO;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Service
{
    class SinhVienservice
    {
        public static List<SinhVien> getSinhVien()
        {
            var index = 0;
            string sql = "select * from SINHVIEN";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            var list = new List<SinhVien>();
            foreach (DataRow r in data.Rows)
            {
                var sv = new SinhVien(r);
                list.Add(sv);
            }
            /*  index = list.Count();
              int ma = int.Parse(list[index - 1].MaMonHoc.ToString());*/
            return list;
        }
        public static void EditSinhVien(string masv = null, string hoten = null, string khoa = null, string diachi = null)
        {
            string sql = "update SINHVIEN set HoTen= @hoten ,Khoa= @khoa ,DiaChi= @diachi where MaSV= @msv ";



            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { hoten, khoa, diachi, masv });

        }
    }
}
