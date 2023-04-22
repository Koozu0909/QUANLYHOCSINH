using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class CHUCVU
    {
        private QUANLYHOCSINHEntities db = null;

        public CHUCVU()
        {
            db = new QUANLYHOCSINHEntities();
        }

        public tb_ChucVu getItem(int macv)
        {
            return db.tb_ChucVu.FirstOrDefault(x => x.MaChucVu == macv);
        }

        public List<tb_ChucVu> getList()
        {
            return db.tb_ChucVu.ToList();
        }

        public tb_ChucVu Add(tb_ChucVu nh)
        {
            try
            {
                db.tb_ChucVu.Add(nh);
                db.SaveChanges();
                return nh;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public tb_ChucVu Update(tb_ChucVu nh)
        {
            try
            {
                var _nh = db.tb_ChucVu.FirstOrDefault(x => x.MaChucVu == nh.MaChucVu);
                Console.WriteLine(_nh);
                _nh.TenChucVu = nh.TenChucVu;
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
                var _nh = db.tb_ChucVu.FirstOrDefault(x => x.MaChucVu == macv);
                db.tb_ChucVu.Remove(_nh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
