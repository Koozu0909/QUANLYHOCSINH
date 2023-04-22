using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BussinessLayer.DTO;

namespace BussinessLayer
{
    public class VIPHAM_CT
    {
        private QUANLYHOCSINHEntities db = null;

        public VIPHAM_CT()
        {
            db = new QUANLYHOCSINHEntities();
        }

        public tb_ViPham_CT getItem(int mavpct)
        {
            return db.tb_ViPham_CT.FirstOrDefault(x => x.MaVPCT == mavpct);
        }

        public List<tb_ViPham_CT> getList(int kw)
        {
            return db.tb_ViPham_CT.Where(x=> x.MaViPham == kw).ToList();
        }

        public List<tb_ViPham_CT_DTO> getListFull(int kw)
        {
            var lst =  db.tb_ViPham_CT.Where(x => x.MaViPham == kw).ToList();
            List<tb_ViPham_CT_DTO> lstDTO = new List<tb_ViPham_CT_DTO>();
            tb_ViPham_CT_DTO dto;
            foreach (var item in lst)
            {
                dto = new tb_ViPham_CT_DTO();
                dto.MaViPham = item.MaViPham;
                dto.MaVPCT = item.MaVPCT;
                dto.MaHS = item.MaHS;
                dto.MaLoi = item.MaLoi;
                dto.NgayViPham = item.NgayViPham;
                dto.Diem = item.Diem;
                dto.GhiChu = item.GhiChu;
                var loi = db.tb_DanhMucLoi.FirstOrDefault(x => x.MaLoi == item.MaLoi);
                dto.TenLoi = loi.TenLoi;
                var hs = db.tb_HocSinh.FirstOrDefault(x => x.MaHS == item.MaHS);
                dto.TenHS = hs.HoTen;
                lstDTO.Add(dto);

            }
            return lstDTO;
        }

        public tb_ViPham_CT Add(tb_ViPham_CT vpct)
        {
            try
            {
                db.tb_ViPham_CT.Add(vpct);
                db.SaveChanges();
                return vpct;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public tb_ViPham_CT Update(tb_ViPham_CT vpct)
        {
            try
            {
                var _vpct = db.tb_ViPham_CT.FirstOrDefault(x => x.MaVPCT == vpct.MaVPCT);
                _vpct.MaViPham = vpct.MaViPham;
                _vpct.MaHS = vpct.MaHS;
                _vpct.MaLoi = vpct.MaLoi;
                _vpct.NgayViPham = vpct.NgayViPham;
                _vpct.Diem = vpct.Diem;
                _vpct.GhiChu = vpct.GhiChu;
                db.SaveChanges();
                return vpct;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
        public void DeleteByVPId(int mavp)
        {
            try
            {
                var _vpcts = db.tb_ViPham_CT.Where(x => x.MaViPham == mavp);
                db.tb_ViPham_CT.RemoveRange(_vpcts);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int mavpct)
        {
            try
            {
                var _vpct = db.tb_ViPham_CT.FirstOrDefault(x => x.MaVPCT == mavpct);
                db.tb_ViPham_CT.Remove(_vpct);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}
