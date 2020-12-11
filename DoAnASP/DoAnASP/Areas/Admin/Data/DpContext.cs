

using DoAnASP.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnASP.Areas.User.Data
{
    public class DpContext : DbContext
    {
        public DpContext(DbContextOptions<DpContext> options) : base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BinhLuan> BinhLuans { get; set; }
        public DbSet<CauHoi> CauHois { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }



    }
}
