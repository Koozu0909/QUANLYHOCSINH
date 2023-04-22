using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class TRINHDO
    {
        private QUANLYHOCSINHEntities db = null;

        public TRINHDO()
        {
            db = new QUANLYHOCSINHEntities();
        }

        public tb_TrinhDo getItem(int matd)
        {
            return db.tb_TrinhDo.FirstOrDefault(x => x.MaTrinhDo == matd);
        }

        public List<tb_TrinhDo> getList()
        {
            return db.tb_TrinhDo.ToList();
        }

        public tb_TrinhDo Add(tb_TrinhDo td)
        {
            try
            {
                db.tb_TrinhDo.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public tb_TrinhDo Update(tb_TrinhDo td)
        {
            try
            {
                var _td = db.tb_TrinhDo.FirstOrDefault(x => x.MaTrinhDo == td.MaTrinhDo);
                _td.TenTrinhDo = td.TenTrinhDo;
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int matd, int UserID)
        {
            try
            {
                var _td = db.tb_TrinhDo.FirstOrDefault(x => x.MaTrinhDo == matd);
                db.tb_TrinhDo.Remove(_td);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
