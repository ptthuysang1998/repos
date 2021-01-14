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
    class MonHocService
    {
        public static List<MonHoc> getMonHoc()
        {
            var index = 0;
            string sql = "select * from MONHOC";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            var list = new List<MonHoc>();
            foreach (DataRow r in data.Rows)
            {
                var mon = new MonHoc(r);
                list.Add(mon);
            }
            /*  index = list.Count();
              int ma = int.Parse(list[index - 1].MaMonHoc.ToString());*/
            return list;
        }
        public static MonHoc GetMonIfo(string mamh)
        {
            var index = 0;
            string sql = "select * from MONHOC where MaMonHoc= @mamh ";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql, new object[] { mamh });
            var list = new List<MonHoc>();
            foreach (DataRow r in data.Rows)
            {
                var mon = new MonHoc(r);
                list.Add(mon);
            }
            /*  index = list.Count();
              int ma = int.Parse(list[index - 1].MaMonHoc.ToString());*/
            return list[0];
        }
    }
}
