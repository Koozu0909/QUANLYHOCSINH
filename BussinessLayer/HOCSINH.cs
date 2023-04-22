using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.DTO;
using DataLayer;
using System.Globalization;

namespace BussinessLayer
{
    public class HOCSINH
    {
        private QUANLYHOCSINHEntities db = null;

        public HOCSINH()
        {
            db = new QUANLYHOCSINHEntities();
        }

        public tb_HocSinh getItem(int id)
        {
            return db.tb_HocSinh.FirstOrDefault(x => x.MaHS == id);
        }
       
        public List<tb_HocSinhDTO> SearchByName(string kw)
        {
            var lst = from c in db.tb_HocSinh
                         where c.HoTen.Contains(kw)
                         select c;
            List<tb_HocSinhDTO> lsHS = new List<tb_HocSinhDTO>();
            tb_HocSinhDTO hsDTO;
            foreach (var item in lst)
            {
                hsDTO = new tb_HocSinhDTO();
                hsDTO.MaHS = item.MaHS;
                hsDTO.HoTen = item.HoTen;
                hsDTO.Ten = item.Ten;
                hsDTO.GioiTinh = item.GioiTinh;
                hsDTO.NgaySinh = item.NgaySinh;
                hsDTO.DiaChi = item.DiaChi;
                hsDTO.GhiChu = item.GhiChu;
                hsDTO.DienThoai = item.DienThoai;
                hsDTO.MaDanToc = item.MaDanToc;
                var td = db.tb_DanToc.FirstOrDefault(t => t.MaDanToc == item.MaDanToc);
                hsDTO.TenDanToc = td.TenDanToc;
                hsDTO.MaTonGiao = item.MaTonGiao;
                var cv = db.tb_TonGiao.FirstOrDefault(t => t.MaTonGiao == item.MaTonGiao);
                hsDTO.TenTonGiao = cv.TenTonGiao;
                hsDTO.CreateBy = item.CreateBy;
                hsDTO.CreateDate = item.CreateDate;
                hsDTO.UpdateBy = item.UpdateBy;
                hsDTO.UpdateDate = item.UpdateDate;
                hsDTO.DeleteBy = item.DeleteBy;
                hsDTO.DeleteDate = item.DeleteDate;
                lsHS.Add(hsDTO);
            }
            return lsHS;
        }
        public List<tb_HocSinhDTO> getList()
        {
            var lst = db.tb_HocSinh.ToList();
            List<tb_HocSinhDTO> lsHS = new List<tb_HocSinhDTO>();
            tb_HocSinhDTO hsDTO;
            foreach (var item in lst)
            {
                hsDTO = new tb_HocSinhDTO();
                hsDTO.MaHS = item.MaHS;
                hsDTO.HoTen = item.HoTen;
                hsDTO.Ten = item.Ten;
                hsDTO.GioiTinh = item.GioiTinh;
                hsDTO.NgaySinh = item.NgaySinh;
                hsDTO.DiaChi = item.DiaChi;
                hsDTO.GhiChu = item.GhiChu;
                hsDTO.DienThoai = item.DienThoai;
                hsDTO.MaDanToc = item.MaDanToc;
                var td = db.tb_DanToc.FirstOrDefault(t => t.MaDanToc == item.MaDanToc);
                hsDTO.TenDanToc = td.TenDanToc;
                hsDTO.MaTonGiao = item.MaTonGiao;
                var cv = db.tb_TonGiao.FirstOrDefault(t => t.MaTonGiao == item.MaTonGiao);
                hsDTO.TenTonGiao = cv.TenTonGiao;
                hsDTO.CreateBy = item.CreateBy;
                hsDTO.CreateDate = item.CreateDate;
                hsDTO.UpdateBy = item.UpdateBy;
                hsDTO.UpdateDate = item.UpdateDate;
                hsDTO.DeleteBy = item.DeleteBy;
                hsDTO.DeleteDate = item.DeleteDate;
                lsHS.Add(hsDTO);
            }
            return lsHS;
        }
        public List<tb_HocSinhDTO> getList(int malop, int namhoc)
        {
            var lst = db.tb_HocSinh_Lop_NamHoc.Where(x => x.MaLop == malop && x.MaNamHoc == namhoc).ToList();
            List<tb_HocSinhDTO> lsHS = new List<tb_HocSinhDTO>();
            tb_HocSinhDTO hsDTO;
            foreach (var hs in lst)
            {
                hsDTO = new tb_HocSinhDTO();
                hsDTO.MaHS = hs.MaHS;
                var item = db.tb_HocSinh.FirstOrDefault(x => x.MaHS == hs.MaHS);
                hsDTO.HoTen = item.HoTen;
                hsDTO.Ten = item.Ten;
                hsDTO.GioiTinh = item.GioiTinh;
                hsDTO.NgaySinh = item.NgaySinh;
                hsDTO.DiaChi = item.DiaChi;
                hsDTO.GhiChu = item.GhiChu;
                hsDTO.DienThoai = item.DienThoai;
                hsDTO.MaDanToc = item.MaDanToc;
                var td = db.tb_DanToc.FirstOrDefault(t => t.MaDanToc == item.MaDanToc);
                hsDTO.TenDanToc = td.TenDanToc;
                hsDTO.MaTonGiao = item.MaTonGiao;
                var cv = db.tb_TonGiao.FirstOrDefault(t => t.MaTonGiao == item.MaTonGiao);
                hsDTO.TenTonGiao = cv.TenTonGiao;
                var lop = db.tb_Lop.FirstOrDefault(l => l.MaLop == malop);
                hsDTO.TenLop = lop.TenLop;
                hsDTO.CreateBy = item.CreateBy;
                hsDTO.CreateDate = item.CreateDate;
                hsDTO.UpdateBy = item.UpdateBy;
                hsDTO.UpdateDate = item.UpdateDate;
                hsDTO.DeleteBy = item.DeleteBy;
                hsDTO.DeleteDate = item.DeleteDate;
                lsHS.Add(hsDTO);
            }
            return lsHS;
        }

        public tb_HocSinh Add(tb_HocSinh hs)
        {
            try
            {
                db.tb_HocSinh.Add(hs);
                db.SaveChanges();
                return hs;
            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }
        }

        public tb_HocSinh Update(tb_HocSinh MaHS)
        {
            try
            {
                var _hs = db.tb_HocSinh.FirstOrDefault(x => x.MaHS == MaHS.MaHS);
                _hs.HoTen = MaHS.HoTen;
                _hs.Ten = MaHS.Ten;
                _hs.GioiTinh = MaHS.GioiTinh;
                _hs.NgaySinh = MaHS.NgaySinh;
                _hs.DiaChi = MaHS.DiaChi;
                _hs.GhiChu = MaHS.GhiChu;
                _hs.DienThoai = MaHS.DienThoai;
                _hs.MaDanToc = MaHS.MaDanToc;
                _hs.MaTonGiao = MaHS.MaTonGiao;
                _hs.UpdateBy = MaHS.UpdateBy;
                _hs.UpdateDate = MaHS.UpdateDate;
                db.SaveChanges();
                return MaHS;
            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int id, int UserID)
        {
            try
            {
                var _hs = db.tb_HocSinh.FirstOrDefault(x => x.MaHS == id);

                _hs.DeleteBy = UserID;
                _hs.DeleteDate = DateTime.Now;
                db.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
