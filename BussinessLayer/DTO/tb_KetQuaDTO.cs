using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.DTO
{
    public class tb_KetQuaDTO
    {
        public int MaKQ { get; set; }
        public Nullable<int> MaMH { get; set; }
        public string TenMH { get; set; }
        public Nullable<int> MaHS { get; set; }
        public string HoTen { get; set; }
        public Nullable<double> DiemKT { get; set; }
        public Nullable<double> DiemThiLan1 { get; set; }
        public Nullable<double> DiemThiLan2 { get; set; }
        public Nullable<double> DiemTB { get; set; }
        public string XepLoai { get; set; }
        public Nullable<int> MaNamHoc { get; set; }
        public string TenNamHoc { get; set; }
        public Nullable<int> MaHocKy { get; set; }
        public string TenHocKy { get; set; }
        public Nullable<int> MaLop { get; set; }
        public string TenLop { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> DeleteBy { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
    }
}
