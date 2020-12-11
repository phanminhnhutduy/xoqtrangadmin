using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnASP.Areas.Admin.Models
{
    public class TaiKhoan
    {
        [Key]
        public int IDTK { get; set; }
        public string Ten { get; set; }
        public string Password { get; set; }
        public string HinhAnh { get; set; }
        public int Quyen { get; set; }
        public int TrangThai { get; set; }
    }
}
