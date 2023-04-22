using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace BussinessLayer
{
    public class VIPHAM
    { 

    private QUANLYHOCSINHEntities db = null;

    public VIPHAM()
    {
        db = new QUANLYHOCSINHEntities();
    }

    public tb_ViPham getItem(int madt)
    {
        return db.tb_ViPham.FirstOrDefault(x => x.MaViPham == madt);
    }

    public List<tb_ViPham> getList()
    {
        return db.tb_ViPham.ToList();
    }

        public List<tb_ViPham> getList(int manamhoc, int mahocky, int malop)
        {
            return db.tb_ViPham.Where(x=>x.MaNamHoc == manamhoc && x.MaHocKy == mahocky && x.MaLop== malop).ToList();
        }

        public tb_ViPham Add(tb_ViPham vp)
    {
        try
        {
            db.tb_ViPham.Add(vp);
            db.SaveChanges();
            return vp;
        }
        catch (Exception ex)
        {
            throw new Exception("Loi: " + ex.Message);
        }
    }

    public tb_ViPham Update(tb_ViPham vp)
    {
        try
        {
            var _vp = db.tb_ViPham.FirstOrDefault(x => x.MaViPham == vp.MaViPham);
                _vp.MaNamHoc = vp.MaNamHoc;
                _vp.MaHocKy = vp.MaHocKy;
                _vp.MaLop = vp.MaLop;
                _vp.NgayViPham = vp.NgayViPham;
                _vp.TongDiem = vp.TongDiem;
                _vp.TongSoLoi = vp.TongSoLoi;
                _vp.GhiChu = vp.GhiChu;
                _vp.UpdatedBy = vp.UpdatedBy;
                _vp.UpdatedDate = vp.UpdatedDate;
            db.SaveChanges();
            return vp;
        }
        catch (Exception ex)
        {
            throw new Exception("Loi: " + ex.Message);
        }
    }

    public void Delete(int mavp)
    {
        try
        {
            var _nh = db.tb_ViPham.FirstOrDefault(x => x.MaViPham == mavp);
            db.tb_ViPham.Remove(_nh);
            db.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception("Loi: " + ex.Message);
        }
    }
}
}
