using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BussinessLayer.DTO;

namespace BussinessLayer
{
    public class GIAOVIEN_LOP
    {
        private QUANLYHOCSINHEntities db = null;

        public GIAOVIEN_LOP()
        {
            db = new QUANLYHOCSINHEntities();
        }
        public tb_GiaoVien_Lop getItem(int id)
        {
            return db.tb_GiaoVien_Lop.FirstOrDefault(x => x.MaGV_Lop == id);
        }
        public List<tb_GiaoVien_LopDTO> getListBy(int manamhoc, int malop , int mahocky)
        {
            var lst = db.tb_GiaoVien_Lop.Where(x => x.MaNamHoc == manamhoc && x.MaHocKy == mahocky && x.MaLop == malop).ToList();
            List<tb_GiaoVien_LopDTO> lstDTO = new List<tb_GiaoVien_LopDTO>();
            tb_GiaoVien_LopDTO dto;
            foreach (var item in lst)
            {
                dto = new tb_GiaoVien_LopDTO();
                dto.MaGV_Lop = item.MaGV_Lop;
                dto.MaGV = item.MaGV;
                var gv = db.tb_GiaoVien.FirstOrDefault(x => x.MaGV == item.MaGV);
                dto.HoTenGV = gv.HoTen;
                dto.MaLop = item.MaLop;
                var lop = db.tb_Lop.FirstOrDefault(x => x.MaLop == item.MaLop);
                dto.TenLop = lop.TenLop;
                dto.MaNamHoc = item.MaNamHoc;
                var namhoc = db.tb_NamHoc.FirstOrDefault(x => x.MaNamHoc == item.MaNamHoc);
                dto.TenNamHoc = namhoc.TenNamHoc;
                dto.ChuNhiem = item.ChuNhiem;
                dto.MaMH = item.MaMH;
                var monhoc = db.tb_MonHoc.FirstOrDefault(x => x.MaMH == item.MaMH);
                dto.TenMonHoc = monhoc.TenMH;
                dto.MaHocKy = item.MaHocKy;
                var hocky = db.tb_HocKy.FirstOrDefault(x => x.MaHocKy == item.MaHocKy);
                dto.TenHocKy = hocky.TenHocKy;
                lstDTO.Add(dto);
            }
            return lstDTO;
        }
        public tb_GiaoVien_Lop Add(tb_GiaoVien_Lop hs)
        {
            try
            {
                db.tb_GiaoVien_Lop.Add(hs);
                db.SaveChanges();
                return hs;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
        public tb_GiaoVien_Lop Update(tb_GiaoVien_Lop magvlop)
        {
            try
            {
                var _gv = db.tb_GiaoVien_Lop.FirstOrDefault(x => x.MaGV_Lop == magvlop.MaGV_Lop);
                _gv.MaGV = magvlop.MaGV;
                _gv.MaHocKy = magvlop.MaHocKy;
                _gv.MaMH = magvlop.MaMH;
                _gv.MaLop = magvlop.MaLop;
                _gv.MaNamHoc = magvlop.MaNamHoc;
                _gv.ChuNhiem = magvlop.ChuNhiem;
                db.SaveChanges();
                return magvlop;
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
                var _hs = db.tb_GiaoVien_Lop.FirstOrDefault(x => x.MaGV_Lop == id);
                db.tb_GiaoVien_Lop.Remove(_hs);
                db.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
