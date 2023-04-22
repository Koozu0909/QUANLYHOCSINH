using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.DTO
{
    public class tb_HocKyDTO
    {
        public int MaHocKy { get; set; }
        public string TenHocKy { get; set; }
        public Nullable<int> HeSo { get; set; }
        public Nullable<int> MaNamHoc { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> DeleteBy { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }

        public string TenNamHoc { get; set; }
        
    }
}
