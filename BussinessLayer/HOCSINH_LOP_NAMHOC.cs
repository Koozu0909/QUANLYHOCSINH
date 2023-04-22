using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BussinessLayer.DTO;

namespace BussinessLayer
{
    public class HOCSINH_LOP_NAMHOC
    {
        private QUANLYHOCSINHEntities db = null;

        public HOCSINH_LOP_NAMHOC()
        {
            db = new QUANLYHOCSINHEntities();
        }
        public List<HS_CountDTO> getSoLuongHS_TungLop(int manamhoc, int makhoilop)
        {
            var lst = db.tb_HocSinh_Lop_NamHoc.Where(x => x.MaNamHoc == manamhoc && x.MaKhoiLop == makhoilop).GroupBy(x => x.MaLop)
                                              .Select(g => new { MaLop = g.Key, SoLuong = g.Count() }).ToList();
            List<HS_CountDTO> lstDTO = new List<HS_CountDTO>();
            HS_CountDTO dto;
            foreach (var item in lst)
            {
                dto = new HS_CountDTO();
                dto.MaLop = item.MaLop;
                var lop = db.tb_Lop.FirstOrDefault(x => x.MaLop == item.MaLop);
                dto.TenLop = lop.TenLop;
                dto.SoLuongHS = item.SoLuong;
                lstDTO.Add(dto);
            }
            return lstDTO;
        }

        public List<tb_HocSinhDTO> getList(int manamhhoc, int malop, int makhoilop)
        {
            var lst = db.tb_HocSinh_Lop_NamHoc.Where(x => x.MaNamHoc == manamhhoc && x.MaLop == malop && x.MaKhoiLop == makhoilop).ToList();
            List<tb_HocSinhDTO> lstDTO = new List<tb_HocSinhDTO>();
            tb_HocSinhDTO dto;
            foreach (var item in lst)
            {
                dto = new tb_HocSinhDTO();
                dto.MaHS = item.MaHS;
                var hs = db.tb_HocSinh.FirstOrDefault(x => x.MaHS == item.MaHS);
                dto.HoTen = hs.HoTen;
                dto.NgaySinh = hs.NgaySinh;
                dto.GioiTinh = hs.GioiTinh;
                dto.DiaChi = hs.DiaChi;
                dto.MaLop = item.MaLop;
                var lop = db.tb_Lop.FirstOrDefault(x => x.MaLop == item.MaLop);
                dto.TenLop = lop.TenLop;
                lstDTO.Add(dto);
            }
            return lstDTO;
        }
        public tb_HocSinh_Lop_NamHoc Add(tb_HocSinh_Lop_NamHoc hs)
        {
            try
            {
                db.tb_HocSinh_Lop_NamHoc.Add(hs);
                db.SaveChanges();
                return hs;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var _hs = db.tb_HocSinh_Lop_NamHoc.FirstOrDefault(x => x.MaHS == id);
                db.tb_HocSinh_Lop_NamHoc.Remove(_hs);
                db.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
