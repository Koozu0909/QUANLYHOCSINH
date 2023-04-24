using System;

namespace BussinessLayer.DTO
{
    public class tb_GiaoVien_MonDTO
    {
        public int MaGV_MH { get; set; }
        public Nullable<int> MaGV { get; set; }
        public string HoTenGV { get; set; }
        public Nullable<int> MaNamHoc { get; set; }
        public Nullable<int> MaMH { get; set; }
        public string TenMH { get; set; }
        public Nullable<int> GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> MaTrinhDo { get; set; }
        public string TenTrinhDo { get; set; }
        public string GhiChu { get; set; }
    }
}