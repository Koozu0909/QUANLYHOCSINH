using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class DANHMUCLOI
    {
        private QUANLYHOCSINHEntities db = null;

        public DANHMUCLOI()
        {
            db = new QUANLYHOCSINHEntities();
        }

        public tb_DanhMucLoi getItem(int maloi)
        {
            return db.tb_DanhMucLoi.FirstOrDefault(x => x.MaLoi == maloi);
        }

        public List<tb_DanhMucLoi> getList()
        {
            return db.tb_DanhMucLoi.ToList();
        }

        public tb_DanhMucLoi Add(tb_DanhMucLoi vp)
        {
            try
            {
                db.tb_DanhMucLoi.Add(vp);
                db.SaveChanges();
                return vp;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public tb_DanhMucLoi Update(tb_DanhMucLoi vp)
        {
            try
            {
                var _vp = db.tb_DanhMucLoi.FirstOrDefault(x => x.MaLoi == vp.MaLoi);
                _vp.TenLoi = vp.TenLoi;
                _vp.GhiChu = vp.GhiChu;
                _vp.Diem = vp.Diem;
                _vp.NghiemTrong = vp.NghiemTrong;
                _vp.UpdateBy = vp.UpdateBy;
                _vp.UpdateDate = DateTime.Now;
                db.SaveChanges();
                return vp;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int maloi, int UserID)
        {
            try
            {
                var _vp = db.tb_DanhMucLoi.FirstOrDefault(x => x.MaLoi == maloi);
                db.tb_DanhMucLoi.Remove(_vp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
