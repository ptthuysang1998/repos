//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sang
{
    using System;
    using System.Collections.Generic;
    
    public partial class sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sach()
        {
            this.ChiTietHoaDon = new HashSet<ChiTietHoaDon>();
            this.GioHang = new HashSet<GioHang>();
        }
    
        public string masach { get; set; }
        public string tensach { get; set; }
        public Nullable<long> soluong { get; set; }
        public Nullable<long> gia { get; set; }
        public string maloai { get; set; }
        public string sotap { get; set; }
        public string anh { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public string tacgia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public virtual loai loai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GioHang> GioHang { get; set; }
    }
}
