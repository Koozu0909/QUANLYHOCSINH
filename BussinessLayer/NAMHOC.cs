using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BussinessLayer
{
    public class NAMHOC
    {
        private QUANLYHOCSINHEntities db = null;

        public NAMHOC()
        {
            db = new QUANLYHOCSINHEntities();
        }

        public tb_NamHoc getItem(int manh)
        {
            return db.tb_NamHoc.FirstOrDefault(x => x.MaNamHoc == manh);
        }

        public List<tb_NamHoc> getList()
        {
            return db.tb_NamHoc.ToList();
        }

        public tb_NamHoc Add(tb_NamHoc nh)
        {
            try
            {
                db.tb_NamHoc.Add(nh);
                db.SaveChanges();
                return nh;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public tb_NamHoc Update(tb_NamHoc nh)
        {
            try
            {
                var _nh = db.tb_NamHoc.FirstOrDefault(x => x.MaNamHoc == nh.MaNamHoc);
                Console.WriteLine(_nh);
                _nh.TenNamHoc = nh.TenNamHoc;
                _nh.UpdateBy = nh.UpdateBy;
                _nh.UpdateDate = nh.UpdateDate;
                db.SaveChanges();
                return nh;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int manh, int UserID)
        {
            try
            {
                var _nh = db.tb_NamHoc.FirstOrDefault(x => x.MaNamHoc == manh);
                _nh.DeleteBy = UserID;
                _nh.DeleteDate = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}