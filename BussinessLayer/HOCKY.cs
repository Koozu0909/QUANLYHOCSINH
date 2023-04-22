using BussinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class HOCKY
    {
        private QUANLYHOCSINHEntities db = null;

        public HOCKY()
        {
            db = new QUANLYHOCSINHEntities();
        }
        public tb_HocKy getItem(int mahk)
        {
            return db.tb_HocKy.FirstOrDefault(x => x.MaHocKy == mahk);
        }

        public List<tb_HocKyDTO> getList(int manamhoc)
        {
            var lst = db.tb_HocKy.Where(x => x.MaNamHoc == manamhoc).ToList();
            List<tb_HocKyDTO> lsHK = new List<tb_HocKyDTO>();
            tb_HocKyDTO hkDTO;
            foreach (var item in lst)
            {
                hkDTO = new tb_HocKyDTO();
                hkDTO.MaHocKy = item.MaHocKy;
                hkDTO.TenHocKy = item.TenHocKy;
                hkDTO.HeSo = item.HeSo;
                hkDTO.MaNamHoc = item.MaNamHoc;
                var nh = db.tb_NamHoc.FirstOrDefault(t => t.MaNamHoc == item.MaNamHoc);
                hkDTO.TenNamHoc = nh.TenNamHoc;

                lsHK.Add(hkDTO);
            }
            return lsHK;
        }

        public tb_HocKy Add(tb_HocKy hk)
        {
            try
            {
                db.tb_HocKy.Add(hk);
                db.SaveChanges();
                return hk;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public tb_HocKy Update(tb_HocKy hk)
        {
            try
            {
                var _hk = db.tb_HocKy.FirstOrDefault(x => x.MaHocKy == hk.MaHocKy);
                _hk.TenHocKy = hk.TenHocKy;
                _hk.HeSo = hk.HeSo;
                _hk.MaNamHoc = hk.MaNamHoc;
                _hk.UpdateBy = hk.UpdateBy;
                _hk.UpdateDate = hk.UpdateDate;
                db.SaveChanges();
                return hk;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int mahk, int UserID)
        {
            try
            {
                var _hk = db.tb_HocKy.FirstOrDefault(x => x.MaHocKy == mahk);
                db.tb_HocKy.Remove(_hk);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
