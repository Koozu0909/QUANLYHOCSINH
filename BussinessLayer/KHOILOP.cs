using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class KHOILOP
    {
        private QUANLYHOCSINHEntities db = null;

        public KHOILOP()
        {
            db = new QUANLYHOCSINHEntities();
        }

        public tb_KhoiLop getItem(int mackl)
        {
            return db.tb_KhoiLop.FirstOrDefault(x => x.MaKhoiLop == mackl);
        }

        public List<tb_KhoiLop> getList()
        {
            if (db != null && db.tb_KhoiLop != null)
            {
                return db.tb_KhoiLop.ToList();
            }
            else
            {
                return null;
            }
        }

        public tb_KhoiLop Add(tb_KhoiLop nh)
        {
            try
            {
                db.tb_KhoiLop.Add(nh);
                db.SaveChanges();
                return nh;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public tb_KhoiLop Update(tb_KhoiLop nh)
        {
            try
            {
                var _nh = db.tb_KhoiLop.FirstOrDefault(x => x.MaKhoiLop == nh.MaKhoiLop);
                Console.WriteLine(_nh);
                _nh.TenKhoiLop = nh.TenKhoiLop;
                db.SaveChanges();
                return nh;
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
                var _nh = db.tb_KhoiLop.FirstOrDefault(x => x.MaKhoiLop == macv);
                db.tb_KhoiLop.Remove(_nh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
