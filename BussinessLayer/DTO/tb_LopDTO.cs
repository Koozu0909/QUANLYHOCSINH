using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.DTO
{
    public class tb_LopDTO
    {
        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> MaKhoiLop { get; set; }
        public string TenKhoiLop { get; set; }
        public Nullable<int> SapXep { get; set; }
        public Nullable<int> MaTruong { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> DeleteBy { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
    }
}
