using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BussinessLayer;
using BussinessLayer.DTO;

namespace BussinessLayer
{
    public class GIAOVIEN_MONHOC
    {
        private QUANLYHOCSINHEntities db = null;

        public GIAOVIEN_MONHOC()
        {
            db = new QUANLYHOCSINHEntities();
        }
        public tb_GiaoVien_MonHoc getItem(int idGV_Mh)
        {
            return db.tb_GiaoVien_MonHoc.FirstOrDefault(x => x.MaGV_MH == idGV_Mh);
        }
        public List<GV_MonCountDTO> getSoLuongGV_TungMon(int manamhoc)
        {
            var lst = db.tb_GiaoVien_MonHoc.Where(x => x.MaNamHoc == manamhoc).GroupBy(x => x.MaMH)
                                              .Select(g => new { MaMH = g.Key, SoLuong = g.Count() }).ToList();
            List<GV_MonCountDTO> lstDTO = new List<GV_MonCountDTO>();
            GV_MonCountDTO dto;
            foreach (var item in lst)
            {
                dto = new GV_MonCountDTO();
                dto.MaMH = (int)item.MaMH;
                var mh = db.tb_MonHoc.FirstOrDefault(x => x.MaMH == item.MaMH);
                dto.TenMH = mh.TenMH;
                dto.SoLuongGV = item.SoLuong;
                lstDTO.Add(dto);
            }
            return lstDTO;
        }
        public List<tb_GiaoVien_MonDTO> getListBy( int mamonhoc)
        {
            var lst = db.tb_GiaoVien_MonHoc.Where(x => x.MaMH == mamonhoc).ToList();
            List<tb_GiaoVien_MonDTO> lstDTO = new List<tb_GiaoVien_MonDTO>();
            tb_GiaoVien_MonDTO dto;
            foreach (var item in lst)
            {
                dto = new tb_GiaoVien_MonDTO();
                dto.MaGV_MH = item.MaGV_MH;
                dto.MaGV = item.MaGV;
                var hs = db.tb_GiaoVien.FirstOrDefault(x => x.MaGV == item.MaGV);
                dto.HoTenGV = hs.HoTen;
                dto.GioiTinh = hs.GioiTinh;
                dto.MaTrinhDo = hs.MaTrinhDo;
                dto.NgaySinh = hs.NgaySinh;
                var td = db.tb_TrinhDo.FirstOrDefault(x => x.MaTrinhDo == hs.MaTrinhDo);
                dto.TenTrinhDo = td.TenTrinhDo;
                dto.DiaChi = hs.DiaChi;
                dto.MaMH = item.MaMH;
                var mh = db.tb_MonHoc.FirstOrDefault(x => x.MaMH == item.MaMH);
                dto.TenMH = mh.TenMH;
                dto.MaNamHoc = item.MaNamHoc;
                dto.GhiChu = item.GhiChu;
                lstDTO.Add(dto);
            }
            return lstDTO;
        }

        public List<tb_GiaoVien_MonDTO> getList(int manamhhoc, int mamonhoc)
        {
            var lst = db.tb_GiaoVien_MonHoc.Where(x => x.MaNamHoc == manamhhoc && x.MaMH == mamonhoc).ToList();
            List<tb_GiaoVien_MonDTO> lstDTO = new List<tb_GiaoVien_MonDTO>();
            tb_GiaoVien_MonDTO dto;
            foreach (var item in lst)
            {
                dto = new tb_GiaoVien_MonDTO();
                dto.MaGV_MH = item.MaGV_MH;
                dto.MaGV = item.MaGV;
                var hs = db.tb_GiaoVien.FirstOrDefault(x => x.MaGV == item.MaGV);
                dto.HoTenGV = hs.HoTen;
                dto.MaMH = item.MaMH;
                var mh = db.tb_MonHoc.FirstOrDefault(x => x.MaMH == item.MaMH);
                dto.TenMH = mh.TenMH;
                dto.MaNamHoc = item.MaNamHoc;
                dto.GhiChu = item.GhiChu;
                lstDTO.Add(dto);
            }
            return lstDTO;
        }

        public tb_GiaoVien_MonHoc Update(tb_GiaoVien_MonHoc magvmh)
        {
            try
            {
                var _gv = db.tb_GiaoVien_MonHoc.FirstOrDefault(x => x.MaGV_MH == magvmh.MaGV_MH );
                _gv.MaGV = magvmh.MaGV;
                _gv.MaMH = magvmh.MaMH;
                _gv.MaNamHoc = magvmh.MaNamHoc;
                _gv.GhiChu = magvmh.GhiChu;
                db.SaveChanges();
                return magvmh;
            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }
        }
        public tb_GiaoVien_MonHoc Add(tb_GiaoVien_MonHoc hs)
        {
            try
            {
                db.tb_GiaoVien_MonHoc.Add(hs);
                db.SaveChanges();
                return hs;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int idGV_MH)
        {
            try
            {
                var _hs = db.tb_GiaoVien_MonHoc.FirstOrDefault(x => x.MaGV_MH == idGV_MH );
                db.tb_GiaoVien_MonHoc.Remove(_hs);
                db.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
