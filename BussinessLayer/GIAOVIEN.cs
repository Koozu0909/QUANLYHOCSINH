using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer.DTO;
using DataLayer;

namespace BussinessLayer
{
    public class GIAOVIEN
    {
        private QUANLYHOCSINHEntities db = null;

        public GIAOVIEN()
        {
            db = new QUANLYHOCSINHEntities();
        }

        public tb_GiaoVien getItem(int id)
        {
            return db.tb_GiaoVien.FirstOrDefault(x => x.MaGV == id);
        }

        public List<tb_GiaoVienDTO> SearchByName(string kw)
        {
            var lst = from c in db.tb_GiaoVien
                      where c.HoTen.Contains(kw)
                      select c;
            List<tb_GiaoVienDTO> lsGV = new List<tb_GiaoVienDTO>();
            tb_GiaoVienDTO gvDTO;
            foreach (var item in lst)
            {
                gvDTO = new tb_GiaoVienDTO();
                gvDTO.MaGV = item.MaGV;
                gvDTO.HoTen = item.HoTen;
                gvDTO.Ten = item.Ten;
                gvDTO.GioiTinh = item.GioiTinh;
                gvDTO.NgaySinh = item.NgaySinh;
                gvDTO.DiaChi = item.DiaChi;
                gvDTO.DienThoai = item.DienThoai;
                gvDTO.Email = item.Email;
                gvDTO.HinhAnh = item.HinhAnh;
                gvDTO.MaTrinhDo = item.MaTrinhDo;
                var td = db.tb_TrinhDo.FirstOrDefault(t => t.MaTrinhDo == item.MaTrinhDo);
                gvDTO.TenTrinhDo = td.TenTrinhDo;
                gvDTO.MaChucVu = item.MaChucVu;
                var cv = db.tb_ChucVu.FirstOrDefault(t => t.MaChucVu == item.MaChucVu);
                gvDTO.TenChucVu = cv.TenChucVu;
                gvDTO.CreateBy = item.CreateBy;
                gvDTO.CreateDate = item.CreateDate;
                gvDTO.UpdateBy = item.UpdateBy;
                gvDTO.UpdateDate = item.UpdateDate;
                gvDTO.DeleteBy = item.DeleteBy;
                gvDTO.DeleteDate = item.DeleteDate;
                lsGV.Add(gvDTO);
            }
            return lsGV;
        }

        public List<tb_GiaoVienDTO> getList()
        {
            var lst = db.tb_GiaoVien.ToList();
            List<tb_GiaoVienDTO> lsGV = new List<tb_GiaoVienDTO>();
            tb_GiaoVienDTO gvDTO;
            foreach (var item in lst)
            {
                gvDTO = new tb_GiaoVienDTO();
                gvDTO.MaGV = item.MaGV;
                gvDTO.HoTen = item.HoTen;
                gvDTO.Ten = item.Ten;
                gvDTO.GioiTinh = item.GioiTinh;
                gvDTO.NgaySinh = item.NgaySinh;
                gvDTO.DiaChi = item.DiaChi;
                gvDTO.DienThoai = item.DienThoai;
                gvDTO.Email = item.Email;
                gvDTO.HinhAnh = item.HinhAnh;
                gvDTO.MaTrinhDo = item.MaTrinhDo;
                var td = db.tb_TrinhDo.FirstOrDefault(t=> t.MaTrinhDo == item.MaTrinhDo);
                gvDTO.TenTrinhDo = td.TenTrinhDo;
                gvDTO.MaChucVu = item.MaChucVu;
                var cv= db.tb_ChucVu.FirstOrDefault(t => t.MaChucVu == item.MaChucVu);
                gvDTO.TenChucVu = cv.TenChucVu;
                gvDTO.CreateBy = item.CreateBy;
                gvDTO.CreateDate = item.CreateDate;
                gvDTO.UpdateBy = item.UpdateBy;
                gvDTO.UpdateDate = item.UpdateDate;
                gvDTO.DeleteBy = item.DeleteBy;
                gvDTO.DeleteDate = item.DeleteDate;
                lsGV.Add(gvDTO);
            }
            return lsGV;
        }

        public tb_GiaoVien Add(tb_GiaoVien gv)
        {
            try
            {
                db.tb_GiaoVien.Add(gv);
                db.SaveChanges();
                return gv;
            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }
        }

        public tb_GiaoVien Update(tb_GiaoVien magv)
        {
            try
            {
                var _gv = db.tb_GiaoVien.FirstOrDefault(x => x.MaGV == magv.MaGV);
                _gv.HoTen = magv.HoTen;
                _gv.Ten = magv.Ten;
                _gv.GioiTinh = magv.GioiTinh;
                _gv.NgaySinh = magv.NgaySinh;
                _gv.DiaChi = magv.DiaChi;
                _gv.DienThoai = magv.DienThoai;
                _gv.Email = magv.Email;
                _gv.MaTrinhDo = magv.MaTrinhDo;
                _gv.MaChucVu = magv.MaChucVu;
                _gv.UpdateBy = magv.UpdateBy;
                _gv.UpdateDate = magv.UpdateDate;
                db.SaveChanges();
                return magv;    
            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int id , int UserID)
        {
            try
            {
                var _gv = db.tb_GiaoVien.FirstOrDefault(x => x.MaGV == id);
               
                _gv.DeleteBy = UserID;
                _gv.DeleteDate = DateTime.Now;
                db.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
