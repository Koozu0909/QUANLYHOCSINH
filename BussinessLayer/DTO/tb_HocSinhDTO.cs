using System;

namespace BussinessLayer.DTO
{
    public class tb_HocSinhDTO
    {
        public int MaHS { get; set; }
        public string HoTen { get; set; }
        public string Ten { get; set; }
        public Nullable<int> GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public Nullable<int> MaDanToc { get; set; }
        public Nullable<int> MaTonGiao { get; set; }
        public Nullable<int> MaLop { get; set; }
        public string TenLop { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> DeleteBy { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }

        public string TenDanToc { get; set; }
        public string TenTonGiao { get; set; }
    }
}