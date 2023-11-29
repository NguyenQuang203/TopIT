using System;
using System.Collections.Generic;

namespace TopIT.Models
{
    public partial class TblDoanhnghiep
    {
        public TblDoanhnghiep()
        {
            TblTinnhans = new HashSet<TblTinnhan>();
            TblVieclams = new HashSet<TblVieclam>();
        }

        public string PkSMaDn { get; set; } = null!;
        public string STenDn { get; set; } = null!;
        public string SGioithieu { get; set; } = null!;
        public string SSdt { get; set; } = null!;
        public string SEmail { get; set; } = null!;
        public string SDiachi { get; set; } = null!;
        public string SUrlDn { get; set; } = null!;

        public virtual TblTaikhoan TblTaikhoan { get; set; } = null!;
        public virtual ICollection<TblTinnhan> TblTinnhans { get; set; }
        public virtual ICollection<TblVieclam> TblVieclams { get; set; }
    }
}
