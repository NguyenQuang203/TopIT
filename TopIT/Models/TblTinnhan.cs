using System;
using System.Collections.Generic;

namespace TopIT.Models
{
    public partial class TblTinnhan
    {
        public string PkSMatinnhan { get; set; } = null!;
        public string FkSMaUv { get; set; } = null!;
        public string FkSMaDn { get; set; } = null!;
        public string SNoidung { get; set; } = null!;
        public DateTime DThoigiangui { get; set; }

        public virtual TblDoanhnghiep FkSMaDnNavigation { get; set; } = null!;
        public virtual TblUngvien FkSMaUvNavigation { get; set; } = null!;
    }
}
