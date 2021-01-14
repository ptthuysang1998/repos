using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamThiThuySang.Model
{
    class KHOA
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }



        public KHOA(string mk, string tk)
        {
            this.MaKhoa = mk;
            this.TenKhoa = tk;

        }
        public KHOA(DataRow r)
        {
            this.MaKhoa = r["MaKhoa"].ToString();
            this.TenKhoa = r["TenKhoa"].ToString();

        }
    }
}
