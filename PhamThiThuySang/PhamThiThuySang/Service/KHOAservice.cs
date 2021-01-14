using PhamThiThuySang.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhamThiThuySang.Model;

namespace PhamThiThuySang.Service
{
    class KHOAservice
    {
        private DataRow r;

        public KHOAservice(DataRow r)
        {
            this.r = r;
        }

        public static List<KHOA> getTenKHoa()
        {
            var index = 0;
            string sql = "select * from KHOA";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            var list = new List<KHOA>();
            foreach (DataRow r in data.Rows)
            {
                var mon = new KHOA(r);
                list.Add(mon);
            }
            /*  index = list.Count();
              int ma = int.Parse(list[index - 1].MaMonHoc.ToString());*/
            return list;
        }

        

        public static KHOAservice GeTkhoaIfo(string mamh)
        {
            var index = 0;
            string sql = "select * from KHOA where MaKhoa= @mk ";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql, new object[] { mamh });
            var list = new List<KHOAservice>();
            foreach (DataRow r in data.Rows)
            {
                var mon = new KHOAservice(r);
                list.Add(mon);
            }
            /*  index = list.Count();
              int ma = int.Parse(list[index - 1].MaMonHoc.ToString());*/
            return list[0];
        }
    }

}
