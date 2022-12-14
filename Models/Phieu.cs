//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTL_CNPM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phieu()
        {
            this.NhaCungCaps = new HashSet<NhaCungCap>();
        }
    
        public long Id { get; set; }
        public Nullable<long> IdThietBi { get; set; }
        public Nullable<long> IdNhanVien { get; set; }
        public Nullable<long> IdLoaiPhieu { get; set; }
        public Nullable<long> NgayLapPhieu { get; set; }
        public string ChiPhi { get; set; }
    
        public virtual LoaiPhieu LoaiPhieu { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhaCungCap> NhaCungCaps { get; set; }
    }
}
