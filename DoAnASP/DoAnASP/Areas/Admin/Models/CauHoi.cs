using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnASP.Areas.Admin.Models
{
    public class CauHoi
    {
        [Key]
        public int IDBlog { get; set; }
        public string TieuDe { get; set; }
        public string HinhAnh { get; set; }
        public string TomTat { get; set; }
        public string NoiDung { get; set; }
        public int IDLoai { get; set; }
        [ForeignKey("IDLoai")]
        public virtual Loai loai { get; set; }
        public int IDNguoiTao { get; set; }
        [ForeignKey("IDTK")]
        public virtual TaiKhoan taikhoans { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayDuyet { get; set; }
        public int View { get; set; }
        public int IDNguoiDuyet { get; set; }

        public int TrangThai { get; set; }
    }
}
