using System;
using System.Collections.Generic;

namespace TopIT.Models
{
    public partial class TblCvLuu
    {
        public string PkFkSMaUv { get; set; } = null!;
        public string PkFkSMavieclam { get; set; } = null!;
        public string? STrangthai { get; set; }

        public virtual TblUngvien PkFkSMaUvNavigation { get; set; } = null!;
        public virtual TblVieclam PkFkSMavieclamNavigation { get; set; } = null!;
    }
}
