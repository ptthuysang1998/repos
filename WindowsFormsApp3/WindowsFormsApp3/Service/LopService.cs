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
    class LopService
    {
        public static List<LopHocPhan> getLopHP()
        {
            // var index = 0;
            string sql = "select * from LOPHOCPHAN";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            var list = new List<LopHocPhan>();
            foreach (DataRow r in data.Rows)
            {
                var lop = new LopHocPhan(r);
                list.Add(lop);
            }
            /* index = list.Count();
             int ma = int.Parse(list[index - 1].MaLopHP.ToString());*/
            return list;
        }
        public static List<LopHocPhan> getLopHP(string mamh = null)
        {
            // var index = 0;
            string sql = "select * from LOPHOCPHAN where MaMonHoc= @mamh ";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql, new object[] { mamh });
            //DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            var list = new List<LopHocPhan>();
            foreach (DataRow r in data.Rows)
            {
                var lop = new LopHocPhan(r);
                list.Add(lop);
            }
            /* index = list.Count();
             int ma = int.Parse(list[index - 1].MaLopHP.ToString());*/
            return list;
        }
        public static int CountSv(string malop)
        {

            string sql = "select COUNT(*) as SoSV from HOCTAP where MaLopHP= @malop ";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql, new object[] { malop });
            var list = new List<String>();
            foreach (DataRow r in data.Rows)
            {
                String a = r["SoSV"].ToString();
                list.Add(a);
            }
            int b = int.Parse(list[0].ToString());
            return b;
        }
        public static List<string> getListMaSV(string malop)
        {
            // var index = 0;
            string sql = "select * from HOCTAP where MaLopHP= @malop ";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql, new object[] { malop });
            //DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            var list = new List<string>();
            foreach (DataRow r in data.Rows)
            {
                string a = r["MaSV"].ToString();
                list.Add(a);
            }
            /* index = list.Count();
             int ma = int.Parse(list[index - 1].MaLopHP.ToString());*/
            return list;
        }
        public static void ThemSV(string masv = null, string malop = null)
        {
            string sql = "Insert into HOCTAP (MaSV,MaLopHP) values ( @masv , @malop )";


            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { masv, malop });
        }
        public static void DeleteSV(string masv, string malophp)
        {
            string sql = "delete from HOCTAP where MaSV= @masv and MaLopHP= @malophp ";


            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { masv, malophp });



        }
        public static Boolean CheckSvTrongLop(string masv, string malophp)
        {
            string sql = "select count(*) as COUNT from HOCTAP where MaSV= @masv and MaLopHP= @malophp ";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql, new object[] { masv, malophp });
            var list = new List<int>();
            foreach (DataRow r in data.Rows)
            {
                int a = int.Parse(r["COUNT"].ToString());
                list.Add(a);
            }
            int b = list[0];
            if (b != 0)
            {
                //MessageBox.Show("Sinh vien da co ");
                return true;
            }
            //MessageBox.Show("Sinh vien CHUA co ");
            return false;
        }
        public static void EditLopHocPhan(string tenlophp = null, string mamonhoc = null, int toithieu = 0, int toida = 0, string giaovienpt = null, string malophp = null)
        {
            string sql = "update LOPHOCPHAN set TenLopHP= @tenlophp , MaMonHoc= @mamonhoc , ToiThieu= @toithieu ,ToiDa= @toida ,GiaoVienPT= @giaovienpt where MaLopHP= @malophp ";



            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { tenlophp, mamonhoc, toithieu, toida, giaovienpt, malophp });

        }
        public static void EditSvDoiLop(string masv = null, string malophp = null)
        {
            string sql = "update HOCTAP set MaLopHP= @malophp where MaSV= @masv ";



            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { malophp, masv });

        }
        public static void AddLopHocPhan(string tenlophp = null, string mamonhoc = null, int toithieu = 0, int toida = 0, string giaovienpt = null, string malophp = null)
        {
            string sql = "insert into LOPHOCPHAN (MaLopHP,TenLopHP,MaMonHoc,ToiThieu,ToiDa,GiaoVienPT) values ( @malophp , @tenlophp , @mamonhoc , @toithieu , @toida , @giaovienpt )";



            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { malophp, tenlophp, mamonhoc, toithieu, toida, giaovienpt });

        }
        public static void DeleteLopHP(string malophp)
        {
            string sql = "delete from LOPHOCPHAN where MaLopHP= @malophp ";


            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { malophp });



        }
        public static Boolean CheckMaLopHP(string malophp)
        {
            string sql = "select count(*) as COUNT from LOPHOCPHAN where MaLopHP= @malophp ";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql, new object[] { malophp });
            var list = new List<int>();
            foreach (DataRow r in data.Rows)
            {
                int a = int.Parse(r["COUNT"].ToString());
                list.Add(a);
            }
            int b = list[0];
            if (b != 0)
            {
                //MessageBox.Show("lop da co ");
                return true;
            }
            //MessageBox.Show("lop chua co ");
            return false;
        }
    }
}
