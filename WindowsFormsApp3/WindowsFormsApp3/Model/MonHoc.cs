using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Model
{
    class MonHoc
    {
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }



        public MonHoc(string mamh, string tenmh)
        {
            this.MaMonHoc = mamh;
            this.TenMonHoc = tenmh;

        }
        public MonHoc(DataRow r)
        {
            this.MaMonHoc = r["MaMonHoc"].ToString();
            this.TenMonHoc = r["TenMH"].ToString();

        }
        public override string ToString()
        {
            return this.TenMonHoc;
        }
    }
}
