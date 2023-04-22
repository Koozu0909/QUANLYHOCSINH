using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class TONGIAO
    {
        private QUANLYHOCSINHEntities db = null;

        public TONGIAO()
        {
            db = new QUANLYHOCSINHEntities();
        }

        public tb_TonGiao getItem(int matg)
        {
            return db.tb_TonGiao.FirstOrDefault(x => x.MaTonGiao == matg);
        }

        public List<tb_TonGiao> getList()
        {
            return db.tb_TonGiao.ToList();
        }

        public tb_TonGiao Add(tb_TonGiao nh)
        {
            try
            {
                db.tb_TonGiao.Add(nh);
                db.SaveChanges();
                return nh;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public tb_TonGiao Update(tb_TonGiao tg)
        {
            try
            {
                var _tg = db.tb_TonGiao.FirstOrDefault(x => x.MaTonGiao == tg.MaTonGiao);
                Console.WriteLine(_tg);
                _tg.TenTonGiao = tg.TenTonGiao;
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int matg, int UserID)
        {
            try
            {
                var _tg = db.tb_TonGiao.FirstOrDefault(x => x.MaTonGiao == matg);
                db.tb_TonGiao.Remove(_tg);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
