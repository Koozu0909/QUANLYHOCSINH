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

        public string GhiChu { get; set; }
    }
}