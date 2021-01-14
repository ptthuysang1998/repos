using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamThiThuySang.Model
{
    class SINHVIEN
    {
        public string MaSinhVien { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }

        public string NoiSinh { get; set; }




        public SINHVIEN(string masv, string ho, string ten, string gt, string ns)
        {
            this.MaSinhVien = masv;
            this.Ho= ho;
            this.Ten = ten;
            this.GioiTinh = gt;
            this.NoiSinh = ns;
            

        }
        public SINHVIEN(DataRow r)
        {
            this.MaSinhVien = r["MaSinhVien"].ToString();
            this.Ho = r["Ho"].ToString();
            this.Ten = r["Ten"].ToString();
            this.GioiTinh = r["GioiTinh"].ToString();
            this.NoiSinh = r["NoiSinh"].ToString();
          
        }
    }
}
