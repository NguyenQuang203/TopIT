using System;
using System.Collections.Generic;

namespace TopIT.Models
{
    public partial class TblTaikhoan
    {
        public string PkMaNd { get; set; } = null!;
        public string STenTk { get; set; } = null!;
        public string SPassword { get; set; } = null!;
        public string SLoainguoidung { get; set; } = null!;

        public virtual TblUngvien PkMaNd1 { get; set; } = null!;
        public virtual TblDoanhnghiep PkMaNdNavigation { get; set; } = null!;
    }
}
