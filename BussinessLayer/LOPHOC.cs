using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BussinessLayer.DTO;

namespace BussinessLayer
{
    public class LOPHOC
    {
        private QUANLYHOCSINHEntities db = null;

        public LOPHOC()
        {
            db = new QUANLYHOCSINHEntities();
        }

        public tb_Lop getItem(int malop)
        {
            return db.tb_Lop.FirstOrDefault(x => x.MaLop == malop);
        }

        public List<tb_LopDTO> getList( int makhoilop)
        {
            var lst = db.tb_Lop.Where(x => x.MaKhoiLop == makhoilop).ToList();
            List<tb_LopDTO> lsLop = new List<tb_LopDTO>();
            tb_LopDTO lopDTO;
            foreach (var item in lst)
            {
                lopDTO = new tb_LopDTO();
                lopDTO.MaLop = item.MaLop;
                lopDTO.TenLop = item.TenLop;
                lopDTO.GhiChu = item.GhiChu;
                lopDTO.MaKhoiLop = item.MaKhoiLop;
                var nh = db.tb_KhoiLop.FirstOrDefault(t => t.MaKhoiLop == item.MaKhoiLop);
                lopDTO.TenKhoiLop = nh.TenKhoiLop;

                lsLop.Add(lopDTO);
            }
            return lsLop;
        }

        public tb_Lop Add(tb_Lop lop)
        {
            try
            {
                db.tb_Lop.Add(lop);
                db.SaveChanges();
                return lop;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public tb_Lop Update(tb_Lop lop)
        {
            try
            {
                var _lop = db.tb_Lop.FirstOrDefault(x => x.MaLop == lop.MaLop);
                _lop.TenLop = lop.TenLop;
                _lop.GhiChu = lop.GhiChu;
                _lop.MaKhoiLop = lop.MaKhoiLop;
                _lop.UpdateBy = lop.UpdateBy;
                _lop.UpdateDate = lop.UpdateDate;
                db.SaveChanges();
                return lop;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int macv, int UserID)
        {
            try
            {
                var _nh = db.tb_Lop.FirstOrDefault(x => x.MaLop == macv);
                db.tb_Lop.Remove(_nh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
