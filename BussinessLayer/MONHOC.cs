using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BussinessLayer
{
    public class MONHOC
    {
        private QUANLYHOCSINHEntities db = null;

        public MONHOC()
        {
            db = new QUANLYHOCSINHEntities();
        }

        public tb_MonHoc getItem(int mamh)
        {
            return db.tb_MonHoc.FirstOrDefault(x => x.MaMH == mamh);
        }

        public List<tb_MonHoc> getList()
        {
            return db.tb_MonHoc.ToList();
        }

        public tb_MonHoc Add(tb_MonHoc mh)
        {
            try
            {
                db.tb_MonHoc.Add(mh);
                db.SaveChanges();
                return mh;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public tb_MonHoc Update(tb_MonHoc mh)
        {
            try
            {
                var _mh = db.tb_MonHoc.FirstOrDefault(x => x.MaMH == mh.MaMH);
                _mh.TenMH = mh.TenMH;
                _mh.SoTiet = mh.SoTiet;
                _mh.HeSo = mh.HeSo;
                _mh.UpdateBy = mh.UpdateBy;
                _mh.UpdateDate = mh.UpdateDate;
                db.SaveChanges();
                return mh;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int mamh, int UserID)
        {
            try
            {
                var _mh = db.tb_MonHoc.FirstOrDefault(x => x.MaMH == mamh);
                db.tb_MonHoc.Remove(_mh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}