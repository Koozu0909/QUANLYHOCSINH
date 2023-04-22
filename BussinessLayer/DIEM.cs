using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BussinessLayer.DTO;


namespace BussinessLayer
{
    public class DIEM
    {
        private QUANLYHOCSINHEntities db = null;

        public DIEM()
        {
            db = new QUANLYHOCSINHEntities();
        }

        public tb_KetQua getItem(int id)
        {
            return db.tb_KetQua.FirstOrDefault(x => x.MaKQ == id);
        }
        public List<tb_KetQuaDTO> getListBy(int malop, int mahk, int mamh, int manamhhoc, int mahs)
        {
            var lst = db.tb_KetQua.Where(x => x.MaLop == malop && x.MaNamHoc == manamhhoc && x.MaHocKy == mahk && x.MaMH == mamh && x.MaHS == mahs).ToList();
            List<tb_KetQuaDTO> lsHS = new List<tb_KetQuaDTO>();
            tb_KetQuaDTO kqDTO;
            foreach (var item in lst)
            {
                kqDTO = new tb_KetQuaDTO();
                kqDTO.MaKQ = item.MaKQ;
                kqDTO.MaHS = item.MaHS;
                var hs = db.tb_HocSinh.FirstOrDefault(t => t.MaHS == item.MaHS);
                kqDTO.HoTen = hs.HoTen;
                kqDTO.MaMH = item.MaMH;
                var mh = db.tb_MonHoc.FirstOrDefault(t => t.MaMH == item.MaMH);
                kqDTO.TenMH = mh.TenMH;
                kqDTO.DiemKT = item.DiemKT;
                kqDTO.DiemThiLan1 = item.DiemThiLan1;
                kqDTO.DiemThiLan2 = item.DiemThiLan2;
                kqDTO.DiemTB = item.DiemTB;
                kqDTO.XepLoai = item.XepLoai;
                kqDTO.MaNamHoc = item.MaNamHoc;
                var nh = db.tb_NamHoc.FirstOrDefault(t => t.MaNamHoc == item.MaNamHoc);
                kqDTO.TenNamHoc = nh.TenNamHoc;
                kqDTO.MaHocKy = item.MaHocKy;
                var hk = db.tb_HocKy.FirstOrDefault(t => t.MaHocKy == item.MaHocKy);
                kqDTO.TenHocKy = hk.TenHocKy;
                kqDTO.MaLop = item.MaLop;
                var lop = db.tb_Lop.FirstOrDefault(t => t.MaLop == item.MaLop);
                kqDTO.TenLop = lop.TenLop;
                kqDTO.CreateBy = item.CreateBy;
                kqDTO.CreateDate = item.CreateDate;
                kqDTO.UpdateBy = item.UpdateBy;
                kqDTO.UpdateDate = item.UpdateDate;
                kqDTO.DeleteBy = item.DeleteBy;
                kqDTO.DeleteDate = item.DeleteDate;
                lsHS.Add(kqDTO);
            }
            return lsHS;
        }
        public List<tb_KetQuaDTO> getList()
        {
            var lst = db.tb_KetQua.ToList();
            List<tb_KetQuaDTO> lsHS = new List<tb_KetQuaDTO>();
            tb_KetQuaDTO kqDTO;
            foreach (var item in lst)
            {
                kqDTO = new tb_KetQuaDTO();
                kqDTO.MaHS = item.MaHS;
                var hs = db.tb_HocSinh.FirstOrDefault(t => t.MaHS == item.MaHS);
                kqDTO.HoTen = hs.HoTen;
                kqDTO.MaMH = item.MaMH;
                var mh = db.tb_MonHoc.FirstOrDefault(t => t.MaMH == item.MaMH);
                kqDTO.TenMH = mh.TenMH;
                kqDTO.DiemKT = item.DiemKT;
                kqDTO.DiemThiLan1 = item.DiemThiLan1;
                kqDTO.DiemThiLan2 = item.DiemTB;
                kqDTO.XepLoai = item.XepLoai;
                kqDTO.MaNamHoc = item.MaNamHoc;
                var nh = db.tb_NamHoc.FirstOrDefault(t => t.MaNamHoc == item.MaNamHoc);
                kqDTO.TenNamHoc = nh.TenNamHoc;
                kqDTO.MaHocKy = item.MaHocKy;
                var hk = db.tb_HocKy.FirstOrDefault(t => t.MaHocKy == item.MaHocKy);
                kqDTO.TenHocKy = hk.TenHocKy;
                kqDTO.MaLop = item.MaLop;
                var lop = db.tb_Lop.FirstOrDefault(t => t.MaLop == item.MaLop);
                kqDTO.TenLop = lop.TenLop;
                kqDTO.CreateBy = item.CreateBy;
                kqDTO.CreateDate = item.CreateDate;
                kqDTO.UpdateBy = item.UpdateBy;
                kqDTO.UpdateDate = item.UpdateDate;
                kqDTO.DeleteBy = item.DeleteBy;
                kqDTO.DeleteDate = item.DeleteDate;
                lsHS.Add(kqDTO);
            }
            return lsHS;
        }
        public tb_KetQua Add(tb_KetQua kq)
        {
            try
            {
                db.tb_KetQua.Add(kq);
                db.SaveChanges();
                return kq;
            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }
        }

        public tb_KetQua Update(tb_KetQua kq)
        {
            try
            {
                var _kq = db.tb_KetQua.FirstOrDefault(x => x.MaKQ == kq.MaKQ);
                _kq.MaMH = kq.MaMH;
                _kq.MaHS = kq.MaHS;
                _kq.DiemKT = kq.DiemKT;
                _kq.DiemTB = kq.DiemTB;
                _kq.DiemThiLan1 = kq.DiemThiLan1;
                _kq.DiemThiLan2 = kq.DiemThiLan2;
                _kq.XepLoai = kq.XepLoai;
                _kq.MaNamHoc = kq.MaNamHoc;
                _kq.MaLop = kq.MaLop;
                _kq.MaHocKy = kq.MaHocKy;
                db.SaveChanges();
                return kq;
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
                var _kq = db.tb_KetQua.FirstOrDefault(x => x.MaKQ == id);
                db.tb_KetQua.Remove(_kq);
                db.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
