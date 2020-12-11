using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnASP.Areas.Admin.Models
{
    public class Loai
    {[Key]
    public int IDLoai { get; set; }
        public string  TieuDe { get; set; }
        public DateTime NgayTao { get; set; }
        public int IDNguoiTao { get; set; }
        [ForeignKey("IDTK")]
        public virtual TaiKhoan loai { get; set; }
        public ICollection<Blog> blogs { get; set; }
        public ICollection<CauHoi> cauhois { get; set; }

    }
}
