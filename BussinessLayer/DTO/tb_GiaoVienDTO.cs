using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.DTO
{
    using System;
    using System.Collections.Generic;
    public class tb_GiaoVienDTO
    {
        public int MaGV { get; set; }
        public string HoTen { get; set; }
        public string Ten { get; set; }
        public Nullable<int> GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public byte[] HinhAnh { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> MaTrinhDo { get; set; }
        public Nullable<int> MaChucVu { get; set; }
        public Nullable<int> MaMH { get; set; }
        public string TenMH { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> DeleteBy { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }

        public string TenTrinhDo { get; set; }
        public string TenChucVu { get; set; }
    }
}
