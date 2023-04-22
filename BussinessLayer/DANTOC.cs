using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class DANTOC
    {
        private QUANLYHOCSINHEntities db = null;

        public DANTOC()
        {
            db = new QUANLYHOCSINHEntities();
        }

        public tb_DanToc getItem(int madt)
        {
            return db.tb_DanToc.FirstOrDefault(x => x.MaDanToc == madt);
        }
        public List<tb_DanToc> SearchByName(string kw)
        {

                var listdt = from c in db.tb_DanToc
                                where c.TenDanToc.Contains(kw)
                                select c;
                return listdt.ToList();
        }

        public List<tb_DanToc> getList()
        {
            return db.tb_DanToc.ToList();
        }

        public tb_DanToc Add(tb_DanToc nh)
        {
            try
            {
                db.tb_DanToc.Add(nh);
                db.SaveChanges();
                return nh;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public tb_DanToc Update(tb_DanToc nh)
        {
            try
            {
                var _nh = db.tb_DanToc.FirstOrDefault(x => x.MaDanToc == nh.MaDanToc);
                _nh.TenDanToc = nh.TenDanToc;
                db.SaveChanges();
                return nh;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int madt, int UserID)
        {
            try
            {
                var _nh = db.tb_DanToc.FirstOrDefault(x => x.MaDanToc == madt);
                db.tb_DanToc.Remove(_nh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
