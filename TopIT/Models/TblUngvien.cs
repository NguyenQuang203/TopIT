using System;
using System.Collections.Generic;

namespace TopIT.Models
{
    public partial class TblUngvien
    {
        SanGiaoDichViecLamContext db = new SanGiaoDichViecLamContext();

        public TblUngvien()
        {
            TblTinnhans = new HashSet<TblTinnhan>();
        }

        public string PkSMaUv { get; set; } = null!;
        public string STenUv { get; set; } = null!;
        public string SGioitinh { get; set; } = null!;
        public DateTime DNgaysinh { get; set; }
        public string SKinhnghiem { get; set; } = null!;
        public string SSdt { get; set; } = null!;
        public string SEmail { get; set; } = null!;
        public string? SDiachi { get; set; }
        public string? SUrlCv { get; set; }

        public virtual TblTaikhoan TblTaikhoan { get; set; } = null!;
        public virtual ICollection<TblTinnhan> TblTinnhans { get; set; }

        public List<TblUngvien> GetAllCandidate()
        {
            List<TblUngvien> lst = db.TblUngviens.ToList();
            return lst;
        }

        public void DelCandidate(string jobid)
        {
            TblUngvien uv = db.TblUngviens.Find(jobid);
            if(uv != null)
            {
                db.TblUngviens.Remove(uv);
                db.SaveChanges();
            }
            return;
            
        }

        public TblUngvien DetailCandidate(string jobid)
        {
            TblUngvien uv = db.TblUngviens.Find(jobid);
            return uv;
        }
    }
}
