using System;
using System.Collections.Generic;

namespace TopIT.Models
{
    public partial class TblCvDangki
    {
        public string PkFkSMavielam { get; set; } = null!;
        public string PkFkSMaUv { get; set; } = null!;
        public DateTime DNgayDk { get; set; }
        public string? SNhanxet { get; set; }
        public string? SKetqua { get; set; }

        public virtual TblUngvien PkFkSMaUvNavigation { get; set; } = null!;
        public virtual TblVieclam PkFkSMavielamNavigation { get; set; } = null!;
    }
}
