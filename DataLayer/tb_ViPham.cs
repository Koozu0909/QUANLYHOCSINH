//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_ViPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_ViPham()
        {
            this.tb_ViPham_CT = new HashSet<tb_ViPham_CT>();
        }
    
        public int MaViPham { get; set; }
        public Nullable<System.DateTime> NgayViPham { get; set; }
        public Nullable<int> TongSoLoi { get; set; }
        public Nullable<int> TongDiem { get; set; }
        public Nullable<int> MaLop { get; set; }
        public Nullable<int> MaNamHoc { get; set; }
        public Nullable<int> MaHocKy { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> DeteledBy { get; set; }
        public Nullable<System.DateTime> DeteledDate { get; set; }
    
        public virtual tb_HocKy tb_HocKy { get; set; }
        public virtual tb_Lop tb_Lop { get; set; }
        public virtual tb_NamHoc tb_NamHoc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ViPham_CT> tb_ViPham_CT { get; set; }
    }
}
