using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnASP.Areas.Admin.Models
{
    public class BinhLuan
    {
        [Key]
        public int IDBL { get; set; }
        public int IDTK { get; set; }
        [ForeignKey("IDTK")]
        public virtual TaiKhoan taiKhoans { get; set; }


        public int IDBV { get; set; }
        [ForeignKey("IDBlog")]
        public virtual Blog blogs { get; set; }
        public int IDCH { get; set; }
        [ForeignKey("IDCauHoi")]
        public virtual CauHoi cauhois { get; set; }
        public DateTime NgayTao { get; set; }
        public string NoiDung { get; set; }
        public int TrangThai { get; set; }
        
    }
}
