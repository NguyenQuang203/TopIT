using System;
using System.Collections.Generic;

namespace TopIT.Models
{
    public partial class TblVieclam
    {
        SanGiaoDichViecLamContext db = new SanGiaoDichViecLamContext();

        public string PkSMavieclam { get; set; } = null!;
        public string FkSMaDn { get; set; } = null!;
        public string SMota { get; set; } = null!;
        public string SVitriviec { get; set; } = null!;
        public string SPhuongthuclam { get; set; } = null!;
        public string SHocvan { get; set; } = null!;
        public string SKinhnghiem { get; set; } = null!;
        public DateTime DNgaydang { get; set; }
        public DateTime DNgayketthuc { get; set; }

        public virtual TblDoanhnghiep FkSMaDnNavigation { get; set; } = null!;

        public List<TblVieclam> SearchIob(string filter)
        {
            List<TblVieclam> uv = db.TblVieclams.Where(x => x.SMota.ToLower().Contains(filter.ToLower()) == true ||
                   x.SVitriviec.ToLower().Contains(filter.ToLower()) == true ||
                   x.SPhuongthuclam.ToLower().Contains(filter.ToLower()) == true ||
                   x.SHocvan.ToLower().Contains(filter.ToLower()) == true ||
                   x.SKinhnghiem.ToLower().Contains(filter.ToLower()) == true).ToList();

            return uv;

        }

        public List<TblVieclam> GetAllJob()
        {
            List<TblVieclam> lst = db.TblVieclams.ToList();
            return lst;
        }

        public void DelJob(string jobid)
        {
            TblVieclam uv = db.TblVieclams.Find(jobid);
            db.TblVieclams.Remove(uv);
            db.SaveChanges();
        }

        public TblVieclam DetailJob(string jobid)
        {
            TblVieclam uv = db.TblVieclams.Find(jobid);
            return uv;
        }
    }
}
