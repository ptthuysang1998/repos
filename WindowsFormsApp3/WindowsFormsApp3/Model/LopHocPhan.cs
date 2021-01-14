using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Model
{
    class LopHocPhan
    {
        public string MaLopHP { get; set; }
        public string TenLopHP { get; set; }

        public string MaMonHoc { get; set; }
        public int ToiThieu { get; set; }
        public int ToiDa { get; set; }
        public string GiaoVienPT { get; set; }


        public LopHocPhan(string malophp, string tenlophp, string mamh, int toithieu, int toida, string giaovienpt)
        {
            this.MaLopHP = malophp;
            this.TenLopHP = tenlophp;
            this.MaMonHoc = mamh;
            this.ToiThieu = toithieu;
            this.ToiDa = ToiDa;
            this.GiaoVienPT = giaovienpt;

        }
        public LopHocPhan(DataRow r)
        {
            this.MaLopHP = r["MaLopHP"].ToString();
            this.TenLopHP = r["TenLopHP"].ToString();
            this.MaMonHoc = r["MaMonHoc"].ToString();
            this.ToiThieu = int.Parse(r["ToiThieu"].ToString());
            this.ToiDa = int.Parse(r["ToiDa"].ToString());
            this.GiaoVienPT = r["GiaoVienPT"].ToString();

        }
        public override string ToString()
        {
            return this.TenLopHP;
        }
    }
}
